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
    class GeneralLedgerQueries
    {
        static string connectionstring = AppResources.DatabaseConnection.ConnectionString();

        /**
        * Function creates G/L Account
        * 
        * @param Code | Specifies the G/L Account Code
        * @param ParentCode | Specifies the G/L Account Parent Code
        * @param Name | Specifies the G/L Account name
        * @param Description | Specifies the Description for the G/L Account
        * @param IncomeBalanceSheet | Specifies if G/L account belongs to an Income Statement or Balance Sheet
        * @param BalanceAtDate | Specifies the G/L Account balance
        * @param DebitAmount | Specifies the G/L Account total DR amount
        * @param CreditAmount | Specifies the G/L Account total CR amount
        * @param IsBlocked | Specifies if G/L Account is blocked or not
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified
        * 
        * return bool | return true if CreateGLAccount is created / return false if not created 
        */
        public static bool CreateGLAccount(string Code, string ParentCode, string Name, string Description, string AccountType, string IncomeBalanceSheet, bool DirectPosting, double BudgetedAmount, double BalanceAtDate, double DebitAmount, double CreditAmount, bool IsBlocked, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO [saccobook].[generalledgeraccounts] (Code, ParentCode, Name, Description, AccountType, IncomeBalanceSheet, DirectPosting, BudgetedAmount, BalanceAtDate, DebitAmount, CreditAmount, IsBlocked, LastModifiedBy, LastModifiedAt) VALUES (@Code, @ParentCode, @Name, @Description, @AccountType, @IncomeBalanceSheet, @DirectPosting, @BudgetedAmount, @BalanceAtDate, @DebitAmount, @CreditAmount, @IsBlocked, @LastModifiedBy, @LastModifiedAt)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Code", Code);
                    cmd.Parameters.AddWithValue("@ParentCode", ParentCode);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@AccountType", AccountType);
                    cmd.Parameters.AddWithValue("@IncomeBalanceSheet", IncomeBalanceSheet);
                    cmd.Parameters.AddWithValue("@DirectPosting", DirectPosting);
                    cmd.Parameters.AddWithValue("@BudgetedAmount", BudgetedAmount); 
                    cmd.Parameters.AddWithValue("@BalanceAtDate", BalanceAtDate);
                    cmd.Parameters.AddWithValue("@DebitAmount", DebitAmount);
                    cmd.Parameters.AddWithValue("@CreditAmount", CreditAmount);
                    cmd.Parameters.AddWithValue("@IsBlocked", IsBlocked);
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
        * Function updates G/L Account
        * 
        * @param Code | Specifies the G/L Account Code
        * @param ParentCode | Specifies the G/L Account Parent Code
        * @param Name | Specifies the G/L Account name
        * @param Description | Specifies the Description for the G/L Account
        * @param IncomeBalanceSheet | Specifies if G/L account belongs to an Income Statement or Balance Sheet
        * @param BalanceAtDate | Specifies the G/L Account balance
        * @param DebitAmount | Specifies the G/L Account total DR amount
        * @param CreditAmount | Specifies the G/L Account total CR amount
        * @param IsBlocked | Specifies if G/L Account is blocked or not
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified
        * 
        * return bool | return true if CreateGLAccount is updated / return false if not updated
        */
        public static bool UpdateGLAccount(string Code, string ParentCode, string Name, string Description, string IncomeBalanceSheet, string BalanceAtDate, string DebitAmount, string CreditAmount, bool IsBlocked, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[generalledgeraccounts] SET ParentCode=@ParentCode,Name=@Name,Description=@Description,IncomeBalanceSheet=@IncomeBalanceSheet,BalanceAtDate=@BalanceAtDate,DebitAmount=@DebitAmount,CreditAmount=@CreditAmount, IsBlocked =@IsBlocked, LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt WHERE Code=@Code";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Code", Code);
                    cmd.Parameters.AddWithValue("@ParentCode", ParentCode);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@Income/BalanceSheet", IncomeBalanceSheet);
                    cmd.Parameters.AddWithValue("@BalanceAtDate", BalanceAtDate);
                    cmd.Parameters.AddWithValue("@DebitAmount", DebitAmount);
                    cmd.Parameters.AddWithValue("@CreditAmount", CreditAmount);
                    cmd.Parameters.AddWithValue("@IsBlocked", IsBlocked);
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
        * Function deletes G/L Account 
        * 
        * @param Code | The G/L Account Code
        * @return bool | return true if G/L Account is deleted / return false if not deleted
        */
        public static bool DeleteGLAccount(string Code)
        {
            bool status = false;

            string sql = "DELETE FROM [saccobook].[generalledgeraccounts] WHERE Code = @Code";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Code", Code);
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
        * Function returns G/L Account information
        * 
        * @param Id | The record Id
        * @return string | returns JSON string with NumberSeries data
        */
        public static string GetGeneralLedgerAccountInfo(string Code)
        {
            string ParentCode = "", Name = "", Description = "", IncomeBalanceSheet = "", BalanceAtDate = "", DebitAmount = "", CreditAmount = "", LastModifiedBy = "", LastModifiedAt = "", GeneralLedgerAccountData = "";
            bool IsBlocked = false;
            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Code,ParentCode,Name,Description,Income/BalanceSheet,BalanceAtDate,DebitAmount,CreditAmount,IsBlocked,LastModifiedBy,LastModifiedAt FROM [saccobook].[generalledgeraccounts] WHERE Code  = '" + Code + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Code = dr.GetString(0);
                    ParentCode = dr.GetString(1);
                    Name = dr.GetString(2);
                    Description = dr.GetString(3);
                    IncomeBalanceSheet = dr.GetString(4);
                    BalanceAtDate = dr.GetString(5);
                    DebitAmount = dr.GetString(6);
                    CreditAmount = dr.GetString(7);
                    IsBlocked = dr.GetBoolean(8);
                    LastModifiedBy = dr.GetString(9);
                    LastModifiedAt = dr.GetString(10);
                }
                conn.Close();

                var _GeneralLedgerAccount = new GeneralLedgerAccount
                {
                    Code = Code,
                    ParentCode = ParentCode,
                    Name = Name,
                    Description = Description,
                    IncomeBalanceSheet = IncomeBalanceSheet,
                    BalanceAtDate = BalanceAtDate,
                    DebitAmount = DebitAmount,
                    CreditAmount = CreditAmount,
                    IsBlocked = IsBlocked,
                    LastModifiedBy = LastModifiedBy,
                    LastModifiedAt = LastModifiedAt
                };
                GeneralLedgerAccountData = JsonConvert.SerializeObject(_GeneralLedgerAccount);
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                  System.Diagnostics.EventLogEntryType.Warning);
            }
            return GeneralLedgerAccountData;
        }
        public static string GetGeneralLedgerAccounts()
        {
            string sql = @"SELECT TOP (1000) [Code]
                          ,[ParentCode]
                          ,[Name], [Code] as AccountCode
                          ,[AccountType]
                          ,[IncomeBalanceSheet]
                          ,[DirectPosting]
                          ,[BudgetedAmount]
                          ,[BalanceAtDate]
                          ,[DebitAmount]
                          ,[CreditAmount]
                          ,[IsBlocked]
                      FROM[Sacco Book].[saccobook].[generalledgeraccounts]";
            return sql;
        }

    }
}
