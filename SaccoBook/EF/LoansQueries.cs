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

namespace SaccoBook.EF
{
    class LoansQueries
    {
        static string connectionstring = AppResources.DatabaseConnection.ConnectionString();
        /*******************************************Credit Product *******************************************/
        public static void LoadLoanProducts(DevExpress.XtraEditors.SearchLookUpEdit _SearchLookUpEdit)
        {
            string sql = "select \"saccobook.loanprocucttypes\".\"Code\", \"saccobook.loanprocucttypes\".\"Name\", \"saccobook.loanprocucttypes\".\"InterestRate\", \"saccobook.loanprocucttypes\".\"InterestCalculationType\",\"saccobook.loanprocucttypes\".\"MaximumLoanAmount\",\"saccobook.loanprocucttypes\".\"MaxRepaymentPeriodInMonths\", \"saccobook.loanprocucttypes\".\"MinimumDepositContribution\" from \"saccobook\".\"loanprocucttypes\" \"saccobook.loanprocucttypes\"";
            AppResources.AppFunctions.LoadSearchLookUpEdit(_SearchLookUpEdit, sql);
        }
        public static string GetLoanProducts()
        {
            string sql = @"SELECT [Code]
                              ,[Name]
                              ,[Description]
                              ,[InterestRate]
                              ,[RequiresMakerChecker]
                              ,[InterestCalculationType]
                              ,[MaximumLoanAmount]
                              ,[MaxRepaymentPeriodInMonths]
                              ,[MinimumDepositContribution]
                              ,[LastModifiedBy]
                              ,[LastModifiedAt]
                          FROM [saccobook].[loanprocucttypes]";
            return sql;
        }

        /**
        * Function creates new loan product
               
        * @param Code | The loan product code
        * @param Name | The loan product's name
        * @param Description | The loan description
        * @param InterestRate | The loan interest
        * @param RequiresMakerChecker | Whether the loans require a maker checker approval
        * @param InterestCalculationType | The loan interest calculation type
        * @param MaximumLoanAmount | The maximum loan amount a member can be awarded
        * @param MaxRepaymentPeriodInMonths | The maximum period in months a member can stay with the loan
        * @param MinimumDepositContribution | The minimum amount in member's savings account
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if loan product is created / return false if not created
        */
        public static bool CreateLoanProduct(string Code, string Name, string Description, double InterestRate, bool RequiresMakerChecker, string InterestCalculationType, double MaximumLoanAmount, string MaxRepaymentPeriodInMonths, double MinimumDepositContribution, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO [saccobook].[loanprocucttypes](Code, Name, Description, InterestRate, RequiresMakerChecker, InterestCalculationType, MaximumLoanAmount, MaxRepaymentPeriodInMonths, MinimumDepositContribution, LastModifiedBy, LastModifiedAt) VALUES (@Code, @Name, @Description, @InterestRate, @RequiresMakerChecker, @InterestCalculationType, @MaximumLoanAmount, @MaxRepaymentPeriodInMonths, @MinimumDepositContribution, @LastModifiedBy, @LastModifiedAt)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Code", Code);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@InterestRate", InterestRate);
                    cmd.Parameters.AddWithValue("@RequiresMakerChecker", RequiresMakerChecker);
                    cmd.Parameters.AddWithValue("@InterestCalculationType", InterestCalculationType);
                    cmd.Parameters.AddWithValue("@MaximumLoanAmount", MaximumLoanAmount);
                    cmd.Parameters.AddWithValue("@MaxRepaymentPeriodInMonths", MaxRepaymentPeriodInMonths);
                    cmd.Parameters.AddWithValue("@MinimumDepositContribution", MinimumDepositContribution);
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
        * Function updates loan product
               
