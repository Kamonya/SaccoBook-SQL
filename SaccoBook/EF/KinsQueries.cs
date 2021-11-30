using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaccoBook.EF
{
    class KinsQueries
    {
        static string connectionstring = AppResources.DatabaseConnection.ConnectionString();

        /**
        * Function returns member's Kins list
        * 
        * @param MembershipNumber | The member's membership number

        * @return List<Kin> | returns a List of kins
        */
        public static List<Kin> GetKinsList(string MembershipNumber)
        {
            List<Kin> KinsList = new List<Kin>();

            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT IdentificationDocumentNumber, MembershipNumber, FirstName, MiddleName, LastName, Email, PhoneNumber, Relationship, Occupation, LastModifiedBy, LastModifiedAt FROM [saccobook].[memberkins] WHERE MembershipNumber = '" + MembershipNumber + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    KinsList.Add(new Kin
                    {
                        IdentificationDocumentNumber = dr.GetString(0),
                        MembershipNumber = dr.GetString(1),
                        FirstName = dr.GetString(2),
                        MiddleName = dr.GetString(3),
                        LastName = dr.GetString(4),
                        Email = dr.GetString(5),
                        PhoneNumber = dr.GetString(6),
                        Relationship = dr.GetString(7),
                        Occupation = dr.GetString(8),
                        LastModifiedBy = dr.GetString(9),
                        LastModifiedAt = dr.GetString(10)
                    });
                }
                conn.Close();
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                  System.Diagnostics.EventLogEntryType.Warning);
            }

            return KinsList;
        }

        /**
        * Function creates new kin

        * @param IdentificationDocumentNumber | The kin's identification document number (ID number, Passport number or Birth Certificate Entry number)
        * @param MembershipNumber | The member's membership number the kin is being attached to
        * @param FirstName | The kin's first name
        * @param MiddleName | The kin's middle name
        * @param LastName | The kin's last name        
        * @param Email | The kin's email address
        * @param PhoneNumber | The kin's phone number
        * @param Relationship | The kind of relationship the kin shares with the member
        * @param Occupation | The kin's occupation
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if kin information is created / return false if not created
        */
        public static bool CreateKin(string IdentificationDocumentNumber, string MembershipNumber, string FirstName, string MiddleName, string LastName, string Email, string PhoneNumber, string Relationship, string Occupation, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO [saccobook].[memberkins](IdentificationDocumentNumber, MembershipNumber, FirstName, MiddleName, LastName, Email, PhoneNumber, Relationship, Occupation, LastModifiedBy, LastModifiedAt) VALUES (@IdentificationDocumentNumber, @MembershipNumber, @FirstName, @MiddleName, @LastName, @Email, @PhoneNumber, @Relationship, @Occupation, @LastModifiedBy, @LastModifiedAt)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@IdentificationDocumentNumber", IdentificationDocumentNumber);
                    cmd.Parameters.AddWithValue("@MembershipNumber", MembershipNumber);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@MiddleName", MiddleName);
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    cmd.Parameters.AddWithValue("@Relationship", Relationship);
                    cmd.Parameters.AddWithValue("@Occupation", Occupation);
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
        * Function updates kin information

        * @param IdentificationDocumentNumber | The kin's identification document number (ID number, Passport number or Birth Certificate Entry number)
        * @param MembershipNumber | The member's membership number the kin is being attached to
        * @param FirstName | The kin's first name
        * @param MiddleName | The kin's middle name
        * @param LastName | The kin's last name        
        * @param Email | The kin's email address
        * @param PhoneNumber | The kin's phone number
        * @param Relationship | The kind of relationship the kin shares with the member
        * @param Occupation | The kin's occupation
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if kin information is updated / return false if not created
        */
        public static bool UpdateKin(string IdentificationDocumentNumber, string MembershipNumber, string FirstName, string MiddleName, string LastName, string Email, string PhoneNumber, string Relationship, string Occupation, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[memberkins] SET MembershipNumber=@MembershipNumber,FirstName=@FirstName,MiddleName=@MiddleName,LastName=@LastName,Email=@Email,PhoneNumber=@PhoneNumber,Relationship=@Relationship,Occupation=@Occupation,LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt WHERE IdentificationDocumentNumber=@IdentificationDocumentNumber";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@IdentificationDocumentNumber", IdentificationDocumentNumber);
                    cmd.Parameters.AddWithValue("@MembershipNumber", MembershipNumber);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@MiddleName", MiddleName);
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    cmd.Parameters.AddWithValue("@Relationship", Relationship);
                    cmd.Parameters.AddWithValue("@Occupation", Occupation);
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
        * Function deletes kin 
        * 
        * @param IdentificationDocumentNumber | The kin's identification document number (ID number, Passport number or Birth Certificate Entry number)

        * @return bool | return true if kin is deleted / return false if not deleted
        */
        public static bool DeleteKin(string IdentificationDocumentNumber)
        {
            bool status = false;

            string sql = "DELETE FROM [saccobook].[memberkins] WHERE IdentificationDocumentNumber = @IdentificationDocumentNumber";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IdentificationDocumentNumber", IdentificationDocumentNumber);
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
        * Function returns kininformation
        * 
        * @param IdentificationDocumentNumber | The kin's identification document number (ID number, Passport number or Birth Certificate Entry number)
        * 
        * @return string | returns JSON string with NumberSeries data
        */
        public static string GetKinInfo(string IdentificationDocumentNumber)
        {
            string MembershipNumber = "", FirstName = "", MiddleName = "", LastName = "", Email = "", PhoneNumber = "", Relationship = "", Occupation = "", LastModifiedBy = "", LastModifiedAt = "", KinData = "";
            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT IdentificationDocumentNumber,MembershipNumber,FirstName,MiddleName,LastName,Email,PhoneNumber,Relationship,Occupation,LastModifiedBy,LastModifiedAt FROM [saccobook].[memberkins] WHERE IdentificationDocumentNumber = '" + IdentificationDocumentNumber + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    IdentificationDocumentNumber = dr.GetString(0);
                    MembershipNumber = dr.GetString(1);
                    FirstName = dr.GetString(2);
                    MiddleName = dr.GetString(3);
                    LastName = dr.GetString(4);
                    Email = dr.GetString(5);
                    PhoneNumber = dr.GetString(6);
                    Relationship = dr.GetString(7);
                    Occupation = dr.GetString(8);
                    LastModifiedBy = dr.GetString(9);
                    LastModifiedAt = dr.GetString(10);
                }
                conn.Close();

                var _Kin = new Kin
                {
                    IdentificationDocumentNumber = IdentificationDocumentNumber,
                    MembershipNumber = MembershipNumber,
                    FirstName = FirstName,
                    MiddleName = MiddleName,
                    LastName = LastName,
                    Email = Email,
                    PhoneNumber = PhoneNumber,
                    Relationship = Relationship,
                    Occupation = Occupation,
                    LastModifiedBy = LastModifiedBy,
                    LastModifiedAt = LastModifiedAt
                };
                KinData = JsonConvert.SerializeObject(_Kin);
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                  System.Diagnostics.EventLogEntryType.Warning);
            }
            return KinData;
        }
    }
}
