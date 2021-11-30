using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaccoBook.EF
{
    class SystemSettingsQueries
    {
        static string connectionstring = AppResources.DatabaseConnection.ConnectionString();

        public static bool HasSystemSettings()
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [saccobook].[sytemsettings]", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
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
        public static bool CreateSaccoInformation(string Name, string Address, string Address2, string PostCode , string City, string Country, string Phone, string Fax, string Email, string HomePage , byte[] Photo, string AfricasTalkingUsername, string AfricasTalkingAPIKey , bool SMSNotificationsEnabled, string SMTPServer , string SMTPServerPort , string UserId, string Password , bool EmailNotificationsEnabled , bool AutomaticDatabaseBackUpEnabled, string DatabaseBackUpPath , string CredentialType, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO [saccobook].[sytemsettings]
                   ([Name]
                   ,[Address]
                   ,[Address2]
                   ,[PostCode]
                   ,[City]
                   ,[Country]
                   ,[Phone]
                   ,[Fax]
                   ,[Email]
                   ,[HomePage]
                   ,[Photo]
                   ,[AfricasTalkingUsername]
                   ,[AfricasTalkingAPIKey]
                   ,[SMSNotificationsEnabled]
                   ,[SMTPServer]
                   ,[SMTPServerPort]
                   ,[UserId]
                   ,[Password]
                   ,[EmailNotificationsEnabled]
                   ,[AutomaticDatabaseBackUpEnabled]
                   ,[DatabaseBackUpPath]
                   ,[CredentialType]
                   ,[LastModifiedBy]
                   ,[LastModifiedAt])
             VALUES
                   (@Name
                   ,@Address
                   ,@Address2
                   ,@PostCode
                   ,@City
                   ,@Country
                   ,@Phone
                   ,@Fax
                   ,@Email
                   ,@HomePage
                   ,@Photo
                   ,@AfricasTalkingUsername
                   ,@AfricasTalkingAPIKey
                   ,@SMSNotificationsEnabled
                   ,@SMTPServer
                   ,@SMTPServerPort
                   ,@UserId
                   ,@Password
                   ,@EmailNotificationsEnabled
                   ,@AutomaticDatabaseBackUpEnabled
                   ,@DatabaseBackUpPath
                   ,@CredentialType
                   ,@LastModifiedBy
                   ,@LastModifiedAt)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Address2", Address2);
                    cmd.Parameters.AddWithValue("@PostCode", PostCode);
                    cmd.Parameters.AddWithValue("@City", City);
                    cmd.Parameters.AddWithValue("@Country", Country);
                    cmd.Parameters.AddWithValue("@Phone", Phone);
                    cmd.Parameters.AddWithValue("@Fax", Fax);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@HomePage", HomePage);
                    cmd.Parameters.AddWithValue("@Photo", Photo);
                    cmd.Parameters.AddWithValue("@AfricasTalkingUsername", AfricasTalkingUsername);
                    cmd.Parameters.AddWithValue("@AfricasTalkingAPIKey", AfricasTalkingAPIKey);
                    cmd.Parameters.AddWithValue("@SMSNotificationsEnabled", SMSNotificationsEnabled);
                    cmd.Parameters.AddWithValue("@SMTPServer", SMTPServer);
                    cmd.Parameters.AddWithValue("@SMTPServerPort", SMTPServerPort);
                    cmd.Parameters.AddWithValue("@UserId", UserId);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@EmailNotificationsEnabled", EmailNotificationsEnabled);
                    cmd.Parameters.AddWithValue("@AutomaticDatabaseBackUpEnabled", AutomaticDatabaseBackUpEnabled);
                    cmd.Parameters.AddWithValue("@DatabaseBackUpPath", DatabaseBackUpPath);
                    cmd.Parameters.AddWithValue("@CredentialType", CredentialType);
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
        public static bool UpdateSaccoInformation(string Name, string Address, string Address2, string PostCode, string City, string Country, string Phone, string Fax, string Email, string HomePage, byte[] Photo)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[sytemsettings]
                               SET [Name] = @Name
                                  ,[Address] = @Address
                                  ,[Address2] = @Address2
                                  ,[PostCode] = @PostCode
                                  ,[City] = @City
                                  ,[Country] = @Country
                                  ,[Phone] = @Phone
                                  ,[Fax] = @Fax
                                  ,[Email] = @Email
                                  ,[HomePage] = @HomePage
                                  ,[Photo] = @Photo
                                  ,[LastModifiedBy] = @LastModifiedBy
                                  ,[LastModifiedAt] = @LastModifiedAt";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Address2", Address2);
                    cmd.Parameters.AddWithValue("@PostCode", PostCode);
                    cmd.Parameters.AddWithValue("@City", City);
                    cmd.Parameters.AddWithValue("@Country", Country);
                    cmd.Parameters.AddWithValue("@Phone", Phone);
                    cmd.Parameters.AddWithValue("@Fax", Fax);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@HomePage", HomePage);
                    cmd.Parameters.AddWithValue("@Photo", Photo);
                    cmd.Parameters.AddWithValue("@LastModifiedBy", Login.LoggedInUser);
                    cmd.Parameters.AddWithValue("@LastModifiedAt", DateTime.Now.ToString());
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
        * Function returns system settings
        */
        public static string GetSystemSettings()
        {
            string SystemSettingsData = "";
          
            string Name = "";
            string Address = "";
            string Address2 = "";
            string PostCode = "";
            string City = "";
            string Country = "";
            string Phone = "";
            string Fax = "";
            string Email = "";
            string HomePage = "";
            byte[] Photo = null;


            string AfricasTalkingAPIKey = "";
            string AfricasTalkingUsername = ""; 
            int SMTPServerPort = 0; 
            bool SMSNotificationsEnabled = false; 
            string SMTPServer = ""; 
            bool AutomaticDatabaseBackUpEnabled = false; 
            string DatabaseBackUpPath = "";
            string UserId = ""; 
            string Password = ""; 
            bool EmailNotificationsEnabled = false; 
            string CredentialType = "", LastModifiedBy = "";string LastModifiedAt = "";
            
            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [saccobook].[sytemsettings]", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {                
                    Name = dr["Name"].ToString();
                    Address = dr["Address"].ToString();
                    Address2 = dr["Address2"].ToString();
                    PostCode = dr["PostCode"].ToString();
                    City = dr["City"].ToString();
                    Country = dr["Country"].ToString();
                    Phone = dr["Phone"].ToString();
                    Fax = dr["Fax"].ToString();
                    Email = dr["Email"].ToString();
                    HomePage = dr["HomePage"].ToString();

                    Photo = (byte[])(dr["Photo"]);

                    AfricasTalkingUsername = dr["AfricasTalkingUsername"].ToString();
                    AfricasTalkingAPIKey = dr["AfricasTalkingAPIKey"].ToString();
                    //SMSNotificationsEnabled = Convert.ToBoolean(dr["SMSNotificationsEnabled"].ToString());
                    SMTPServer = dr["SMTPServer"].ToString();
                    SMTPServerPort = Convert.ToInt32(dr["SMTPServerPort"].ToString());
                    UserId = dr["UserId"].ToString();
                    Password = dr["Password"].ToString();
                    //EmailNotificationsEnabled = Convert.ToBoolean(dr["EmailNotificationsEnabled"].ToString());
                    //AutomaticDatabaseBackUpEnabled = Convert.ToBoolean(dr["AutomaticDatabaseBackUpEnabled"].ToString());
                    DatabaseBackUpPath = dr["DatabaseBackUpPath"].ToString();
                    CredentialType = dr["CredentialType"].ToString();
                }
                conn.Close();

                var _SystemSettings = new SaccoBookSettings
                {
                    Name = Name,
                    
                    Address = Address,
                    Address2 = Address2,
                    City = City,
                    Country = Country,
                    PostCode = PostCode,
                    Email = Email,
                    Fax = Fax,
                    HomePage = HomePage,
                    Phone = Phone,
                    Photo = Photo,
                    AfricasTalkingAPIKey = AfricasTalkingAPIKey,
                    AfricasTalkingUsername = AfricasTalkingUsername,
                    SMSNotificationsEnabled = SMSNotificationsEnabled,
                    SMTPServer = SMTPServer,
                    SMTPServerPort = SMTPServerPort,
                    UserId = UserId,
                    Password = Password,
                    EmailNotificationsEnabled = EmailNotificationsEnabled,
                    AutomaticDatabaseBackUpEnabled = AutomaticDatabaseBackUpEnabled,
                    DatabaseBackUpPath = DatabaseBackUpPath,
                    CredentialType = CredentialType,
                    LastModifiedAt = LastModifiedAt,
                    LastModifiedBy = LastModifiedBy

                };
                SystemSettingsData = JsonConvert.SerializeObject(_SystemSettings);
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                System.Diagnostics.EventLogEntryType.Warning);
            }
            return SystemSettingsData;
        }
        /**
        * Function updates system settings
        * @param AfricasTalkingUsername | AfricasTalking Gateway Username
        * @param AfricasTalkingAPIKey | Africas1Talking API Key
        * @param SMSNotificationsEnabled | Is SMS Notifications Enabled
        * @param SMTPServer | The SMTP server
        * @param SMTPServerPort | The SMTP server port
        * @param UserId | The email UserId e.g janedoe@gmail.com
        * @param Password | The email account Password
        * @param EmailNotificationsEnabled | Is Email Notifications Enabled
        * @param LastModifiedBy | The user that last modified the recoed
        * @param LastModifiedAt | The time that the record was last modified

        * @return bool | return true if record is updated / return false if not updated
        */
        public static bool UpdateSettings(string AfricasTalkingUsername, string AfricasTalkingAPIKey, bool SMSNotificationsEnabled, string SMTPServer, string SMTPServerPort, string UserId, string Password, bool EmailNotificationsEnabled, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[sytemsettings] SET AfricasTalkingUsername=@AfricasTalkingUsername,AfricasTalkingAPIKey=@AfricasTalkingAPIKey,SMSNotificationsEnabled=@SMSNotificationsEnabled,SMTPServer=@SMTPServer,SMTPServerPort=@SMTPServerPort,UserId=@UserId,Password=@Password,EmailNotificationsEnabled=@EmailNotificationsEnabled,LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@AfricasTalkingUsername", AfricasTalkingUsername);
                    cmd.Parameters.AddWithValue("@AfricasTalkingAPIKey", AfricasTalkingAPIKey);
                    cmd.Parameters.AddWithValue("@SMSNotificationsEnabled", SMSNotificationsEnabled);
                    cmd.Parameters.AddWithValue("@SMTPServer", SMTPServer);
                    cmd.Parameters.AddWithValue("@SMTPServerPort", SMTPServerPort);
                    cmd.Parameters.AddWithValue("@UserId", UserId);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@EmailNotificationsEnabled", EmailNotificationsEnabled);
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
        public static bool UpdateDatabaseSettings(bool AutomaticDatabaseBackUpEnabled, string DatabaseBackUpPath, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[sytemsettings] SET DatabaseBackUpPath=@DatabaseBackUpPath,AutomaticDatabaseBackUpEnabled=@AutomaticDatabaseBackUpEnabled,LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {                    
                    cmd.Parameters.AddWithValue("@DatabaseBackUpPath", DatabaseBackUpPath);
                    cmd.Parameters.AddWithValue("@AutomaticDatabaseBackUpEnabled", AutomaticDatabaseBackUpEnabled);
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
        * Function returns list of countries in the database
        */
        public static string[] GetCountriesList()
        {
            string filename = Application.StartupPath + @"\AppResources\nationalities.json";
            List<string> list = new List<string>();

            try
            {
                string json = File.ReadAllText(filename);
                List<string> nationalities = JsonConvert.DeserializeObject<List<string>>(json);

                foreach (var item in nationalities)
                {
                    list.Add(item);
                }

            }
            catch (Exception es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                  System.Diagnostics.EventLogEntryType.Warning);
            }
            return list.ToArray();
        }
    }
}