        * @param Code | The loan product code
        * @param Name | The loan product's name
        * @param Description | The loan description
        * @param InterestRate | The loan interest
        * @param RequiresMakerChecker | Whether the loans require a maker checker approval
        * @param InterestCalculationType | The loan interest calculation type
        * @param MaximumLoanAmount | The maximum loan amount a member can be awarded
        * @param MaxRepaymentPeriodInMonths | The maximum period in months a member can stay with the loan
        * @param MinimumDepositContribution | The minimum amount in member's savings account
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if loan product is updated / return false if not updated
        */  
        public static bool UpdateLoanProduct(string Code, string Name, string Description, double InterestRate, bool RequiresMakerChecker, string InterestCalculationType, double MaximumLoanAmount, string MaxRepaymentPeriodInMonths, double MinimumDepositContribution, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[loanprocucttypes] SET Name=@Name,Description=@Description,InterestRate=@InterestRate,RequiresMakerChecker=@RequiresMakerChecker,InterestCalculationType=@InterestCalculationType,MaximumLoanAmount=@MaximumLoanAmount,MaxRepaymentPeriodInMonths=@MaxRepaymentPeriodInMonths,MinimumDepositContribution=@MinimumDepositContribution,LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt WHERE Code=@Code";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Code", Code);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@InterestRate", InterestRate);
                    cmd.Parameters.AddWithValue("@RequiresMakerChecker", RequiresMakerChecker);
                    cmd.Parameters.AddWithValue("@InterestCalculationType", InterestCalculationType);
                    cmd.Parameters.AddWithValue("@MaximumLoanAmount", MaximumLoanAmount);
                    cmd.Parameters.AddWithValue("@MaxRepaymentPeriodInMonths", MaxRepaymentPeriodInMonths);
                    cmd.Parameters.AddWithValue("@MinimumDepositContribution", MinimumDepositContribution);
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
        * Function deletes loan product 
        * 
        * @param Code | The loan product code
        * @return bool | return true if loan product is deleted / return false if not deleted
        */
        public static bool DeleteLoanProduct(string Code)
        {
            bool status = false;

            string sql = "DELETE FROM [saccobook].[loanprocucttypes] WHERE Code = @Code";
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
        * Function returns Credit Product Information
        * 
        * @param Code | The Credit Product code
        * 
        * @return string | returns JSON string with Credit Product Information
        */
        public static string GetCreditProductInfo(string Code)
        {
            string Name = "",   InterestCalculationType = "",  Description = "", LastModifiedBy = "", LastModifiedAt = "", CreditProductData = "";
            bool RequiresMakerChecker = false;
            double InterestRate = 0, MaximumLoanAmount = 0, MaxRepaymentPeriodInMonths = 0, MinimumDepositContribution = 0;

            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [saccobook].[loanprocucttypes] WHERE Code = '" + Code + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Code = dr.GetString(0);
                    Name = dr.GetString(1);
                    Description = dr.GetString(2);
                    InterestRate = Convert.ToDouble(dr["InterestRate"].ToString());
                    InterestCalculationType = dr.GetString(5);
                    MaximumLoanAmount = Convert.ToDouble(dr["MaximumLoanAmount"].ToString());
                    MaxRepaymentPeriodInMonths = Convert.ToDouble(dr["MaxRepaymentPeriodInMonths"].ToString());
                    MinimumDepositContribution = Convert.ToDouble(dr["MinimumDepositContribution"].ToString());
                    LastModifiedBy = dr.GetString(9);
                    LastModifiedAt = dr.GetString(10);
                }
                conn.Close();

                var _MemberBankAccount = new CreditProduct
                {
                   Code = Code,
                   Name = Name,
                   Description = Description,
                   InterestCalculationType = InterestCalculationType,
                   RequiresMakerChecker = RequiresMakerChecker,
                   InterestRate = InterestRate,
                   MaximumLoanAmount = MaximumLoanAmount,
                   MaxRepaymentPeriodInMonths = MaxRepaymentPeriodInMonths,
                   MinimumDepositContribution = MinimumDepositContribution,
                   LastModifiedBy = LastModifiedBy,
                   LastModifiedAt = LastModifiedAt
                };
                CreditProductData = JsonConvert.SerializeObject(_MemberBankAccount);
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                  System.Diagnostics.EventLogEntryType.Warning);
            }
            return CreditProductData;
        }

        /******************************************* Loan  *******************************************/

        /**
        * Function creates new loan record
               
        * @param DocumentNumber | The loan record document number
        * @param MembershipNumber | The loan beneficiary membership number
        * @param LoanType | The loan type
        * @param LoanAwardDate | The loan award date
        * @param LoanRepaymentDeadlineDate | The loan repayment deadline date
        * @param InterestRate | The loan interest are
        * @param InterestCalculationType | The loan interest calculation type
        * @param LoanAmount | The amount awarded
        * @param RepaymentPeriodInMonths | The loan repayment period in months
        * @param Description | The optional description for the loan
        * @param Status | The loan record status
        * @param CreatedBy | Creator of the document
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if loan record is created / return false if not created
        */
        public static bool CreateLoanRecord(string DocumentNumber, string MembershipNumber, string LoanType, string LoanAwardDate, string LoanRepaymentDeadlineDate, string InterestRate, string InterestCalculationType, string LoanAmount, string RepaymentPeriodInMonths, string Description, string Status, string CreatedBy, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO [saccobook].[memberloans](DocumentNumber, MembershipNumber, LoanType, LoanAwardDate, LoanRepaymentDeadlineDate, InterestRate, InterestCalculationType, LoanAmount, RepaymentPeriodInMonths, Description, Balance, Status, CreatedBy, LastModifiedBy, LastModifiedAt) VALUES (@DocumentNumber, @MembershipNumber, @LoanType, @LoanAwardDate, @LoanRepaymentDeadlineDate, @InterestRate, @InterestCalculationType, @LoanAmount, @RepaymentPeriodInMonths, @Description, @Balance, @Status, @CreatedBy, @LastModifiedBy, @LastModifiedAt)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DocumentNumber", DocumentNumber);
                    cmd.Parameters.AddWithValue("@MembershipNumber", MembershipNumber);
                    cmd.Parameters.AddWithValue("@LoanType", LoanType);
                    cmd.Parameters.AddWithValue("@LoanAwardDate", LoanAwardDate);
                    cmd.Parameters.AddWithValue("@LoanRepaymentDeadlineDate", LoanRepaymentDeadlineDate);
                    cmd.Parameters.AddWithValue("@InterestRate", InterestRate); 
                    cmd.Parameters.AddWithValue("@InterestCalculationType", InterestCalculationType); 
                    cmd.Parameters.AddWithValue("@LoanAmount", LoanAmount);
                    cmd.Parameters.AddWithValue("@RepaymentPeriodInMonths", RepaymentPeriodInMonths);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@Balance", "0.0");
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
        * Function updates new loan record
               
        * @param DocumentNumber | The loan record document number
        * @param MembershipNumber | The loan beneficiary membership number
        * @param LoanType | The loan type
        * @param LoanAwardDate | The loan award date
        * @param LoanRepaymentDeadlineDate | The loan repayment deadline date
        * @param InterestRate | The loan interest are
        * @param InterestCalculationType | The loan interest calculation type
        * @param LoanAmount | The amount awarded
        * @param RepaymentPeriodInMonths | The loan repayment period in months
        * @param Description | The optional description for the loan
        * @param Status | The loan record status
        * @param LastModifiedBy | The user that last modified the record
        * @param LastModifiedAt | The time the record was last modified

        * @return bool | return true if loan record is updated / return false if not updated
        */
        public static bool UpdateLoanRecord(string DocumentNumber, string MembershipNumber, string LoanType, string LoanAwardDate, string LoanRepaymentDeadlineDate, string InterestRate, string InterestCalculationType, string LoanAmount, string RepaymentPeriodInMonths, string Description, string Status, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[memberloans] SET MembershipNumber=@MembershipNumber,LoanType=@LoanType,LoanAwardDate=@LoanAwardDate,LoanRepaymentDeadlineDate=@LoanRepaymentDeadlineDate,InterestRate=@InterestRate,InterestCalculationType=@InterestCalculationType,LoanAmount=@LoanAmount,RepaymentPeriodInMonths=@RepaymentPeriodInMonths,Description=@Description,Status=@Status,LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt WHERE DocumentNumber=@DocumentNumber AND MembershipNumber=@MembershipNumber";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DocumentNumber", DocumentNumber);
                    cmd.Parameters.AddWithValue("@MembershipNumber", MembershipNumber);
                    cmd.Parameters.AddWithValue("@LoanType", LoanType);
                    cmd.Parameters.AddWithValue("@LoanAwardDate", LoanAwardDate);
                    cmd.Parameters.AddWithValue("@LoanRepaymentDeadlineDate", LoanRepaymentDeadlineDate);
                    cmd.Parameters.AddWithValue("@InterestRate", InterestRate);
                    cmd.Parameters.AddWithValue("@InterestCalculationType", InterestCalculationType);
                    cmd.Parameters.AddWithValue("@LoanAmount", LoanAmount);
                    cmd.Parameters.AddWithValue("@RepaymentPeriodInMonths", RepaymentPeriodInMonths);
                    cmd.Parameters.AddWithValue("@Description", Description);
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
        * Function deletes loan record 
        * 
        * @param DocumentNumber | The loan document number
        * @return bool | return true if loan product is deleted / return false if not deleted
        */
        public static bool DeleteLoanRecord(string DocumentNumber)
        {
            bool status = false;

            string sql = "DELETE FROM [saccobook].[memberloans] WHERE DocumentNumber = @DocumentNumber";
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

        /*
        * Function returns SQL string for fetching loans of a specified status
        * 
        * @param status | The loan document's Approval status
        * 
        * @return string | returns SQL string for fetching loan documents of the specified status
        */

        public static string LoadLoanDisbursementEntries(string status)
        {
            string sql = "select \"saccobook.members\".\"Name\",\"saccobook.loanprocucttypes\".\"Name\" as \"Loan Type\",\"saccobook.memberloans\".\"LoanAwardDate\",\"saccobook.memberloans\".\"LoanRepaymentDeadlineDate\",\"saccobook.memberloans\".\"InterestRate\",\"saccobook.memberloans\".\"InterestCalculationType\",CAST(\"saccobook.memberloans\".\"LoanAmount\" as decimal(10, 2)) as LoanAmount,\"saccobook.memberloans\".\"RepaymentPeriodInMonths\",\"saccobook.memberloans\".\"Status\" from((\"saccobook\".\"memberloans\" \"saccobook.memberloans\" inner join \"saccobook\".\"members\" \"saccobook.members\"  on(\"saccobook.members\".\"MembershipNumber\" = \"saccobook.memberloans\".\"MembershipNumber\")) inner join \"saccobook\".\"loanprocucttypes\" \"saccobook.loanprocucttypes\" on(\"saccobook.loanprocucttypes\".\"Code\" = \"saccobook.memberloans\".\"LoanType\")) where ((\"saccobook.memberloans\".\"Status\" = '" + status+"') and(\"saccobook.memberloans\".\"CreatedBy\" = '"+Login.LoggedInUser+"'))";

            return sql;
        }

        /*
       * Function returns SQL string for fetching loan repayments of a specified status
       * 
       * @param status | The loan document's Approval status
       * 
       * @return string | returns SQL string for fetching loan documents of the specified status
       */

        public static string LoadLoanRepaymentEntries(string status)
        {
            string sql = @"select DocumentNumber, LoanId, Date, PaidBy, Source, SourceAccountNumber, PayingAccountNumber, BankReference, Narration, CAST(InstallmentAmount as decimal(10, 2)) as InstallmentAmount, CAST(InterestAmount as decimal(10, 2)) as InterestAmount, Status 
                            from [saccobook].[memberloanrepayments]                          
                           where CreatedBy = '" + Login.LoggedInUser + "' and Status = '" + status + "'";

            return sql;
        }
        /*
        * Function returns SQL string for fetching active loans
        * 
        * @return string | returns SQL string for fetching active loans
        */
        public static string LoadActiveLoans()
        {
            string sql = "select \"saccobook.memberloans\".\"DocumentNumber\",\"saccobook.memberloans\".\"MembershipNumber\",\"saccobook.members\".\"Name\", \"saccobook.memberloans\".\"LoanType\", \"saccobook.memberloans\".\"LoanAwardDate\", CAST(\"saccobook.memberloans\".\"LoanAmount\" as decimal(10, 2)) as LoanAmount, \"saccobook.memberloans\".\"RepaymentPeriodInMonths\",\"saccobook.memberloans\".\"LoanRepaymentDeadlineDate\", CAST(\"saccobook.memberloans\".\"Balance\" as decimal(10, 2)) as Balance from(\"saccobook\".\"memberloans\" \"saccobook.memberloans\" inner join \"saccobook\".\"members\"   \"saccobook.members\" on(\"saccobook.members\".\"MembershipNumber\" = \"saccobook.memberloans\".\"MembershipNumber\"))   where((\"saccobook.memberloans\".\"Balance\" > 0.0)) order by \"saccobook.memberloans\".\"DocumentNumber\" desc";

            return sql;
        }
        /*
        * Function returns SQL string for fetching defaulted loans
        * 
        * @return string | returns SQL string for fetching defaulted loans
        */
        public static string LoadDefaultedLoans()
        {
            string sql = "select \"saccobook.memberloans\".\"DocumentNumber\",\"saccobook.memberloans\".\"MembershipNumber\",\"saccobook.members\".\"Name\", \"saccobook.memberloans\".\"LoanType\", \"saccobook.memberloans\".\"LoanAwardDate\",CAST(\"saccobook.memberloans\".\"LoanAmount\" as decimal(10, 2)) as LoanAmount, \"saccobook.memberloans\".\"RepaymentPeriodInMonths\",\"saccobook.memberloans\".\"LoanRepaymentDeadlineDate\", CAST(\"saccobook.memberloans\".\"Balance\" as decimal(10, 2)) as Balance from(\"saccobook\".\"memberloans\" \"saccobook.memberloans\" inner join \"saccobook\".\"members\"   \"saccobook.members\" on(\"saccobook.members\".\"MembershipNumber\" = \"saccobook.memberloans\".\"MembershipNumber\"))   where((\"saccobook.memberloans\".\"Balance\" > 0.0)  and(\"saccobook.memberloans\".\"LoanRepaymentDeadlineDate\" < '" + DateTime.Now.ToString("yyyy-MM-d") + "')) order by \"saccobook.memberloans\".\"DocumentNumber\" desc"; //

            return sql;
        }
        /*
        * Function  SQL string for fetching settled loans
        * 
        * @return string | returns SQL string for fetching settled loans
        */
        public static string LoadSettledLoans()
        {
            string sql = "select \"saccobook.memberloans\".\"DocumentNumber\",\"saccobook.memberloans\".\"MembershipNumber\",\"saccobook.members\".\"Name\", \"saccobook.memberloans\".\"LoanType\", \"saccobook.memberloans\".\"LoanAwardDate\", CAST(\"saccobook.memberloans\".\"LoanAmount\" as decimal(10, 2)) as LoanAmount, \"saccobook.memberloans\".\"RepaymentPeriodInMonths\",\"saccobook.memberloans\".\"LoanRepaymentDeadlineDate\", CAST(\"saccobook.memberloans\".\"Balance\" as decimal(10, 2)) as Balance from(\"saccobook\".\"memberloans\" \"saccobook.memberloans\" inner join \"saccobook\".\"members\"   \"saccobook.members\" on(\"saccobook.members\".\"MembershipNumber\" = \"saccobook.memberloans\".\"MembershipNumber\"))   where((\"saccobook.memberloans\".\"Balance\" = 0.0)) order by \"saccobook.memberloans\".\"DocumentNumber\" desc";

            return sql;
        }
        /*
        * Function  SQL string for fetching unssettled loans
        * 
        * @return string | returns SQL string for fetching settled loans
        */
       

        /**
        * Function  lists of members Active Loans on search control 
        * @param _SearchLookUpEdit | SearchLookUpEdit control to be loaded
        * @param MembershipNumber | Specified member
        */
        public static void LoadMembersActiveLoans(DevExpress.XtraEditors.SearchLookUpEdit _SearchLookUpEdit, string MembershipNumber)
        {
            string sql = @"SELECT DocumentNumber, LoanType, LoanAwardDate, InterestCalculationType, Balance FROM [saccobook].[memberloans] WHERE MembershipNumber = '" + MembershipNumber + "' AND Status = 'Approved' AND Balance > 0.0";

            AppResources.AppFunctions.LoadSearchLookUpEdit(_SearchLookUpEdit, sql);
        }
        /**
        * Function returns Loan Information
        * @param _DocumentNumber | The loan's DocumentNumber
        * @return string | returns JSON string with loan Information
        */
        public static string GetLoanInfo(string _DocumentNumber)
        {
            string LoanData = "", DocumentNumber = "", MembershipNumber = "", LoanType = ""; 

            DateTime LoanAwardDate = default(DateTime), LoanRepaymentDeadlineDate = default(DateTime);
            string Status =""; double InterestRate = 0;
            string InterestCalculationType = ""; double LoanAmount = 0, RepaymentPeriodInMonths = 0, Balance = 0; string Description = ""; 

            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [saccobook].[memberloans] WHERE DocumentNumber = '" + _DocumentNumber + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    DocumentNumber = dr.GetString(0);
                    MembershipNumber = dr.GetString(1);
                    LoanType = dr.GetString(2);
                    LoanAwardDate = dr.GetDateTime(3);
                    LoanRepaymentDeadlineDate = dr.GetDateTime(4);
                    InterestRate = dr.GetDouble(5);
                    InterestCalculationType = dr.GetString(6);
                    LoanAmount = dr.GetDouble(7);
                    RepaymentPeriodInMonths = dr.GetDouble(8);
                    Description = dr.GetString(9);
                    Balance = dr.GetDouble(10);
                    Status = dr.GetString(11);
                }
                conn.Close();

                var _Loan = new Loan 
                {
                    DocumentNumber = DocumentNumber,
                    MembershipNumber = MembershipNumber,
                    LoanType = LoanType,
                    Description = Description,
                    InterestRate = InterestRate,
                    LoanAmount = LoanAmount,
                    LoanAwardDate = LoanAwardDate,
                    LoanRepaymentDeadlineDate = LoanRepaymentDeadlineDate,
                    RepaymentPeriodInMonths = RepaymentPeriodInMonths,
                    Balance = Balance,
                    InterestCalculationType = InterestCalculationType,
                    Status = Status

                };
                LoanData = JsonConvert.SerializeObject(_Loan);
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                   System.Diagnostics.EventLogEntryType.Warning);
            }
            return LoanData;
        }
        public static bool CommitLoanRepayment(string LoanRepaymentDocumentNumber, string LoanDocumentNumber, double InstallmentAmount)
        {
            bool status = false;

            string Loan = GetLoanInfo(LoanDocumentNumber);
            dynamic jsonLoan = JObject.Parse(Loan);
            double Balance = 0;
            Balance = jsonLoan.Balance;

            //get current LoanBalance
            double CurrentLoanBalance = Balance;
            //Deduct 
            double NewLoanBalance = CurrentLoanBalance - InstallmentAmount;

            if (UpdateLoanRepayment(LoanRepaymentDocumentNumber, "Balance", NewLoanBalance.ToString(), Login.LoggedInUser, DateTime.Now.ToString()))
            {
                //update loan balance
                if (UpdateLoanBalance(LoanDocumentNumber, "Balance", NewLoanBalance.ToString(), Login.LoggedInUser, DateTime.Now.ToString()))
                {
                    status = true;
                }
            }

            return status;
        }
        public static bool UpdateLoanRepayment(string DocumentNumber, string Column, string Value, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[memberloanrepayments] SET " + Column + "=@Value,LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt WHERE DocumentNumber=@DocumentNumber";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DocumentNumber", DocumentNumber);
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

        public static bool CommitLoan(string DocumentNumber, double Balance)
        {
            bool status = false;

            if (UpdateLoanBalance(DocumentNumber, "Balance", Balance.ToString(), Login.LoggedInUser, DateTime.Now.ToString()))
            {
                status = true;
            }

            return status;
        }
        public static bool UpdateLoanBalance(string DocumentNumber, string Column, string Value, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[memberloans] SET " + Column + "=@Value,LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt WHERE DocumentNumber=@DocumentNumber";
                
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DocumentNumber", DocumentNumber);
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

        /******************************************************* LOAN REPAYMENT *******************************************************/

        /**
        * Function creates new loan product
               
        * @param DocumentNumber | The repayment record documemnt number
        * @param LoanId | The ID of the loan being repaid
        * @param Date | The Date the loan is being repaid
        * 

        * @return bool | return true if loan repayment is created / return false if not created
        */
        public static bool CreateRepayment(string DocumentNumber, string LoanId, string Date, string PaidBy, string Source, string SourceAccountNumber, string PayingAccountNumber, string BankReference, string Narration, string InstallmentAmount, string InterestAmount, string Status, string CreatedBy, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;

            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();
                string sql = "INSERT INTO [saccobook].[memberloanrepayments](DocumentNumber, LoanId, Date, PaidBy, Source, SourceAccountNumber, PayingAccountNumber, BankReference, Narration, InstallmentAmount, InterestAmount, Balance, Status, CreatedBy, LastModifiedBy, LastModifiedAt) VALUES (@DocumentNumber, @LoanId, @Date, @PaidBy, @Source, @SourceAccountNumber, @PayingAccountNumber, @BankReference, @Narration, @InstallmentAmount, @InterestAmount, @Balance, @Status, @CreatedBy, @LastModifiedBy, @LastModifiedAt)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DocumentNumber", DocumentNumber);
                    cmd.Parameters.AddWithValue("@LoanId", LoanId);
                    cmd.Parameters.AddWithValue("@Date", Date);
                    cmd.Parameters.AddWithValue("@PaidBy", PaidBy);
                    cmd.Parameters.AddWithValue("@Source", Source);
                    cmd.Parameters.AddWithValue("@SourceAccountNumber", SourceAccountNumber);
                    cmd.Parameters.AddWithValue("@PayingAccountNumber", PayingAccountNumber);
                    cmd.Parameters.AddWithValue("@BankReference", BankReference);
                    cmd.Parameters.AddWithValue("@Narration", Narration);
                    cmd.Parameters.AddWithValue("@InstallmentAmount", InstallmentAmount);
                    cmd.Parameters.AddWithValue("@InterestAmount", InterestAmount);
                    cmd.Parameters.AddWithValue("@Balance", 0); 
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
            catch(SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                    System.Diagnostics.EventLogEntryType.Warning);
            }

            return status;
        }
        public static bool UpdateRepayment(string DocumentNumber, string LoanId, string Date, string PaidBy, string Source, string SourceAccountNumber, string PayingAccountNumber, string BankReference, string Narration, string InstallmentAmount, string InterestAmount, string Status, string CreatedBy, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;

            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();
                string sql = "UPDATE [saccobook].[memberloanrepayments] SET LoanId=@LoanId,Date=@Date,PaidBy=@PaidBy,Source=@Source,SourceAccountNumber=@SourceAccountNumber,PayingAccountNumber=@PayingAccountNumber,BankReference=@BankReference,Narration=@Narration,InstallmentAmount=@InstallmentAmount,InterestAmount=@InterestAmount,Status=@Status, CreatedBy=@CreatedBy, LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt WHERE DocumentNumber=@DocumentNumber";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DocumentNumber", DocumentNumber);
                    cmd.Parameters.AddWithValue("@LoanId", LoanId);
                    cmd.Parameters.AddWithValue("@Date", Date);
                    cmd.Parameters.AddWithValue("@PaidBy", PaidBy);
                    cmd.Parameters.AddWithValue("@Source", Source);
                    cmd.Parameters.AddWithValue("@SourceAccountNumber", SourceAccountNumber);
                    cmd.Parameters.AddWithValue("@PayingAccountNumber", PayingAccountNumber);
                    cmd.Parameters.AddWithValue("@BankReference", BankReference);
                    cmd.Parameters.AddWithValue("@Narration", Narration);
                    cmd.Parameters.AddWithValue("@InstallmentAmount", InstallmentAmount);
                    cmd.Parameters.AddWithValue("@InterestAmount", InterestAmount);
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
       * Function deletes loan record 
       * 
       * @param DocumentNumber | The loan document number
       * @return bool | return true if loan product is deleted / return false if not deleted
       */
        public static bool DeleteLoanRepaymentRecord(string DocumentNumber)
        {
            bool status = false;

            string sql = "DELETE FROM [saccobook].[memberloanrepayments] WHERE DocumentNumber = @DocumentNumber";
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

        /* Function returns Loan Repayment Information
        * @param _DocumentNumber | The loan's DocumentNumber
        * @return string | returns JSON string with loan Information
        */
        public static string GetLoanRepaymentInfo(string _DocumentNumber)
        {
            string LoanRepaymenData = "", DocumentNumber = "", LoanId = "", MembershipNumber = "";
            DateTime Date = default(DateTime); 
            string PaidBy ="", Source ="", SourceAccountNumber ="", PayingAccountNumber ="", BankReference ="", Narration ="", Status="", CreatedBy ="", LastModifiedBy ="", LastModifiedAt ="";
            double InstallmentAmount = 0, InterestAmount = 0;
           
            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                string sql = "select \"saccobook.memberloanrepayments\".\"DocumentNumber\", \"saccobook.memberloanrepayments\".\"LoanId\",\"saccobook.memberloanrepayments\".\"Date\", \"saccobook.memberloanrepayments\".\"PaidBy\", \"saccobook.memberloanrepayments\".\"Source\", \"saccobook.memberloanrepayments\".\"SourceAccountNumber\", \"saccobook.memberloanrepayments\".\"PayingAccountNumber\", \"saccobook.memberloanrepayments\".\"BankReference\", \"saccobook.memberloanrepayments\".\"Narration\", \"saccobook.memberloanrepayments\".\"InstallmentAmount\", \"saccobook.memberloanrepayments\".\"InterestAmount\", \"saccobook.memberloanrepayments\".\"Status\",\"saccobook.memberloanrepayments\".\"CreatedBy\",\"saccobook.memberloans\".\"MembershipNumber\"                                         from(\"saccobook\".\"memberloanrepayments\" \"saccobook.memberloanrepayments\" inner join \"saccobook\".\"memberloans\" \"saccobook.memberloans\" on(\"saccobook.memberloans\".\"DocumentNumber\" = \"saccobook.memberloanrepayments\".\"LoanId\")) where  (\"saccobook.memberloanrepayments\".\"DocumentNumber\" = '" + _DocumentNumber + "')";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    DocumentNumber = dr.GetString(0);
                    LoanId = dr.GetString(1);
                    Date = dr.GetDateTime(2);
                    PaidBy = dr.GetString(3);
                    Source = dr.GetString(4);
                    SourceAccountNumber = dr.GetString(5);
                    PayingAccountNumber = dr.GetString(6);
                    BankReference = dr.GetString(7);
                    Narration = dr.GetString(8);
                    InstallmentAmount = dr.GetDouble(9);
                    InterestAmount = dr.GetDouble(10);
                    Status = dr.GetString(11);
                    CreatedBy = dr.GetString(12);
                   // LastModifiedBy = dr.GetString(13);
                   // LastModifiedAt = dr.GetString(14);
                    MembershipNumber = dr.GetString(13);
                }
                conn.Close();

                var _LoanRepayment = new LoanRepayment
                {
                    DocumentNumber = DocumentNumber,
                    SourceAccountNumber = SourceAccountNumber,
                    PayingAccountNumber = PayingAccountNumber,
                    BankReference = BankReference,
                    Date = Date,
                    LoanId = LoanId,
                    MembershipNumber = MembershipNumber,
                    Narration = Narration,
                    InstallmentAmount = InstallmentAmount,
                    InterestAmount = InterestAmount,
                    PaidBy = PaidBy,
                    Source = Source,
                    Status = Status,
                    LastModifiedAt = LastModifiedAt,
                    LastModifiedBy = LastModifiedBy
                };
                LoanRepaymenData = JsonConvert.SerializeObject(_LoanRepayment);
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                     System.Diagnostics.EventLogEntryType.Warning);
            }
            return LoanRepaymenData;
        }

        ////////////////////////////Guarantors
        ///
        public static bool CreateGuarantor(string LoanId
          , string IDNumber
          , string Names
          , string DateOfBirth
          , string StaffPayroll
          , bool Signatory
          , bool MustSign
          , bool MustBePresent
          , byte[] Picture
          , byte[] Signature
          , string ExpiryDate
          , string Type
          , string MemberNo
          , string EntryType
          , string PhoneNo
          , string Nationality
          , string Address
          , string Email
          , string WorkStation
          , string Employer
          , string Residence
          , string OtherBankers
          , string Occupation
          , string PINNumber, double AmountGuaranteed)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO [saccobook].[guarantors]
                               ([LoanId]
                               ,[IDNumber]
                               ,[Names]
                               ,[DateOfBirth]
                               ,[StaffPayroll]
                               ,[Signatory]
                               ,[MustSign]
                               ,[MustBePresent]
                               ,[Picture]
                               ,[Signature]
                               ,[ExpiryDate]
                               ,[Type]
                               ,[MemberNo]
                               ,[EntryType]
                               ,[PhoneNo]
                               ,[Nationality]
                               ,[Address]
                               ,[Email]
                               ,[WorkStation]
                               ,[Employer]
                               ,[Residence]
                               ,[OtherBankers]
                               ,[Occupation]
                               ,[PINNumber], [AmountGuaranteed])
                         VALUES
                               (@LoanId
                               ,@IDNumber
                               ,@Names
                               ,@DateOfBirth
                               ,@StaffPayroll
                               ,@Signatory
                               ,@MustSign
                               ,@MustBePresent
                               ,@Picture
                               ,@Signature
                               ,@ExpiryDate
                               ,@Type
                               ,@MemberNo
                               ,@EntryType
                               ,@PhoneNo
                               ,@Nationality
                               ,@Address
                               ,@Email
                               ,@WorkStation
                               ,@Employer
                               ,@Residence
                               ,@OtherBankers
                               ,@Occupation
                               ,@PINNumber,
                                @AmountGuaranteed)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@LoanId", LoanId);
                    cmd.Parameters.AddWithValue("@IDNumber", IDNumber);
                    cmd.Parameters.AddWithValue("@Names", Names);
                    cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    cmd.Parameters.AddWithValue("@StaffPayroll", StaffPayroll);
                    cmd.Parameters.AddWithValue("@Signatory", Signatory);
                    cmd.Parameters.AddWithValue("@MustSign", MustSign);
                    cmd.Parameters.AddWithValue("@MustBePresent", MustBePresent);
                    cmd.Parameters.AddWithValue("@Picture", Picture);
                    cmd.Parameters.AddWithValue("@Signature", Signature);
                    cmd.Parameters.AddWithValue("@ExpiryDate", ExpiryDate);
                    cmd.Parameters.AddWithValue("@MemberNo", MemberNo);
                    cmd.Parameters.AddWithValue("@Type", Type);
                    cmd.Parameters.AddWithValue("@EntryType", EntryType);
                    cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
                    cmd.Parameters.AddWithValue("@Nationality", Nationality);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@WorkStation", WorkStation);
                    cmd.Parameters.AddWithValue("@Employer", Employer);
                    cmd.Parameters.AddWithValue("@Residence", Residence);
                    cmd.Parameters.AddWithValue("@OtherBankers", OtherBankers);
                    cmd.Parameters.AddWithValue("@Occupation", Occupation);
                    cmd.Parameters.AddWithValue("@PINNumber", PINNumber);
                    cmd.Parameters.AddWithValue("@AmountGuaranteed", AmountGuaranteed); 
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

        public static string LoadGuarantors(string LoanId)
        {
            string sql = @"SELECT [Id],
                               [IDNumber]
                              ,[Names]
                              ,[DateOfBirth]
                              ,[Email]
                              ,[PhoneNo]
                              ,[Address]      
                          FROM [Sacco Book].[saccobook].[guarantors] where LoanId = '" + LoanId + "'";
            return sql;
        }

        public static int GetLoanDefualterCount()
        {
            int Count = 0;

            using (var db = new SaccoBookEntities())
            {
                var _member = db.memberloans.Count();

                Count = Convert.ToInt32(_member);
            }



            
            return Count;
        }
    }
}
