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
    class BeneficiariesQueries
    {
        static string connectionstring = AppResources.DatabaseConnection.ConnectionString();

        /**
        * Function returns member's Beneficiaries list
        * 
        * @param MembershipNumber | The member's membership number

        * @return List<Beneficiary> | returns a List of Beneficiaries
        */
        public static List<Beneficiary> GetBeneficiariesList(string MembershipNumber)
        {
            List<Beneficiary> BeneficiariesList = new List<Beneficiary>();

            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT IdentificationDocumentNumber, MembershipNumber, FirstName, MiddleName, LastName, Email, PhoneNumber, Relationship, Occupation, LastModifiedBy, LastModifiedAt FROM [saccobook].[memberbeneficiaries] WHERE MembershipNumber = '" + MembershipNumber + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BeneficiariesList.Add(new Beneficiary
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
            catch (SqlException ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                    System.Diagnostics.EventLogEntryType.Warning);
            }

            return BeneficiariesList;
        }

        /**
        * Function creates new Beneficiary

        * @param IdentificationDocumentNumber | The Beneficiary's identification document number (ID number, Passport number or Birth Certificate Entry number)
        * @param MembershipNumber | The member's membership number the Beneficiary is being attached to
        * @param FirstName | The Beneficiary's first name
        * @param MiddleName | The Beneficiary's middle name
        * @param LastName | The Beneficiary's last name        
        * @param Email | The Beneficiary's email address
        * @param PhoneNumber | The Beneficiary's phone number
        * @param Relationship | The kind of relationship the Beneficiary shares with the member
        * @param Occupation | The Beneficiary's occupation
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if Beneficiary information is created / return false if not created
        */
        public static bool CreateBeneficiary(string IdentificationDocumentNumber, string MembershipNumber, string FirstName, string MiddleName, string LastName, string Email, string PhoneNumber, string Relationship, string Occupation, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO [saccobook].[memberbeneficiaries](IdentificationDocumentNumber, MembershipNumber, FirstName, MiddleName, LastName, Email, PhoneNumber, Relationship, Occupation, LastModifiedBy, LastModifiedAt) VALUES (@IdentificationDocumentNumber, @MembershipNumber, @FirstName, @MiddleName, @LastName, @Email, @PhoneNumber, @Relationship, @Occupation, @LastModifiedBy, @LastModifiedAt)";
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

            catch (SqlException ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                      System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }

        /**
        * Function updates kin information

        * @param IdentificationDocumentNumber | The Beneficiary's identification document number (ID number, Passport number or Birth Certificate Entry number)
        * @param MembershipNumber | The member's membership number the Beneficiary is being attached to
        * @param FirstName | The Beneficiary's first name
        * @param MiddleName | The Beneficiary's middle name
        * @param LastName | The Beneficiary's last name        
        * @param Email | The Beneficiary's email address
        * @param PhoneNumber | The Beneficiary's phone number
        * @param Relationship | The kind of relationship the Beneficiary shares with the member
        * @param Occupation | The Beneficiary's occupation
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if Beneficiary information is updated / return false if not created
        */
        public static bool UpdateBeneficiary(string IdentificationDocumentNumber, string MembershipNumber, string FirstName, string MiddleName, string LastName, string Email, string PhoneNumber, string Relationship, string Occupation, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[memberbeneficiaries] SET MembershipNumber=@MembershipNumber,FirstName=@FirstName,MiddleName=@MiddleName,LastName=@LastName,Email=@Email,PhoneNumber=@PhoneNumber,Relationship=@Relationship,Occupation=@Occupation,LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt WHERE IdentificationDocumentNumber=@IdentificationDocumentNumber";
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

            catch (SqlException ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                       System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }

        /**
        * Function deletes Beneficiary 
        * 
        * @param IdentificationDocumentNumber | The Beneficiary's identification document number (ID number, Passport number or Birth Certificate Entry number)

        * @return bool | return true if Beneficiary is deleted / return false if not deleted
        */
        public static bool DeleteBeneficiary(string IdentificationDocumentNumber)
        {
            bool status = false;

            string sql = "DELETE FROM [saccobook].[memberbeneficiaries] WHERE IdentificationDocumentNumber = @IdentificationDocumentNumber";
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
            catch (SqlException ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                    System.Diagnostics.EventLogEntryType.Warning);
            }
            return status;
        }

        /**
        * Function returns Beneficiary information
        * 
        * @param IdentificationDocumentNumber | The Beneficiary's identification document number (ID number, Passport number or Birth Certificate Entry number)
        * 
        * @return string | returns JSON string with NumberSeries data
        */
        public static string GetBeneficiaryInfo(string IdentificationDocumentNumber)
        {
            string MembershipNumber = "", FirstName = "", MiddleName = "", LastName = "", Email = "", PhoneNumber = "", Relationship = "", Occupation = "", LastModifiedBy = "", LastModifiedAt = "", BeneficiaryData = "";
            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT IdentificationDocumentNumber,MembershipNumber,FirstName,MiddleName,LastName,Email,PhoneNumber,Relationship,Occupation,LastModifiedBy,LastModifiedAt FROM [saccobook].[memberbeneficiaries] WHERE IdentificationDocumentNumber = '" + IdentificationDocumentNumber + "'", conn);
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

                var _Beneficiary = new Beneficiary
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
                BeneficiaryData = JsonConvert.SerializeObject(_Beneficiary);
            }
            catch (SqlException ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                    System.Diagnostics.EventLogEntryType.Warning);
            }
            return BeneficiaryData;
        }
    }
}
