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
    class SavingsQueries
    {
        static string connectionstring = AppResources.DatabaseConnection.ConnectionString();

        /******************************** SAVINGS ACCOUNT TYPE****************************/

        public static string GetSavingAccountTypes()
        {
            string sql = "select \"saccobook.savingsaccounttypes\".* from \"saccobook\".\"savingsaccounttypes\" \"saccobook.savingsaccounttypes\"";

            return sql;
        }
        public static void LoadSavingAccountTypes(SearchLookUpEdit _SearchLookUpEdit)
        {
            string sql = "select \"saccobook.savingsaccounttypes\".\"Code\",\"saccobook.savingsaccounttypes\".\"Name\" from \"saccobook\".\"savingsaccounttypes\" \"saccobook.savingsaccounttypes\"";
            AppResources.AppFunctions.LoadSearchLookUpEdit(_SearchLookUpEdit, sql);
        }

        /**
        * Function returns Savings Account Type information
        * @param Code | The Savings Account Type Code
        * @return string | returns JSON string with Savings Account Type data
        */
        public static string GetSavingsAccountTypeInfo(string Code)
        {
            string Name = "", Description = "";
            double MinimumOpeningBalance = 0.00, MinimumMonthlyContributions = 0.00, MaximumAmountWithdrawableInADay = 0.00, WithdrawalCharge = 0.00;
            string LastModifiedBy = "", LastModifiedAt = "", SavingsTypeData="";
            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(" SELECT Code, Name, MinimumOpeningBalance, MinimumMonthlyContributions, MaximumAmountWithdrawableInADay, WithdrawalCharge, Description, LastModifiedBy, LastModifiedAt FROM [saccobook].[savingsaccounttypes] WHERE Code = '" + Code + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Code = dr.GetString(0);
                    Name = dr.GetString(1);
                    Description = dr.GetString(2);
                    MinimumOpeningBalance = dr.GetDouble(3);
                    MinimumMonthlyContributions =  dr.GetDouble(4);
                    MaximumAmountWithdrawableInADay =  dr.GetDouble(5);
                    WithdrawalCharge =  dr.GetDouble(6);
                    LastModifiedBy = dr.GetString(7);
                    LastModifiedAt = dr.GetString(8); 
                }
                conn.Close();

                var _SavingsType = new SavingsType
                {
                    Code = Code,
                    Name = Name,
                    Description = Description,
                    MinimumOpeningBalance = MinimumOpeningBalance,
                    MinimumMonthlyContributions = MinimumMonthlyContributions,
                    MaximumAmountWithdrawableInADay = MaximumAmountWithdrawableInADay,
                    WithdrawalCharge = WithdrawalCharge,
                    LastModifiedBy = LastModifiedBy,
                    LastModifiedAt = LastModifiedAt,
                };
                SavingsTypeData = JsonConvert.SerializeObject(_SavingsType);
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                System.Diagnostics.EventLogEntryType.Warning);
            }
            return SavingsTypeData;
        }

        /**
        * Function creates Savings Account Type 
        * @param Code | The Savings Account Type Code
        * @param Name | The savings account type name
        * @param Description | The savings account type description
        * @param MinimumOpeningBalance | The savings account type minimum opening balance
        * @param MinimumMonthlyContributions | The savings account type minimum monthly contribution
        * @param MaximumAmountWithdrawableInADay | The savings account type maximum amount withdrawable in a day
        * @param WithdrawalCharge | savings account type withdrawal charge
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified
        * @return bool | return true if Savings Account Type is created / return false if not created
        */
        public static bool CreateSavingsAccountType(string Code, string Name, double MinimumOpeningBalance, double MinimumMonthlyContributions, double MaximumAmountWithdrawableInADay, double WithdrawalCharge, string Description, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO [saccobook].[savingsaccounttypes](Code, Name, Description, MinimumOpeningBalance, MinimumMonthlyContributions, MaximumAmountWithdrawableInADay, WithdrawalCharge, LastModifiedBy, LastModifiedAt) VALUES (@Code, @Name, @Description, @MinimumOpeningBalance, @MinimumMonthlyContributions, @MaximumAmountWithdrawableInADay, @WithdrawalCharge, @LastModifiedBy, @LastModifiedAt)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Code", Code);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@MinimumOpeningBalance", MinimumOpeningBalance);
                    cmd.Parameters.AddWithValue("@MinimumMonthlyContributions", MinimumMonthlyContributions);
                    cmd.Parameters.AddWithValue("@MaximumAmountWithdrawableInADay", MaximumAmountWithdrawableInADay);
                    cmd.Parameters.AddWithValue("@WithdrawalCharge", WithdrawalCharge);
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
        * Function updates Savings Account Type 
        * @param Code | The Savings Account Type Code
        * @param Name | The savings account type name
        * @param Description | The savings account type description
        * @param MinimumOpeningBalance | The savings account type minimum opening balance
        * @param MinimumMonthlyContributions | The savings account type minimum monthly contribution
        * @param MaximumAmountWithdrawableInADay | The savings account type maximum amount withdrawable in a day
        * @param WithdrawalCharge | savings account type withdrawal charge
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified
        * @return bool | return true if Savings Account Type is created / return false if not created
        */
        public static bool UpdateSavingsAccountType(string Code, string Name, string MinimumOpeningBalance, string MinimumMonthlyContributions, string MaximumAmountWithdrawableInADay, string WithdrawalCharge, string Description, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[savingsaccounttypes] SET Name=@Name,Description=@Description,MinimumOpeningBalance=@MinimumOpeningBalance,MinimumMonthlyContributions=@MinimumMonthlyContributions,MaximumAmountWithdrawableInADay=@MaximumAmountWithdrawableInADay,WithdrawalCharge=@WithdrawalCharge,LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt WHERE Code=@Code";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Code", Code);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@MinimumOpeningBalance", MinimumOpeningBalance);
                    cmd.Parameters.AddWithValue("@MinimumMonthlyContributions", MinimumMonthlyContributions);
                    cmd.Parameters.AddWithValue("@MaximumAmountWithdrawableInADay", MaximumAmountWithdrawableInADay);
                    cmd.Parameters.AddWithValue("@WithdrawalCharge", WithdrawalCharge);
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
        * Function deletes Savings Account Type
        * @param Code | The Savings Account Type Code
        * @return bool | return true if Savings Account Type is deleted / return false if not deleted
        */
        public static bool DeleteSavingsAccountType(string Code)
        {
            bool status = false;

            string sql = "DELETE FROM [saccobook].[savingsaccounttypes] WHERE Code = @Code";
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

        /******************************** MEMBER SAVINGS ACCOUNTS ****************************/


        /**
        * Function returns member's Kins list
        * @param MembershipNumber | The member's membership number

        * @return List<Kin> | returns a List of MemberSavingsAccounts
        */
        public static List<MemberSavingsAccounts> GetSavingsAccountsList(string MembershipNumber)
        {
            List<MemberSavingsAccounts> SavingsAccountList = new List<MemberSavingsAccounts>();

            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT AccountNumber, AccountType, AccountName, MembershipNumber, CAST(CreditAmount as decimal(10, 2)) as CreditAmount, CAST(DebitAmount as decimal(10, 2)) as DebitAmount, CAST(Balance as decimal(10, 2)) as Balance, DateCreated, Status, LastModifiedBy, LastModifiedAt FROM [saccobook].[membersavingsaccounts] WHERE  MembershipNumber = '" + MembershipNumber + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    SavingsAccountList.Add(new MemberSavingsAccounts
                    {
                        AccountNumber = dr.GetString(0),
                        AccountType = dr.GetString(1),
                        AccountName = dr.GetString(2),
                        MembershipNumber = dr.GetString(3),
                        CreditAmount = dr.GetDouble(4),
                        DebitAmount = dr.GetDouble(5),
                        Balance = dr.GetDouble(6),
                        DateCreated = dr.GetDateTime(7),
                        Status = dr.GetString(8),
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

            return SavingsAccountList;
        }

        public static string GetMemberSavingsAccountsList(string MembershipNumber)
        {
            string SavingsAccountList = "SELECT AccountNumber, AccountType, AccountName, MembershipNumber, CAST(CreditAmount as decimal(10, 2)) as CreditAmount, CAST(DebitAmount as decimal(10, 2)) as DebitAmount, CAST(Balance as decimal(10, 2)) as Balance, DateCreated, Status, LastModifiedBy, LastModifiedAt FROM [saccobook].[membersavingsaccounts] WHERE  MembershipNumber = '" + MembershipNumber + "'";

            return SavingsAccountList;
        }


        /**
        * Function returns Member savings account information
        * @param Code | The Savings Account Type Code
        * @return string | returns JSON string with member savings account data
        */
        public static string GetMemberSavingsAccountInfo(string AccountNumber)
        {
            string MembershipNumber = "", AccountType = "", AccountName = "", Status = "",  LastModifiedBy = "", LastModifiedAt = "", MemberSavingsAccountsData ="";
            double Balance = 0.00, CreditAmount = 0.00, DebitAmount = 0.00;
            DateTime DateCreated = default(DateTime); 
            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT AccountNumber, AccountType, AccountName, MembershipNumber, CreditAmount, DebitAmount, Balance, DateCreated, Status, LastModifiedBy, LastModifiedAt FROM [saccobook].[membersavingsaccounts] WHERE AccountNumber = '" + AccountNumber + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    AccountNumber = dr.GetString(0);
                    AccountType = dr.GetString(1);
                    AccountName = dr.GetString(2);
                    MembershipNumber = dr.GetString(3);
                    CreditAmount = dr.GetDouble(4);
                    DebitAmount = dr.GetDouble(5);
                    Balance = dr.GetDouble(6);
                    DateCreated = dr.GetDateTime(7);
                    Status = dr.GetString(8);
                    LastModifiedBy = dr.GetString(9);
                    LastModifiedAt = dr.GetString(10);
                }
                conn.Close();

                var _MemberSavingsAccounts = new MemberSavingsAccounts
                {
                    AccountNumber = AccountNumber,
                    MembershipNumber = MembershipNumber,
                    AccountType  = AccountType,
                    AccountName = AccountName,
                    CreditAmount = CreditAmount,
                    DebitAmount = DebitAmount,                    
                    Balance = Balance,
                    DateCreated = DateCreated,
                    Status = Status,
                    LastModifiedBy  = LastModifiedBy,
                    LastModifiedAt = LastModifiedAt
                };
                MemberSavingsAccountsData = JsonConvert.SerializeObject(_MemberSavingsAccounts);
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                System.Diagnostics.EventLogEntryType.Warning);
            }
            return MemberSavingsAccountsData;
        }

        /**
        * Function creates Member Savings Account  
        * @param AccountNumber | The Member Savings Account number
        * @param AccountType | The member savings account type code
        * @param AccountName | The member savings account type name
        * @param MembershipNumber | The member's membership number
        * @param CreditAmount | The savings account credit balance
        * @param DebitAmount | The savings account debit balance
        * @param Balance | The savings account balance
        * @param DateCreated | The date the account was created
        * @param Status | The savings account status
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if Savings Account Type is created / return false if not created
        */
        public static bool CreateMemberSavingsAccount(string AccountNumber, string AccountType, string AccountName, string MembershipNumber, string CreditAmount, string DebitAmount, string Balance, string DateCreated, string Status, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO [saccobook].[membersavingsaccounts](AccountNumber, AccountType, AccountName, MembershipNumber, CreditAmount, DebitAmount, Balance, DateCreated, Status, LastModifiedBy, LastModifiedAt) VALUES (@AccountNumber, @AccountType, @AccountName, @MembershipNumber, @CreditAmount, @DebitAmount, @Balance, @DateCreated, @Status, @LastModifiedBy, @LastModifiedAt)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                    cmd.Parameters.AddWithValue("@AccountType", AccountType);
                    cmd.Parameters.AddWithValue("@AccountName", AccountName);
                    cmd.Parameters.AddWithValue("@MembershipNumber", MembershipNumber);
                    cmd.Parameters.AddWithValue("@CreditAmount", CreditAmount);
                    cmd.Parameters.AddWithValue("@DebitAmount", DebitAmount);
                    cmd.Parameters.AddWithValue("@Balance", Balance);
                    cmd.Parameters.AddWithValue("@DateCreated", DateCreated);
                    cmd.Parameters.AddWithValue("@Status", Status);
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
        * Function updates Member Savings Accounts 
        * @param AccountNumber | The Member Savings Account number
        * @param AccountType | The member savings account type code
        * @param AccountName | The member savings account type name
        * @param MembershipNumber | The member's membership number
        * @param CreditAmount | The savings account credit balance
        * @param DebitAmount | The savings account debit balance
        * @param Balance | The savings account balance
        * @param DateCreated | The date the account was created
        * @param Status | The savings account status
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if Savings Account Type is created / return false if not created
        */
        public static bool UpdateMemberSavingsAccountType(string AccountNumber, string AccountType, string AccountName, string MembershipNumber, string CreditAmount, string DebitAmount, string Balance, string DateCreated, string Status, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE  [saccobook].[membersavingsaccounts]  SET  AccountType =@AccountType, AccountName =@AccountName, MembershipNumber =@MembershipNumber, CreditAmount =@CreditAmount, DebitAmount =@DebitAmount, Balance =@Balance, DateCreated =@DateCreated, Status =@Status, LastModifiedBy =@LastModifiedBy, LastModifiedAt =@LastModifiedAt WHERE  AccountNumber =@AccountNumber";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                    cmd.Parameters.AddWithValue("@AccountType", AccountType);
                    cmd.Parameters.AddWithValue("@AccountName", AccountName);
                    cmd.Parameters.AddWithValue("@MembershipNumber", MembershipNumber);
                    cmd.Parameters.AddWithValue("@CreditAmount", CreditAmount);
                    cmd.Parameters.AddWithValue("@DebitAmount", DebitAmount);
                    cmd.Parameters.AddWithValue("@AccountName", AccountName);
                    cmd.Parameters.AddWithValue("@Balance", Balance);
                    cmd.Parameters.AddWithValue("@DateCreated", DateCreated);
                    cmd.Parameters.AddWithValue("@Status", Status);
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
        * Function deletes Savings Account Type
        * @param Code | The Savings Account Type Code
        * @return bool | return true if Savings Account Type is deleted / return false if not deleted
        */
        public static bool DeleteMemberSavingsAccountType(string MembershipNumber, string AccountType)
        {
            bool status = false;

            string sql = "DELETE FROM [saccobook].[membersavingsaccounts] WHERE WHERE MembershipNumber=@MembershipNumber AND AccountType=@AccountType";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@MembershipNumber", MembershipNumber);
                cmd.Parameters.AddWithValue("@AccountType", AccountType);
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
        public static string LoadSavingsAccountBalances() 
        {
            string sql = "select \"saccobook.membersavingsaccounts\".\"AccountType\", \"saccobook.membersavingsaccounts\".\"AccountName\",\"saccobook.membersavingsaccounts\".\"AccountNumber\",\"saccobook.members\".\"Name\",\"saccobook.members\".\"MembershipNumber\",CAST(\"saccobook.membersavingsaccounts\".\"CreditAmount\" as decimal(10, 2)) as CreditAmount,CAST(\"saccobook.membersavingsaccounts\".\"DebitAmount\" as decimal(10, 2)) as DebitAmount,CAST(\"saccobook.membersavingsaccounts\".\"Balance\" as decimal(10, 2)) as Balance from(\"saccobook\".\"members\" \"saccobook.members\" inner join \"saccobook\".\"membersavingsaccounts\" \"saccobook.membersavingsaccounts\"  on(\"saccobook.membersavingsaccounts\".\"MembershipNumber\" = \"saccobook.members\".\"MembershipNumber\")) order  by \"saccobook.membersavingsaccounts\".\"Balance\" desc";
            return sql;
        }

        /******************************** SAVINGS ****************************/

        /*
        * Function returns Member savings account information
        * @param DocumentNumber | The Savings DocumentNumber
        * @return string | returns JSON string with savings data
        */
        public static string GetSavingInfo(string DocumentNumber)
        {
            string Source = "", SourceAccount ="", Destination = "", DestinationAccount = "",  GLAccount = "", Status = "", MembershipNumber = "", TransactionType = "", Description = "", AccountType = "", ReferenceNo = "", LastModifiedBy = "", LastModifiedAt = "", SavingData = "";
            DateTime TransactionDate = default(DateTime);

            double CreditAmount = 0.00, DebitAmount = 0.00;
            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [saccobook].[membersavings] WHERE DocumentNumber = '" + DocumentNumber + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    DocumentNumber = dr.GetString(0);
                    MembershipNumber = dr.GetString(1);
                    TransactionType = dr.GetString(2);
                    Source = dr.GetString(3);
                    SourceAccount = dr.GetString(4);
                    AccountType = dr.GetString(5);
                    Destination = dr.GetString(6);
                    DestinationAccount = dr.GetString(7);
                    Description = dr.GetString(8);
                    ReferenceNo = dr.GetString(9);
                    TransactionDate = dr.GetDateTime(10);
                    GLAccount = dr.GetString(11);
                    CreditAmount = dr.GetDouble(12);
                    DebitAmount = dr.GetDouble(13);
                    Status = dr.GetString(14);
                    LastModifiedBy = dr.GetString(15);
                    LastModifiedAt = dr.GetString(16);
                 
                }
                conn.Close();

                var _Saving = new Saving
                {
                    DocumentNumber = DocumentNumber,
                    MembershipNumber = MembershipNumber,
                    TransactionType = TransactionType,
                    Source = Source,
                    SourceAccount = SourceAccount,
                    AccountType = AccountType,
                    Destination = Destination,
                    DestinationAccount = DestinationAccount,
                    Description = Description,
                    ReferenceNo = ReferenceNo,
                    TransactionDate = TransactionDate,
                    GLAccount = GLAccount,
                    CreditAmount = CreditAmount,
                    DebitAmount = DebitAmount,
                    Status = Status,
                    LastModifiedBy = LastModifiedBy,
                    LastModifiedAt = LastModifiedAt
                };
                SavingData = JsonConvert.SerializeObject(_Saving);
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                System.Diagnostics.EventLogEntryType.Warning);
            }
            return SavingData;
        }

        /**
        * Function creates Member Savings Account  
        * @param DocumentNumber | The member savings document number(unique)
        * @param MembershipNumber | The member's membership number
        * @param TransactionType | The transaction type
        * @param Description | The transaction description
        * @param CreditAmount | The credit amount
        * @param DebitAmount | The debit amount
        * @param AccountType | The member savings account type
        * @param ReferenceNo | The transaction reference number
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if Savings is created / return false if not created
        */
        public static bool CreateSavingWithdrawal(string DocumentNumber, string MembershipNumber, string TransactionType, string Source, string SourceAccount, string AccountType, string Destination, string DestinationAccount, string Description, string ReferenceNo, string TransactionDate, string GLAccount, double CreditAmount, double DebitAmount, string Status, string CreatedBy, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO [saccobook].[membersavings](DocumentNumber, MembershipNumber, TransactionType, Source, SourceAccount, AccountType, Destination, DestinationAccount, Description, ReferenceNo, TransactionDate, GLAccount, CreditAmount, DebitAmount, Status, CreatedBy, LastModifiedBy, LastModifiedAt) VALUES (@DocumentNumber, @MembershipNumber, @TransactionType, @Source, @SourceAccount, @AccountType, @Destination, @DestinationAccount, @Description, @ReferenceNo, @TransactionDate, @GLAccount, @CreditAmount, @DebitAmount, @Status, @CreatedBy, @LastModifiedBy, @LastModifiedAt)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DocumentNumber", DocumentNumber);
                    cmd.Parameters.AddWithValue("@MembershipNumber", MembershipNumber);
                    cmd.Parameters.AddWithValue("@TransactionType", TransactionType);
                    cmd.Parameters.AddWithValue("@Source", Source);
                    cmd.Parameters.AddWithValue("@SourceAccount", SourceAccount);
                    cmd.Parameters.AddWithValue("@AccountType", AccountType);
                    cmd.Parameters.AddWithValue("@Destination", Destination);
                    cmd.Parameters.AddWithValue("@DestinationAccount", DestinationAccount);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@ReferenceNo", ReferenceNo);
                    cmd.Parameters.AddWithValue("@TransactionDate", TransactionDate);
                    cmd.Parameters.AddWithValue("@GLAccount", GLAccount);
                    cmd.Parameters.AddWithValue("@CreditAmount", CreditAmount);
                    cmd.Parameters.AddWithValue("@DebitAmount", DebitAmount);
                    cmd.Parameters.AddWithValue("@Status", Status);
                    cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
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
        * Function updates Member Savings 
        * @param DocumentNumber | The member savings document number(unique)
        * @param MembershipNumber | The member's membership number
        * @param TransactionType | The transaction type
        * @param Description | The transaction description
        * @param CreditAmount | The credit amount
        * @param DebitAmount | The debit amount
        * @param AccountType | The member savings account type
        * @param ReferenceNo | The transaction reference number
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if Savings is updated / return false if not updated
        */
        public static bool UpdateSavingWithdrawal(string DocumentNumber, string MembershipNumber, string TransactionType, string Source, string SourceAccount, string AccountType, string Destination, string DestinationAccount, string Description, string ReferenceNo, string TransactionDate, string GLAccount, string CreditAmount, string DebitAmount, string Status, string CreatedBy, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[membersavings] SET MembershipNumber=@MembershipNumber,TransactionType=@TransactionType,Source=@Source,SourceAccount=@SourceAccount,AccountType=@AccountType,DestinationAccount=@DestinationAccount,Description=@Description,ReferenceNo=@ReferenceNo,TransactionDate=@TransactionDate,GLAccount=@GLAccount,CreditAmount=@CreditAmount,DebitAmount=@DebitAmount,Status=@Status,LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt WHERE DocumentNumber=@DocumentNumber";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DocumentNumber", DocumentNumber);
                    cmd.Parameters.AddWithValue("@MembershipNumber", MembershipNumber);
                    cmd.Parameters.AddWithValue("@TransactionType", TransactionType);
                    cmd.Parameters.AddWithValue("@Source", Source);
                    cmd.Parameters.AddWithValue("@SourceAccount", SourceAccount);
                    cmd.Parameters.AddWithValue("@AccountType", AccountType);
                    cmd.Parameters.AddWithValue("@DestinationAccount", DestinationAccount);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@ReferenceNo", ReferenceNo);
                    cmd.Parameters.AddWithValue("@TransactionDate", TransactionDate);
                    cmd.Parameters.AddWithValue("@GLAccount", GLAccount);
                    cmd.Parameters.AddWithValue("@CreditAmount", CreditAmount);
                    cmd.Parameters.AddWithValue("@DebitAmount", DebitAmount);
                    cmd.Parameters.AddWithValue("@Status", Status);
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
        * Function deletes Savings
        * @param Code | Savings Document Number Code
        * @return bool | return true if Savings is deleted / return false if not deleted
        */
        public static bool DeleteSaving(string DocumentNumber)
        {
            bool status = false;

            string sql = "DELETE FROM [saccobook].[membersavings] WHERE WHERE DocumentNumber=@DocumentNumber";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@DocumentNumber", DocumentNumber);
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

        public static double GetSavingsAccountBalance(string AccountNumber, string BalanceValue)
        {          
            double balance = 0.00;

            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT "+ BalanceValue + " FROM [saccobook].[membersavingsaccounts] WHERE AccountNumber= '" + AccountNumber + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    balance = dr.GetDouble(0);
                }
                conn.Close();
                
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                 System.Diagnostics.EventLogEntryType.Warning);
            }
            return balance;
        }

        public static bool UpdateSavingsAccountBalance(string AccountNumber, string Column, string Value, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[membersavingsaccounts] SET " + Column + "=@Value,LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt WHERE AccountNumber=@AccountNumber";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);                    
                    cmd.Parameters.AddWithValue("@Value", Value);
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
        public static bool CommitSavings(string AccountNumber, double DepositAmount)
        {
            bool status = false;

            double TotalCreditAmount = GetSavingsAccountBalance(AccountNumber, "CreditAmount");

            TotalCreditAmount = TotalCreditAmount + DepositAmount;

            double TotalDebitAmount = GetSavingsAccountBalance(AccountNumber, "DebitAmount");

            double Balance = TotalCreditAmount - TotalDebitAmount;

            //Update Credit Amount

            if (UpdateSavingsAccountBalance(AccountNumber, "CreditAmount", TotalCreditAmount.ToString(), Login.LoggedInUser, DateTime.Now.ToString()))
            {
                //Update Balance

                if (UpdateSavingsAccountBalance(AccountNumber, "Balance", Balance.ToString(), Login.LoggedInUser, DateTime.Now.ToString()))
                {
                    status = true;
                }

            }

            return status;
        }
        public static bool CommitWithdrawals(string SourceAccount, double WithdrawalAmount)
        {
            bool status = false;

            double TotalDebitAmount = GetSavingsAccountBalance(SourceAccount, "DebitAmount");

            TotalDebitAmount = TotalDebitAmount + WithdrawalAmount;

            double TotalCreditAmount = GetSavingsAccountBalance(SourceAccount, "CreditAmount");

            double Balance = TotalCreditAmount - TotalDebitAmount;

            //Update Debit Amount
            if (UpdateSavingsAccountBalance(SourceAccount, "DebitAmount", TotalDebitAmount.ToString(), Login.LoggedInUser, DateTime.Now.ToString()))
            {
                //Update Balance

                if (UpdateSavingsAccountBalance(SourceAccount, "Balance", Balance.ToString(), Login.LoggedInUser, DateTime.Now.ToString()))
                {
                    status = true;
                }

            }

            return status;
        }

        /*********************************** MAKE SAVINGS ***********************************************/
        public static void LoadMembersActiveAccounts(DevExpress.XtraEditors.SearchLookUpEdit _SearchLookUpEdit, string MembershipNumber)
        {
            string sql = "select \"saccobook.membersavingsaccounts\".\"AccountNumber\",\"saccobook.membersavingsaccounts\".\"AccountName\",\"saccobook.membersavingsaccounts\".\"Balance\" from(\"saccobook\".\"membersavingsaccounts\" \"saccobook.membersavingsaccounts\" inner join \"saccobook\".\"members\" \"saccobook.members\" on(\"saccobook.members\".\"MembershipNumber\" = \"saccobook.membersavingsaccounts\".\"MembershipNumber\")) where ((\"saccobook.membersavingsaccounts\".\"Status\" = 'Active') and(\"saccobook.members\".\"MembershipNumber\" = '"+ MembershipNumber + "'))";
            AppResources.AppFunctions.LoadSearchLookUpEdit(_SearchLookUpEdit, sql);
        }

        public static string LoadOpenSavingsRecords(string status, string TransactionType)
        {
            string sql = "select \"saccobook.members\".\"Name\",\"saccobook.membersavings\".\"MembershipNumber\",\"saccobook.membersavings\".\"TransactionType\", \"saccobook.membersavings\".\"Source\",\"saccobook.membersavings\".\"SourceAccount\",\"saccobook.membersavings\".\"AccountType\",\"saccobook.membersavings\".\"Destination\", \"saccobook.membersavings\".\"DestinationAccount\",\"saccobook.membersavings\".\"TransactionDate\",CAST(\"saccobook.membersavings\".\"CreditAmount\" as decimal(10,2)) as CreditAmount,CAST(\"saccobook.membersavings\".\"DebitAmount\" as decimal(10,2)) as DebitAmount,\"saccobook.membersavings\".\"Status\" from(\"saccobook\".\"membersavings\" \"saccobook.membersavings\" inner join \"saccobook\".\"members\" \"saccobook.members\" on(\"saccobook.members\".\"MembershipNumber\" = \"saccobook.membersavings\".\"MembershipNumber\")) where ((\"saccobook.membersavings\".\"Status\" = '" + status + "') and(\"saccobook.membersavings\".\"CreatedBy\" = '" + Login.LoggedInUser + "') and (\"saccobook.membersavings\".\"TransactionType\" ='"+TransactionType+"' )) order by \"saccobook.membersavings\".\"TransactionType\" desc";

            return sql;
        }
        public static string LoadOpenSavingsWithdrawalsRecords(string status, string TransactionType)
        {
            string sql = "select \"saccobook.members\".\"Name\",\"saccobook.membersavings\".\"MembershipNumber\",\"saccobook.membersavings\".\"DocumentNumber\",\"saccobook.membersavings\".\"TransactionType\", \"saccobook.membersavings\".\"Source\",\"saccobook.membersavings\".\"SourceAccount\",\"saccobook.membersavings\".\"AccountType\",\"saccobook.membersavings\".\"Destination\", \"saccobook.membersavings\".\"DestinationAccount\",\"saccobook.membersavings\".\"TransactionDate\",\"saccobook.membersavings\".\"CreditAmount\",\"saccobook.membersavings\".\"DebitAmount\",\"saccobook.membersavings\".\"Status\" from(\"saccobook\".\"membersavings\" \"saccobook.membersavings\" inner join \"saccobook\".\"members\" \"saccobook.members\" on(\"saccobook.members\".\"MembershipNumber\" = \"saccobook.membersavings\".\"MembershipNumber\")) where ((\"saccobook.membersavings\".\"Status\" = '" + status + "') and(\"saccobook.membersavings\".\"CreatedBy\" = '" + Login.LoggedInUser + "') and (\"saccobook.membersavings\".\"TransactionType\" ='" + TransactionType + "' )) order by \"saccobook.membersavings\".\"TransactionType\" desc";

            return sql;
        }
        public static string LoadDashSavingsWithdrawalsRecords(string status)
        {
            string sql = "select \"saccobook.members\".\"Name\",\"saccobook.membersavings\".\"MembershipNumber\",\"saccobook.membersavings\".\"DocumentNumber\",\"saccobook.membersavings\".\"TransactionType\", \"saccobook.membersavings\".\"AccountType\",\"saccobook.membersavings\".\"Destination\", \"saccobook.membersavings\".\"DestinationAccount\",\"saccobook.membersavings\".\"TransactionDate\",\"saccobook.membersavings\".\"CreditAmount\",\"saccobook.membersavings\".\"DebitAmount\",\"saccobook.membersavings\".\"Status\" from(\"saccobook\".\"membersavings\" \"saccobook.membersavings\" inner join \"saccobook\".\"members\" \"saccobook.members\" on(\"saccobook.members\".\"MembershipNumber\" = \"saccobook.membersavings\".\"MembershipNumber\")) where ((\"saccobook.membersavings\".\"Status\" = '" + status+"') and(\"saccobook.membersavings\".\"CreatedBy\" = '"+Login.LoggedInUser+"')) order by \"saccobook.membersavings\".\"TransactionType\" desc";

            return sql;
        }

        //savings statements

        public static string SavingsStatementList(string AccountNumber)
        {
            string sql = "SELECT [DocumentNumber]  ,[TransactionType] ,[TransactionDate] ,[TransactionAmount] ,[LastModifiedAt] FROM[Sacco Book].[saccobook].[membersavings] where DestinationAccount = '"+ AccountNumber + "' order by TransactionDate desc";
            return sql;
        }
    }
}
