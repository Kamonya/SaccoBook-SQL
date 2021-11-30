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

namespace SaccoBook.SQL
{
    class BankQueries
    {
        static string connectionstring = AppResources.DatabaseConnection.ConnectionString();

        /**
        * Function returns member's bank accounts list
        * 
        * @param MembershipNumber | The member's membership number
        
        * @return List<MemberBankAccount> | returns a List of member's bank accounts 
        */
        public static List<MemberBankAccount> GetBankAccountsList(string MembershipNumber)
        {
            List<MemberBankAccount> BankAccountList = new List<MemberBankAccount>();

            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MembershipNumber, BankName, Branch, AccountNumber, LastModifiedBy, LastModifiedAt FROM [saccobook].[memberbankaccounts] WHERE MembershipNumber = '" + MembershipNumber + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BankAccountList.Add(new MemberBankAccount
                    {
                        MembershipNumber = dr.GetString(0),
                        BankName = dr.GetString(1),
                        Branch = dr.GetString(2),
                        AccountNumber = dr.GetString(3),
                        LastModifiedBy = dr.GetString(4),
                        LastModifiedAt = dr.GetString(5),
                    });
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                    System.Diagnostics.EventLogEntryType.Warning);
            }

            return BankAccountList;
        }

        /**
        * Function creates new member bank account
               
        * @param MembershipNumber | The member's membership number
        * @param BankName | The bank name
        * @param Branch | The bank branch
        * @param AccountNumber | The member's bank account number
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if bank account is created / return false if not created
        */
        public static bool CreateBankAccount(string MembershipNumber, string BankName, string Branch, string AccountNumber, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO [saccobook].[memberbankaccounts] (MembershipNumber, BankName, Branch, AccountNumber, LastModifiedBy, LastModifiedAt) VALUES (@MembershipNumber, @BankName, @Branch, @AccountNumber, @LastModifiedBy, @LastModifiedAt) ";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MembershipNumber", MembershipNumber);
                    cmd.Parameters.AddWithValue("@BankName", BankName);
                    cmd.Parameters.AddWithValue("@Branch", Branch);
                    cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
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
        * Function updates new member bank account
               
        * @param MembershipNumber | The member's membership number
        * @param BankName | The bank name
        * @param Branch | The bank branch
        * @param AccountNumber | The member's bank account number
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if bank account is updates / return false if not created
        */
        public static bool UpdateBankAccount(string MembershipNumber, string BankName, string Branch, string AccountNumber, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[memberbankaccounts] SET MembershipNumber=@MembershipNumber,BankName=@BankName,Branch=@Branch,AccountNumber=@AccountNumber,LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt WHERE AccountNumber=@AccountNumber AND MembershipNumber=@MembershipNumber";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MembershipNumber", MembershipNumber);
                    cmd.Parameters.AddWithValue("@BankName", BankName);
                    cmd.Parameters.AddWithValue("@Branch", Branch);
                    cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
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
        * Function deletes member bank accounts 
        * 
        * @param MembershipNumber | The member's membership number
        * @param AccountNumber | The member's account number

        * @return bool | return true if bank account is deleted / return false if not deleted
        */
        public static bool DeleteBankAccount(string MembershipNumber, string AccountNumber)
        {
            bool status = false;

            string sql = "DELETE FROM [saccobook].[memberbankaccounts] WHERE WHERE AccountNumber=@AccountNumber AND MembershipNumber=@MembershipNumber";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@MembershipNumber", MembershipNumber);
                cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
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
        * Function returns bank account information
        * 
        * @param MembershipNumber | The member's membership number
        * @param _BankAccountNumber | The member's bank account number
        
        * @return string | returns JSON string with bank account data
        */
        public static string GetBankAccountInfo(string MembershipNumber, string _BankAccountNumber)
        {
            string BankName = "", Branch = "",  LastModifiedBy = "", LastModifiedAt = "", MemberBankAccountData = "";
            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MembershipNumber, BankName, Branch, AccountNumber, LastModifiedBy, LastModifiedAt FROM [saccobook].[memberbankaccounts] WHERE AccountNumber ='" + _BankAccountNumber + "' AND MembershipNumber = '"+ MembershipNumber + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MembershipNumber = dr.GetString(0);
                    BankName = dr.GetString(1);
                    Branch = dr.GetString(2);
                    _BankAccountNumber = dr.GetString(3);
                    LastModifiedBy = dr.GetString(4);
                    LastModifiedAt = dr.GetString(5);
                }
                conn.Close();

                var _MemberBankAccount = new MemberBankAccount
                {
                    MembershipNumber = MembershipNumber,
                    BankName = BankName,
                    Branch = Branch,
                    AccountNumber = _BankAccountNumber,
                    LastModifiedBy = LastModifiedBy,
                    LastModifiedAt = LastModifiedAt
                };
                MemberBankAccountData = JsonConvert.SerializeObject(_MemberBankAccount);
            }
            catch (SqlException ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                    System.Diagnostics.EventLogEntryType.Warning);
            }
            return MemberBankAccountData;
        }
        /**
        * Function loads member's bank accounts to SearchLookUpEdit
        * 
        * @param _SearchLookUpEdit | The SearchLookUpEdit to be loaded
        * @param MembershipNumber | The member's membership number
        
        * @return string | returns JSON string with bank account data
        */
        public static void LoadMembersBankAccounts(DevExpress.XtraEditors.SearchLookUpEdit _SearchLookUpEdit, string MembershipNumber)
        {
            string sql = @"select `memberbankaccounts`.`BankName`,
                                       `memberbankaccounts`.`Branch`,
                                       `memberbankaccounts`.`AccountNumber`
                                  from `memberbankaccounts` `memberbankaccounts`
                                 where
                                       (`memberbankaccounts`.`MembershipNumber` = '"+ MembershipNumber + "')";

            AppResources.AppFunctions.LoadSearchLookUpEdit(_SearchLookUpEdit, sql);
        }
    }
}
