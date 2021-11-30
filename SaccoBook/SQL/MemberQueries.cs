using DevExpress.XtraEditors;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaccoBook.SQL
{
    class MemberQueries
    {
        static string connectionstring = AppResources.DatabaseConnection.ConnectionString();
        /**
        * Function returns members information
        * @param MembershipNumber | The member's membership number 

        * @return string | returns json string of member's information
        */
        public static string GetMemberInfo(string MembershipNumber)
        {
            string Name = ""; 
            string FirstName = "";
            string MiddleName = ""; 
            string LastName = "";
            string PhoneNumber = "";
            string AlternativeNumber = "";
            string Email = ""; 
            DateTime DateOfBirth = DateTime.Now; 
            string Gender = ""; 
            string Nationality = "";
            string NationalIdNumber = ""; 
            string TaxPIN = ""; 
            string Address = ""; 
            byte[] Photo = null; 
            string Password = "";
            string SourceOfIncome = ""; 
            string Employer = ""; 
            string JobPosition = ""; 
            string PayrollNumber = ""; 
            string EmployerAddress = ""; 
            string EmployerTelephoneNumber = ""; 
            double GrossMonthlyIncome = 0; 
            DateTime DateJoined = DateTime.Now; 
            string MembershipStatus = ""; 
            string LastModifiedBy = ""; 
            string LastModifiedAt = "", 
            MemberInfo="";


            string sql = "SELECT * FROM [saccobook].[members] WHERE MembershipNumber ='" + MembershipNumber + "'";
           
            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MembershipNumber = dr.GetString(0);
                    Name = dr.GetString(1);
                    FirstName = dr.GetString(2);
                    MiddleName = dr.GetString(3);
                    LastName = dr.GetString(4);
                    PhoneNumber = dr.GetString(5);
                    AlternativeNumber = dr.GetString(6);
                    Email = dr.GetString(7);
                    DateOfBirth = dr.GetDateTime(8);
                    Gender = dr.GetString(9);
                    Nationality = dr.GetString(10);
                    NationalIdNumber = dr.GetString(11);
                    TaxPIN = dr.GetString(12);
                    Address = dr.GetString(13);
                    Photo = (byte[])(dr["Photo"]);
                    Password = dr.GetString(15);
                    SourceOfIncome = dr.GetString(16);
                    Employer = dr.GetString(17);
                    JobPosition = dr.GetString(18);
                    PayrollNumber = dr.GetString(19);
                    EmployerAddress = dr.GetString(20);
                    EmployerTelephoneNumber = dr.GetString(21);
                    GrossMonthlyIncome = dr.GetDouble(22);
                    DateJoined = dr.GetDateTime(23);
                    MembershipStatus = dr.GetString(24);
                    LastModifiedBy = dr.GetString(25);
                    LastModifiedAt = dr.GetString(26);
                }
                conn.Close();

                var _Member = new Member
                {
                    MembershipNumber = MembershipNumber,
                    Name = Name,
                    FirstName = FirstName,
                    MiddleName = MiddleName,
                    LastName = LastName,
                    PhoneNumber = PhoneNumber,
                    AlternativeNumber = AlternativeNumber,
                    Email = Email,
                    DateOfBirth = DateOfBirth,
                    Gender = Gender,
                    Nationality = Nationality,
                    NationalIdNumber = NationalIdNumber,
                    TaxPIN = TaxPIN,
                    Address = Address,
                    Photo = Photo,
                    Password = Password,
                    SourceOfIncome = SourceOfIncome,
                    Employer = Employer,
                    JobPosition = JobPosition,
                    PayrollNumber = PayrollNumber,
                    EmployerAddress = EmployerAddress,
                    EmployerTelephoneNumber = EmployerTelephoneNumber,
                    GrossMonthlyIncome = GrossMonthlyIncome,
                    DateJoined = DateJoined,
                    MembershipStatus = MembershipStatus,
                    LastModifiedBy = LastModifiedBy,
                    LastModifiedAt = LastModifiedAt
                   // MemberKinsList = GetKinsList(MembershipNumber)
                };
                MemberInfo = JsonConvert.SerializeObject(_Member);
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                System.Diagnostics.EventLogEntryType.Warning);
            }
            return MemberInfo;
        }

        /**
        * Function creates new Member
        * @param MembershipNumber | The member's membership number
        * @param Name | The member's full name
        * @param FirstName | The member's first name
        * @param MiddleName | The member's middle name
        * @param LastName | The member's last name
        * @param PhoneNumber | The member's phone number
        * @param AlternativeNumber | The member's alternative phone number
        * @param Email | The member's email address
        * @param DateOfBirth | The member's date of birth
        * @param Gender | The member's gender
        * @param Nationality | The member's nationality
        * @param NationalIdNumber | The member's national id number
        * @param TaxPIN | The member's tax pin (KRA/URA)
        * @param Address | The member's address
        * @param Photo | The member's photo name
        * @param Password | The member's portal password
        * @param SourceOfIncome | The member's primary source of income
        * @param Employer | The member's current employer
        * @param JobPosition | The member's job postion
        * @param PayrollNumber | The member's payroll number
        * @param EmployerAddress | The member's employer's address
        * @param EmployerTelephoneNumber | The member's employer's phone number
        * @param GrossMonthlyIncome | The member's gross monthly income
        * @param DateJoined | The date member joined the sacco
        * @param MembershipStatus | The member's membership status
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if member information is created / return false if not created
        */
        public static bool CreateMember(string MembershipNumber, string Name, string FirstName, string MiddleName, string LastName, string PhoneNumber, string AlternativeNumber, string Email, string DateOfBirth, string Gender, string Nationality, string NationalIdNumber, string TaxPIN, string Address, byte[] Photo, string Password,
        string SourceOfIncome, string Employer, string JobPosition, string PayrollNumber, string EmployerAddress, string EmployerTelephoneNumber, string GrossMonthlyIncome,
        string DateJoined, string MembershipStatus, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO [saccobook].[members](MembershipNumber, Name, FirstName, MiddleName, LastName, PhoneNumber, AlternativeNumber, Email, DateOfBirth, Gender, Nationality, NationalIdNumber, TaxPIN, Address, Photo, Password, SourceOfIncome, Employer, JobPosition, PayrollNumber, EmployerAddress, EmployerTelephoneNumber, GrossMonthlyIncome, DateJoined, MembershipStatus, MembershipType, LastModifiedBy, LastModifiedAt) VALUES (@MembershipNumber, @Name, @FirstName, @MiddleName, @LastName, @PhoneNumber, @AlternativeNumber, @Email, @DateOfBirth, @Gender, @Nationality, @NationalIdNumber, @TaxPIN, @Address, @Photo, @Password, @SourceOfIncome, @Employer, @JobPosition, @PayrollNumber, @EmployerAddress, @EmployerTelephoneNumber, @GrossMonthlyIncome, @DateJoined, @MembershipStatus, @MembershipType, @LastModifiedBy, @LastModifiedAt)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MembershipNumber", MembershipNumber);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@MiddleName", MiddleName);
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    cmd.Parameters.AddWithValue("@AlternativeNumber", AlternativeNumber);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@Nationality", Nationality);
                    cmd.Parameters.AddWithValue("@NationalIdNumber", NationalIdNumber);
                    cmd.Parameters.AddWithValue("@TaxPIN", TaxPIN);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Photo", Photo);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@SourceOfIncome", SourceOfIncome);
                    cmd.Parameters.AddWithValue("@Employer", Employer);
                    cmd.Parameters.AddWithValue("@JobPosition", JobPosition);
                    cmd.Parameters.AddWithValue("@PayrollNumber", PayrollNumber);
                    cmd.Parameters.AddWithValue("@EmployerAddress", EmployerAddress);
                    cmd.Parameters.AddWithValue("@EmployerTelephoneNumber", EmployerTelephoneNumber);
                    cmd.Parameters.AddWithValue("@GrossMonthlyIncome", GrossMonthlyIncome);
                    cmd.Parameters.AddWithValue("@DateJoined", DateJoined);
                    cmd.Parameters.AddWithValue("@MembershipStatus", MembershipStatus);
                    cmd.Parameters.AddWithValue("@MembershipType", "Individual"); 
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
        * Function updates new Member
        * @param MembershipNumber | The member's membership number
        * @param Name | The member's full name
        * @param FirstName | The member's first name
        * @param MiddleName | The member's middle name
        * @param LastName | The member's last name
        * @param PhoneNumber | The member's phone number
        * @param AlternativeNumber | The member's alternative phone number
        * @param Email | The member's email address
        * @param DateOfBirth | The member's date of birth
        * @param Gender | The member's gender
        * @param Nationality | The member's nationality
        * @param NationalIdNumber | The member's national id number
        * @param TaxPIN | The member's tax pin (KRA/URA)
        * @param Address | The member's address
        * @param Photo | The member's photo name
        * @param Password | The member's portal password
        * @param SourceOfIncome | The member's primary source of income
        * @param Employer | The member's current employer
        * @param JobPosition | The member's job postion
        * @param PayrollNumber | The member's payroll number
        * @param EmployerAddress | The member's employer's address
        * @param EmployerTelephoneNumber | The member's employer's phone number
        * @param GrossMonthlyIncome | The member's gross monthly income
        * @param DateJoined | The date member joined the sacco
        * @param MembershipStatus | The member's membership status
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if member information is updated / return false if not updated
        */
        public static bool UpdateMember(string MembershipNumber, string Name, string FirstName, string MiddleName, string LastName, string PhoneNumber, string AlternativeNumber, string Email, string DateOfBirth, string Gender, string Nationality, string NationalIdNumber, string TaxPIN, string Address, byte[] Photo, string Password,
        string SourceOfIncome, string Employer, string JobPosition, string PayrollNumber, string EmployerAddress, string EmployerTelephoneNumber, string GrossMonthlyIncome,
        string DateJoined, string MembershipStatus, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[members] SET Name=@Name,FirstName=@FirstName,MiddleName=@MiddleName,LastName=@LastName,PhoneNumber=@PhoneNumber,AlternativeNumber=@AlternativeNumber,Email=@Email,DateOfBirth=@DateOfBirth,Gender=@Gender,Nationality=@Nationality,NationalIdNumber=@NationalIdNumber,TaxPIN=@TaxPIN,Address=@Address,Photo=@Photo,Password=@Password,SourceOfIncome=@SourceOfIncome,Employer=@Employer,JobPosition=@JobPosition,PayrollNumber=@PayrollNumber,EmployerAddress=@EmployerAddress,EmployerTelephoneNumber=@EmployerTelephoneNumber,GrossMonthlyIncome=@GrossMonthlyIncome,DateJoined=@DateJoined,MembershipStatus=@MembershipStatus,LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt WHERE MembershipNumber=@MembershipNumber";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MembershipNumber", MembershipNumber);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@MiddleName", MiddleName);
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    cmd.Parameters.AddWithValue("@AlternativeNumber", AlternativeNumber);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@Nationality", Nationality);
                    cmd.Parameters.AddWithValue("@NationalIdNumber", NationalIdNumber);
                    cmd.Parameters.AddWithValue("@TaxPIN", TaxPIN);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Photo", Photo);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@SourceOfIncome", SourceOfIncome);
                    cmd.Parameters.AddWithValue("@Employer", Employer);
                    cmd.Parameters.AddWithValue("@JobPosition", JobPosition);
                    cmd.Parameters.AddWithValue("@PayrollNumber", PayrollNumber);
                    cmd.Parameters.AddWithValue("@EmployerAddress", EmployerAddress);
                    cmd.Parameters.AddWithValue("@EmployerTelephoneNumber", EmployerTelephoneNumber);
                    cmd.Parameters.AddWithValue("@GrossMonthlyIncome", GrossMonthlyIncome);
                    cmd.Parameters.AddWithValue("@DateJoined", DateJoined);
                    cmd.Parameters.AddWithValue("@MembershipStatus", MembershipStatus);
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
        * Function deletes Members 
        * @param MembershipNumber | The member's membership number

        * @return bool | return true if member is deleted / return false if not deleted
        */
        public static bool DeleteMember(string MembershipNumber)
        {
            bool status = false;

            string sql = "DELETE FROM [saccobook].[members] WHERE MembershipNumber = @MembershipNumber";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@MembershipNumber", MembershipNumber);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conn.Close();

                status = true;

            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                 System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }

        /**
        * Function checks if Id Number passed exists in database
        * @param MembershipNumber | The member's membership number

        * @return bool | return true if id number exists / return false if not exists
        */
        public static bool IsNationalIdNumberExist(string NationalIdNumber)
        {
            bool status = false;

            string sql = "SELECT NationalIdNumber FROM [saccobook].[members] WHERE NationalIdNumber = '" + NationalIdNumber + "'";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    status = true;
                }
                conn.Close();
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }

        /**
        * Function checks if Id Number for specified member exists in database
        * @param NationalIdNumber | The member's Id number
        * @param MembershipNumber | The member's Membership Number

        * @return bool | return true if id number exists / return false if not exists
        */
        public static bool IsNationalIdNumberExistForMember(string NationalIdNumber, string MembershipNumber)
        {
            bool status = false;

            string sql = "SELECT NationalIdNumber FROM [saccobook].[members] WHERE NationalIdNumber = '" + NationalIdNumber + "' AND MembershipNumber ='"+ MembershipNumber + "'";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    status = true;
                }
                conn.Close();
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }

        /**
        * Function checks if Email passed exists in database
        * @param Email | The member's email

        * @return bool | return true if email exists/ return false if doesnt exist
        */
        public static bool IsEmailExist(string Email)
        {
            bool status = false;

            string sql = "SELECT Email FROM [saccobook].[members] WHERE Email = '" + Email + "'";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    status = true;
                }
                conn.Close();
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }

        /**
        * Function checks if Email for specified member exists in database 
        * @param Email | The member's email
        * @param MembershipNumber | The member's Membership Number

        * @return bool | return true if email exists/ return false if doesnt exist
        */
        public static bool IsEmailExistForMember(string Email, string MembershipNumber)
        {
            bool status = false;

            string sql = "SELECT Email FROM [saccobook].[members] WHERE Email = '" + Email + "' AND MembershipNumber = '"+ MembershipNumber + "'";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    status = true;
                }
                conn.Close();
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }

        /**
        * Function checks if TaxPIN passed exists in database
        * @param TaxPIN | The member's TaxPIN

        * @return bool | return true if TaxPIN exists / false if doesn't exist
        */
        public static bool IsTaxPINExist(string TaxPIN)
        {
            bool status = false;

            string sql = "SELECT TaxPIN FROM [saccobook].[members] WHERE TaxPIN = '" + TaxPIN + "'";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    status = true;
                }
                conn.Close();
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                 System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }

        /**
       * Function checks if TaxPIN for specified member exists in database
       * @param TaxPIN | The member's TaxPIN
       * @param MembershipNumber | The member's Membership Number

       * @return bool | return true if TaxPIN exists / false if doesn't exist
       */
        public static bool IsTaxPINExistForMember(string TaxPIN, string MembershipNumber)
        {
            bool status = false;

            string sql = "SELECT TaxPIN FROM [saccobook].[members] WHERE TaxPIN = '" + TaxPIN + "' AND MembershipNumber = '"+ MembershipNumber + "'";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    status = true;
                }
                conn.Close();
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                 System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }

        /**
        * Function checks if TaxPIN passed exists in database
        * @param PhoneNumber | The member's Phone Number

        * @return bool | return true if PhoneNumber exists / false if doesn't exist
        */
        public static bool IsPhoneNumberExist(string PhoneNumber)
        {
            bool status = false;

            string sql = "SELECT PhoneNumber FROM [saccobook].[members] WHERE PhoneNumber = '" + PhoneNumber + "'";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    status = true;
                }
                conn.Close();
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                 System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }

        /**
        * Function checks if TaxPIN for specified member exists in database
        * @param PhoneNumber | The member's Phone Number
        * @param MembershipNumber | The member's Membership Number

        * @return bool | return true if PhoneNumber exists / false if doesn't exist
        */
        public static bool IsPhoneNumberExistForMember(string PhoneNumber, string MembershipNumber)
        {
            bool status = false;

            string sql = "SELECT PhoneNumber FROM [saccobook].[members] WHERE PhoneNumber = '" + PhoneNumber + "' AND MembershipNumber = '"+ MembershipNumber + "'";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    status = true;
                }
                conn.Close();
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }

        /**
        * Function returns active members list

        * @return string [] | returns a string array of membership numbers of active members
        */
        public static string[] GetActiveMemberList()
        {
            List<string> list = new List<string>();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT MembershipNumber FROM members WHERE MembershipStatus ='Active'", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                  System.Diagnostics.EventLogEntryType.Warning);
            }
            return list.ToArray();
        }
        //Notification
        public static void SendMemberRegistrationNotification(string PhoneNumber, string FullName, string IdNumber, string Date, string Time, string Email)
        {
            string MemberRegistrationSetting = NotificationTemplatesQueries.GetNotificationSettingInfo("MEMBERREGISTRATION");

            dynamic GetNotificationSettingInfoResponseObject = JObject.Parse(MemberRegistrationSetting);

            string NotificationTemplateId = GetNotificationSettingInfoResponseObject.NotificationTemplateId;
            bool NotificationsEnabled = GetNotificationSettingInfoResponseObject.NotificationsEnabled;

            if (AppResources.AppConstants.IsSytemNotificationsEnabled())
            {
                if (NotificationsEnabled)
                {
                    NotificationTemplatesQueries.QueueNotification(NotificationTemplateId, PhoneNumber, FullName, IdNumber, "", "", "", "", "", Date, Time, Email, "Member Registration");
                }
            }
                
        }
        /**
        * Function  lists Active members on search control except a specified one
        * 
        * @param _SearchLookUpEdit | SearchLookUpEdit control to be loaded
        * @param MembershipNumber | Specified member to be excluded
        */
        public static void LoadMembers(DevExpress.XtraEditors.SearchLookUpEdit _SearchLookUpEdit, string MembershipNumber)
        {
            string sql = @"select members.MembershipNumber, members.Name
                              from members members
                             where ((members.MembershipStatus = 'Active')
                                   and (members.MembershipNumber <> '"+MembershipNumber+"'))";
            AppResources.AppFunctions.LoadSearchLookUpEdit(_SearchLookUpEdit, sql);
        }
        public static void LoadActiveMembers(DevExpress.XtraEditors.SearchLookUpEdit _SearchLookUpEdit, string MembershipNumber)
        {
            string sql = @" SELECT TOP (1000) [MembershipNumber]
                              ,[Name]
                          FROM [Sacco Book].[saccobook].[members] WHERE [MembershipStatus] ='Active'";
            AppResources.AppFunctions.LoadSearchLookUpEdit(_SearchLookUpEdit, sql);
        }
        /*
        * Function returns SQL string for fetching members of a specified status
        * 
        * @param status | The member's membership status
        * 
        * @return string | returns SQL string for fetching members of the specified status
        */
        public static string LoadMembersList(string status)
        {
            string sql = @"select MembershipNumber,Name, PhoneNumber, Email, Gender,PayrollNumber,DateJoined,MembershipStatus
                              from [saccobook].[members]
                             where (MembershipStatus = '" + status + "')";

            return sql;
        }
        /**
        * Function returns Member's Membership Number
        * @param sql | The member's email

        * @return string | return true if email exists/ return false if doesnt exist
        */
        public static string GetMembershipNumber(string sql)
        {
            string MembershipNumber = null;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MembershipNumber = reader.GetString(0); 
                }
                conn.Close();
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                System.Diagnostics.EventLogEntryType.Warning);
            }
            return MembershipNumber;
        }

        public static string LoadMembersRecords()
        {
            string sql = "select \"saccobook.members\".\"MembershipNumber\",\"saccobook.members\".\"MembershipType\",\"saccobook.members\".\"Name\",\"saccobook.members\".\"PhoneNumber\",\"saccobook.members\".\"Email\",\"saccobook.members\".\"NationalIdNumber\",\"saccobook.members\".\"Gender\",\"saccobook.members\".\"DateJoined\" from \"saccobook\".\"members\" \"saccobook.members\"";
            return sql;
        }
    }
}
