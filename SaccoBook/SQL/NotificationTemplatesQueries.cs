using DevExpress.XtraEditors;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SaccoBook.SQL
{
    class NotificationTemplatesQueries
    {
        static string connectionstring = AppResources.DatabaseConnection.ConnectionString();
       /**
       * Function returns notification template data
       */
        public static string GetNotificationTemplateInfo(string Id)
        {
            string NotificationTemplateData = "";
            string Document = "";
            string EmailTemplate = "";
            string SMSTemplate = "";
            string LastModifiedBy = ""; ;
            string LastModifiedAt = "";
            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Document, EmailTemplate, SMSTemplate, LastModifiedBy, LastModifiedAt FROM [saccobook].[notificationtemplates] WHERE Id  = '" + Id + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    Document = dr.GetString(0);
                    EmailTemplate = dr.GetString(1);
                    SMSTemplate = dr.GetString(2);
                    LastModifiedBy = dr.GetString(3);
                    LastModifiedAt = dr.GetString(4);

                }
                conn.Close();

                var _NotificationTemplate = new NotificationTemplate
                {
                    Document = Document,
                    EmailTemplate = EmailTemplate,
                    SMSTemplate = SMSTemplate,
                    LastModifiedBy = LastModifiedBy,
                    LastModifiedAt = LastModifiedAt
                };
                NotificationTemplateData = JsonConvert.SerializeObject(_NotificationTemplate);
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                System.Diagnostics.EventLogEntryType.Warning);
            }
            return NotificationTemplateData;
        }
       /**
        * Function creates notification template
        */
        public static bool CreateNotificationTemplate(string Document, string EmailTemplate, string SMSTemplate, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO [saccobook].[notificationtemplates]( Document, EmailTemplate, SMSTemplate, LastModifiedBy, LastModifiedAt) VALUES ( @Document, @EmailTemplate, @SMSTemplate, @LastModifiedBy, @LastModifiedAt)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Document", Document);
                    cmd.Parameters.AddWithValue("@EmailTemplate", EmailTemplate);
                    cmd.Parameters.AddWithValue("@SMSTemplate", SMSTemplate);
                    cmd.Parameters.AddWithValue("@LastModifiedBy", LastModifiedBy);
                    cmd.Parameters.AddWithValue("@LastModifiedAt", LastModifiedAt);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status = true;
                }
            }

            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                  System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }
        /**
        * Function returns notification setting data
        */
        public static string GetNotificationSettingInfo(string Id)
        {
            string NotificationTemplateSettingsData = "";
            int NotificationTemplateId = 0;
            bool NotificationsEnabled = false;
            string Description = "";
            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT NotificationTemplateId, NotificationsEnabled, Description FROM [saccobook].[notificationtemplatesettings] WHERE Id  = '" + Id + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    NotificationTemplateId = dr.GetInt32(0);
                    NotificationsEnabled = Convert.ToBoolean(dr["NotificationsEnabled"]); 
                    Description = dr.GetString(2);
                }
                conn.Close();
                //create JSON without classes
                var _notificationtemplatesettings = new
                {
                    NotificationTemplateId = NotificationTemplateId,
                    NotificationsEnabled = NotificationsEnabled,
                    Description = Description
                };

                //Tranform it to Json object
                NotificationTemplateSettingsData = JsonConvert.SerializeObject(_notificationtemplatesettings);
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                System.Diagnostics.EventLogEntryType.Warning);
            }

            return NotificationTemplateSettingsData;
        }
        //QueueNotification
        public static bool QueueNotification(string NotificationTemplateId, string PhoneNumber, string FullName, string IdNumber, string Balance, string Amount, string TransactionReferenceNumber, string TransactionCharge, string EnquiryNumber, string Date, string Time, string Email, string EmailSubject)
        {
            bool status = false;

            //get Email and SMS Templates

            string GetNotificationTemplateInfoResponse = GetNotificationTemplateInfo(NotificationTemplateId);
            dynamic GetNotificationTemplateInfoResponseObject = JObject.Parse(GetNotificationTemplateInfoResponse);


            string SMSTemplateText = GetNotificationTemplateInfoResponseObject.SMSTemplate;
            string EmailTemplateText = GetNotificationTemplateInfoResponseObject.EmailTemplate;

            //send Email
            string EmailBody = null;

            if (Email != "" && AppResources.RegexFunctions.IsValidEmailAddress(Email))
            {
                EmailBody = String.Format(EmailTemplateText, PhoneNumber, FullName, IdNumber, Balance, Amount, TransactionReferenceNumber, TransactionCharge, EnquiryNumber, Date, Time);
            }

            //send SMS message
            string SMSBody = null;

            //remove this

            PhoneNumber = "254701964636";

            if (PhoneNumber != "" && AppResources.RegexFunctions.IsValidPhoneNumber(PhoneNumber))
            {
                SMSBody = String.Format(SMSTemplateText, PhoneNumber, FullName, IdNumber, Balance, Amount, TransactionReferenceNumber, TransactionCharge, EnquiryNumber, Date, Time);
            }
            //Add notification to ques
           if (CreateNotificationQueue(FullName, Email, EmailSubject, EmailBody, false, PhoneNumber, SMSBody, false, DateTime.Now.ToString(), Login.LoggedInUser, DateTime.Now.ToString()))
           {
                status = true;
           }
            return status;
        }
        /**
        * Function updates notification setting data
        */
        public static bool UpdateNotificationSettings(string Id, string Description, string NotificationTemplateId, bool NotificationsEnabled, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE notificationtemplatesettings SET Description=@Description,NotificationTemplateId=@NotificationTemplateId,NotificationsEnabled=@NotificationsEnabled,LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt WHERE Id=@Id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@NotificationTemplateId", NotificationTemplateId);
                    cmd.Parameters.AddWithValue("@NotificationsEnabled", NotificationsEnabled);
                    cmd.Parameters.AddWithValue("@LastModifiedBy", LastModifiedBy);
                    cmd.Parameters.AddWithValue("@LastModifiedAt", LastModifiedAt);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status = true;
                }
            }

            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                  System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }

        public static bool CreateNotificationQueue(string RecipientName, string EmailAddress, string EmailSubject, string EmailBody, bool IsEmailSent, string ReciepientMobileNumber, string SMSBody, bool IsSMSSent, string DateTimeSent, string LastModifiedBy, string LastModifiedAt) 
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO notifications(RecipientName, EmailAddress, EmailSubject, EmailBody, IsEmailSent, ReciepientMobileNumber, SMSBody, IsSMSSent, DateTimeSent, LastModifiedBy, LastModifiedAt) VALUES (@RecipientName, @EmailAddress, @EmailSubject, @EmailBody, @IsEmailSent, @ReciepientMobileNumber, @SMSBody, @IsSMSSent, @DateTimeSent, @LastModifiedBy, @LastModifiedAt) ";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@RecipientName", RecipientName);
                    cmd.Parameters.AddWithValue("@EmailAddress", EmailAddress);
                    cmd.Parameters.AddWithValue("@EmailSubject", EmailSubject);
                    cmd.Parameters.AddWithValue("@EmailBody", EmailBody);
                    cmd.Parameters.AddWithValue("@IsEmailSent", IsEmailSent);
                    cmd.Parameters.AddWithValue("@ReciepientMobileNumber", ReciepientMobileNumber);
                    cmd.Parameters.AddWithValue("@SMSBody", SMSBody);
                    cmd.Parameters.AddWithValue("@IsSMSSent", IsSMSSent);
                    cmd.Parameters.AddWithValue("@DateTimeSent", DateTimeSent);
                    cmd.Parameters.AddWithValue("@LastModifiedBy", LastModifiedBy);
                    cmd.Parameters.AddWithValue("@LastModifiedAt", LastModifiedAt);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status = true;
                }
            }

            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                   System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }
        public static string GetNotificationList()
        {
            List<Notification> list = new List<Notification>();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT RecipientName, EmailAddress, EmailSubject, EmailBody, IsEmailSent, ReciepientMobileNumber, SMSBody, IsSMSSent, Id FROM [saccobook].[notifications] WHERE IsEmailSent = false OR IsSMSSent = false ORDER BY Id DESC", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Notification { 
                        RecipientName = reader.GetString(0), 
                        EmailAddress = reader.GetString(1), 
                        EmailSubject = reader.GetString(2),
                        EmailBody = reader.GetString(3),
                        IsEmailSent = reader.GetBoolean(4),
                        ReciepientMobileNumber = reader.GetString(5),
                        SMSBody = reader.GetString(6),
                        IsSMSSent = reader.GetBoolean(7),
                        Id = reader.GetInt32(8)
                    });
                }

            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                  System.Diagnostics.EventLogEntryType.Warning);
            }
            return JsonConvert.SerializeObject(list);
        }
        public static bool UpdateNotificationQueue(string Id, string IsSent, bool Status, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[notifications] SET " + IsSent + "=@IsSent,LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt WHERE Id = @Id ";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@IsSent", Status);
                    cmd.Parameters.AddWithValue("@LastModifiedBy", LastModifiedBy);
                    cmd.Parameters.AddWithValue("@LastModifiedAt", LastModifiedAt);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status = true;
                }
            }

            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                  System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }
        public static bool SendEmailNotification(string Email, string ReciepientFullName, string EmailSubject, string EmailBody)
        {
          bool status = false;

            if (Email != "" && AppResources.RegexFunctions.IsValidEmailAddress(Email))
            {
                
                if (AppResources.EmailFunctions.SendMail(Email, ReciepientFullName, EmailSubject, EmailBody))
                {
                    status = true;
                }
            }

            return status;
        }
        public static bool SendSMSNotification(string PhoneNumber, string SMSBody)
        {            
            bool status = false;

            if (PhoneNumber != "" && AppResources.RegexFunctions.IsValidPhoneNumber(PhoneNumber))
            {
                if (AppResources.AppFunctions.SendTextMessage(PhoneNumber, SMSBody))
                {
                    status = true;
                }
            }
            return status;
        }
    }
}
