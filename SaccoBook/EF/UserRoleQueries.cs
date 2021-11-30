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
    class UserRoleQueries
    {
        static string connectionstring = AppResources.DatabaseConnection.ConnectionString();

        public static string GetUSerRoles()
        {
            string sql = @"SELECT TOP (1000) [Id]
                              ,[RoleId]
                              ,[CanLogin]
                              ,[IsMasterAdmin]
                              ,[CanAddUser]
                              ,[CanAddKin]
                              ,[CanViewMemberProfile]
                              ,[CanEditUser]
                              ,[CanDeleteUser]
                              ,[CanAddSavings]
                              ,[CanAddWithdrawal]
                              ,[CanAddBulkSavings]
                              ,[CanAddLoan]
                              ,[CanAddLoanRepayment]
                              ,[CanViewRepaymentHistory]
                              ,[CanViewLoanGuarantors]
                              ,[CanEditLoan]
                              ,[CanDeleteLoan]
                              ,[CanAddShares]
                              ,[CanViewShares]
                              ,[CanAddExpenses]
                              ,[CanEditExpenses]
                              ,[CanDeleteExpenses]
                              ,[LastModifiedBy]
                              ,[LastModifiedAt]
                          FROM [Sacco Book].[saccobook].[roles]";

            return sql;
        }
        public static void LoadRoles(DevExpress.XtraEditors.SearchLookUpEdit _SearchLookUpEdit)
        {
            AppResources.AppFunctions.LoadSearchLookUpEdit(_SearchLookUpEdit, GetUSerRoles());
        }

        /**
        * Function creates a user role
        */

        public static bool CreateUserRole(string RoleId, bool CanLogin, bool IsMasterAdmin, bool CanAddUser, bool CanAddKin, bool CanViewMemberProfile,
            bool CanEditUser, bool CanDeleteUser, bool CanAddSavings, bool CanAddWithdrawal, bool CanAddBulkSavings, bool CanAddLoan, bool CanAddLoanRepayment,
            bool CanViewRepaymentHistory, bool CanViewLoanGuarantors, bool CanEditLoan, bool CanDeleteLoan, bool CanAddShares, bool CanViewShares, bool CanAddExpenses,
            bool CanEditExpenses, bool CanDeleteExpenses, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO [saccobook].[roles]
                                (RoleId, CanLogin, IsMasterAdmin, CanAddUser, CanAddKin, CanViewMemberProfile, 
                                CanEditUser, CanDeleteUser, CanAddSavings, CanAddWithdrawal, CanAddBulkSavings, CanAddLoan, 
                                CanAddLoanRepayment, CanViewRepaymentHistory, CanViewLoanGuarantors, CanEditLoan, CanDeleteLoan, 
                                CanAddShares, CanViewShares, CanAddExpenses, CanEditExpenses, CanDeleteExpenses, LastModifiedBy, LastModifiedAt) 
                                VALUES 
                                (@RoleId, @CanLogin, @IsMasterAdmin, @CanAddUser, @CanAddKin, @CanViewMemberProfile, 
                                @CanEditUser, @CanDeleteUser, @CanAddSavings, @CanAddWithdrawal, @CanAddBulkSavings, @CanAddLoan, 
                                @CanAddLoanRepayment, @CanViewRepaymentHistory, @CanViewLoanGuarantors, @CanEditLoan, @CanDeleteLoan, 
                                @CanAddShares, @CanViewShares, @CanAddExpenses, @CanEditExpenses, @CanDeleteExpenses, @LastModifiedBy, @LastModifiedAt)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@RoleId", RoleId);
                    cmd.Parameters.AddWithValue("@CanLogin", CanLogin);
                    cmd.Parameters.AddWithValue("@IsMasterAdmin", IsMasterAdmin);
                    cmd.Parameters.AddWithValue("@CanAddUser", CanAddUser);
                    cmd.Parameters.AddWithValue("@CanAddKin", CanAddKin);
                    cmd.Parameters.AddWithValue("@CanViewMemberProfile", CanViewMemberProfile);
                    cmd.Parameters.AddWithValue("@CanEditUser", CanEditUser);
                    cmd.Parameters.AddWithValue("@CanDeleteUser", CanDeleteUser);
                    cmd.Parameters.AddWithValue("@CanAddSavings", CanAddSavings);
                    cmd.Parameters.AddWithValue("@CanAddWithdrawal", CanAddWithdrawal);
                    cmd.Parameters.AddWithValue("@CanAddBulkSavings", CanAddBulkSavings);
                    cmd.Parameters.AddWithValue("@CanAddLoan", CanAddLoan);
                    cmd.Parameters.AddWithValue("@CanAddLoanRepayment", CanAddLoanRepayment);
                    cmd.Parameters.AddWithValue("@CanViewRepaymentHistory", CanViewRepaymentHistory);
                    cmd.Parameters.AddWithValue("@CanViewLoanGuarantors", CanViewLoanGuarantors);
                    cmd.Parameters.AddWithValue("@CanEditLoan", CanEditLoan);
                    cmd.Parameters.AddWithValue("@CanDeleteLoan", CanDeleteLoan);
                    cmd.Parameters.AddWithValue("@CanAddShares", CanAddShares);
                    cmd.Parameters.AddWithValue("@CanViewShares", CanViewShares);
                    cmd.Parameters.AddWithValue("@CanAddExpenses", CanAddExpenses);
                    cmd.Parameters.AddWithValue("@CanEditExpenses", CanEditExpenses);
                    cmd.Parameters.AddWithValue("@CanDeleteExpenses", CanDeleteExpenses);
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
       * Function updates a user role
       */
        public static bool UpdateUserRole(string RoleId, bool CanLogin, bool IsMasterAdmin, bool CanAddUser, bool CanAddKin, bool CanViewMemberProfile,
           bool CanEditUser, bool CanDeleteUser, bool CanAddSavings, bool CanAddWithdrawal, bool CanAddBulkSavings, bool CanAddLoan, bool CanAddLoanRepayment,
           bool CanViewRepaymentHistory, bool CanViewLoanGuarantors, bool CanEditLoan, bool CanDeleteLoan, bool CanAddShares, bool CanViewShares, bool CanAddExpenses,
           bool CanEditExpenses, bool CanDeleteExpenses, string LastModifiedBy, string LastModifiedAt)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                conn.Open();

                string sql = @"UPDATE [saccobook].[roles] SET RoleId=@RoleId,CanLogin=@CanLogin,IsMasterAdmin=@IsMasterAdmin,
                                CanAddUser=@CanAddUser,CanAddKin=@CanAddKin,CanViewMemberProfile=@CanViewMemberProfile,CanEditUser=@CanEditUser,
                                CanDeleteUser=@CanDeleteUser,CanAddSavings=@CanAddSavings,CanAddWithdrawal=@CanAddWithdrawal,CanAddBulkSavings=@CanAddBulkSavings,
                                CanAddLoan=@CanAddLoan,CanAddLoanRepayment=@CanAddLoanRepayment,CanViewRepaymentHistory=@CanViewRepaymentHistory,
                                CanViewLoanGuarantors=@CanViewLoanGuarantors,CanEditLoan=@CanEditLoan,CanDeleteLoan=@CanDeleteLoan,CanAddShares=@CanAddShares,
                                CanViewShares=@CanViewShares,CanAddExpenses=@CanAddExpenses,CanEditExpenses=@CanEditExpenses,CanDeleteExpenses=@CanDeleteExpenses,
                                LastModifiedBy=@LastModifiedBy,LastModifiedAt=@LastModifiedAt WHERE RoleId=@RoleId";
                                                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@RoleId", RoleId);
                    cmd.Parameters.AddWithValue("@CanLogin", CanLogin);
                    cmd.Parameters.AddWithValue("@IsMasterAdmin", IsMasterAdmin);
                    cmd.Parameters.AddWithValue("@CanAddUser", CanAddUser);
                    cmd.Parameters.AddWithValue("@CanAddKin", CanAddKin);
                    cmd.Parameters.AddWithValue("@CanViewMemberProfile", CanViewMemberProfile);
                    cmd.Parameters.AddWithValue("@CanEditUser", CanEditUser);
                    cmd.Parameters.AddWithValue("@CanDeleteUser", CanDeleteUser);
                    cmd.Parameters.AddWithValue("@CanAddSavings", CanAddSavings);
                    cmd.Parameters.AddWithValue("@CanAddWithdrawal", CanAddWithdrawal);
                    cmd.Parameters.AddWithValue("@CanAddBulkSavings", CanAddBulkSavings);
                    cmd.Parameters.AddWithValue("@CanAddLoan", CanAddLoan);
                    cmd.Parameters.AddWithValue("@CanAddLoanRepayment", CanAddLoanRepayment);
                    cmd.Parameters.AddWithValue("@CanViewRepaymentHistory", CanViewRepaymentHistory);
                    cmd.Parameters.AddWithValue("@CanViewLoanGuarantors", CanViewLoanGuarantors);
                    cmd.Parameters.AddWithValue("@CanEditLoan", CanEditLoan);
                    cmd.Parameters.AddWithValue("@CanDeleteLoan", CanDeleteLoan);
                    cmd.Parameters.AddWithValue("@CanAddShares", CanAddShares);
                    cmd.Parameters.AddWithValue("@CanViewShares", CanViewShares);
                    cmd.Parameters.AddWithValue("@CanAddExpenses", CanAddExpenses);
                    cmd.Parameters.AddWithValue("@CanEditExpenses", CanEditExpenses);
                    cmd.Parameters.AddWithValue("@CanDeleteExpenses", CanDeleteExpenses);
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
        * Function deletes a user role
        */
        public static bool DeleteRole(string RoleId)
        {
            bool status = false;

            string sql = "DELETE FROM [saccobook].[roles] WHERE RoleId = @RoleId";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionstring;
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@RoleId", RoleId);
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
        * Function gets the details of a specified user role
        */
        public static string GetuserRoleInfo(string RoleId)
        {
            string userroledata = "";
            bool CanLogin = false; bool IsMasterAdmin = false;
            //Members Functionalities
            bool CanAddUser = false;  bool CanAddKin = false;  bool CanViewMemberProfile = false; bool CanEditUser = false; bool CanDeleteUser = false;
            //Savings Functionalities
            bool CanAddSavings = false; bool CanAddWithdrawal = false; bool CanAddBulkSavings = false;
            //Loans Functionalities
            bool CanAddLoan = false; bool CanAddLoanRepayment = false; bool CanViewRepaymentHistory = false;  bool CanViewLoanGuarantors = false; bool CanEditLoan = false; bool CanDeleteLoan = false;
            //Shares Functionalities
            bool CanAddShares = false; bool CanViewShares = false;
            //Expenses Functionalities
            bool CanAddExpenses = false; bool CanEditExpenses = false; bool CanDeleteExpenses = false;

            string LastModifiedBy = ""; string LastModifiedAt = "";

            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [saccobook].[roles] WHERE RoleId = '" + RoleId + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    RoleId = dr.GetString(1);
                    CanLogin = Convert.ToBoolean(dr.GetValue(2));
                    IsMasterAdmin = Convert.ToBoolean(dr.GetValue(3));
                    //Members Functionalities
                    CanAddUser = Convert.ToBoolean(dr.GetValue(4));
                    CanAddKin = Convert.ToBoolean(dr.GetValue(5));
                    CanViewMemberProfile = Convert.ToBoolean(dr.GetValue(6));
                    CanEditUser = Convert.ToBoolean(dr.GetValue(7));
                    CanDeleteUser = Convert.ToBoolean(dr.GetValue(8));
                    //Savings Functionalities
                    CanAddSavings = Convert.ToBoolean(dr.GetValue(9));
                    CanAddWithdrawal = Convert.ToBoolean(dr.GetValue(10));
                    CanAddBulkSavings = Convert.ToBoolean(dr.GetValue(11));
                    //Loans Functionalities
                    CanAddLoan = Convert.ToBoolean(dr.GetValue(12));
                    CanAddLoanRepayment = Convert.ToBoolean(dr.GetValue(13));
                    CanViewRepaymentHistory = Convert.ToBoolean(dr.GetValue(14));
                    CanViewLoanGuarantors = Convert.ToBoolean(dr.GetValue(15));
                    CanEditLoan = Convert.ToBoolean(dr.GetValue(16));
                    CanDeleteLoan = Convert.ToBoolean(dr.GetValue(17));
                    //Shares Functionalities
                    CanAddShares = Convert.ToBoolean(dr.GetValue(18));
                    CanViewShares = Convert.ToBoolean(dr.GetValue(19));
                    //Expenses Functionalities
                    CanAddExpenses = Convert.ToBoolean(dr.GetValue(20));
                    CanEditExpenses = Convert.ToBoolean(dr.GetValue(21));
                    CanDeleteExpenses = Convert.ToBoolean(dr.GetValue(22));
                    LastModifiedBy = dr.GetString(23);
                    LastModifiedAt = dr.GetString(24);

                }
                conn.Close();

                var _Role = new Role
                {
                    RoleId = RoleId,
                    CanLogin = CanLogin,
                    IsMasterAdmin = IsMasterAdmin,
                    //Members Functionalities
                    CanAddUser = CanAddUser,
                    CanAddKin = CanAddKin,
                    CanViewMemberProfile = CanViewMemberProfile,
                    CanEditUser = CanEditUser,
                    CanDeleteUser = CanDeleteUser,
                    //Savings Functionalities
                    CanAddSavings = CanAddSavings,
                    CanAddWithdrawal = CanAddWithdrawal,
                    CanAddBulkSavings = CanAddBulkSavings,
                    //Loans Functionalities
                    CanAddLoan = CanAddLoan,
                    CanAddLoanRepayment = CanAddLoanRepayment,
                    CanViewRepaymentHistory = CanViewRepaymentHistory,
                    CanViewLoanGuarantors = CanViewLoanGuarantors,
                    CanEditLoan = CanEditLoan,
                    CanDeleteLoan = CanDeleteLoan,
                    //Shares Functionalities
                    CanAddShares = CanAddShares,
                    CanViewShares = CanViewShares,
                    //Expenses Functionalities
                    CanAddExpenses = CanAddExpenses,
                    CanEditExpenses = CanEditExpenses,
                    CanDeleteExpenses = CanDeleteExpenses,
                    LastModifiedBy = LastModifiedBy,
                    LastModifiedAt = LastModifiedAt
                };
                userroledata = JsonConvert.SerializeObject(_Role);
            }
            catch (SqlException es)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", es.ToString(),
                                System.Diagnostics.EventLogEntryType.Warning);
            }
            return userroledata;
        }
    }
}
