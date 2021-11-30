using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Newtonsoft.Json.Linq;

namespace SaccoBook
{
    public partial class ConfirmLoggedUserPassword : DevExpress.XtraEditors.XtraForm
    {
        static string Action;
        static string Username = Login.LoggedInUser;
        static bool IsMasterAdmin = false;
        static bool CanAddUser = false;
        static bool CanAddKin = false;
        static bool CanBackUpDatabase = false;
        static bool CanRestoreDatabase = false;
        static bool CanRestoreTestDatabase = false;
        static bool CanClearDatabase = false;
        public ConfirmLoggedUserPassword()
        {
            InitializeComponent();
            _Username.Text = Username;            
        }
        public ConfirmLoggedUserPassword(string _Action)
        {
            InitializeComponent();
            _Username.Text = Username;
            Action = _Action;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            UserLogin();            
        }

        private void _Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UserLogin();
            }
        }
        /**
        * Function Authenticates User into software if Password and Username specified are correct
        */
        private void UserLogin()
        {
            if (dxValidationProvider_login.Validate().Equals(true))
            {
                string Username = _Username.Text.Trim();
                string Password = _Password.Text;// Utilities.EnCryptDecrypt.Encrypt(txt_password.Text.Trim(), true);

                //check if password is correct
                string UserLoginResponse = EF.SystemUserQueries.UserLogin(Username, Password);
                dynamic UserLoginResponseObject = JObject.Parse(UserLoginResponse);
                string RoleId = UserLoginResponseObject.RoleId;

                //check if Json Response RoleId is defined, If defined, User exists
                if (RoleId != "")
                {
                    //check if user can login or not 
                    if (CanUserLogin(RoleId))
                    {
                        //Get User Roles
                        if (GetUserRole(RoleId))
                        {
                            // Is User Master Admin? Only Master Admin
                            if (IsMasterAdmin == true)
                            {

                            }
                            else
                            {
                                if (Action == "AddSystemUser")
                                {
                                    // Does User Have rights to perform this action?
                                    if (CanAddUser)
                                    {
                                        //AddUser ss = new AddUser();
                                        //ss.ShowDialog();
                                        //this.Close();
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show("Your is not authorized perform this action. Kindly contact the system Administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                if (Action == "BackUpDatabase")
                                {
                                    // Does User Have rights to perform this action?
                                    if (CanBackUpDatabase)
                                    {
                                        //AppResources.AppFunctions.BackupDatabase(this);
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show("Your is not authorized perform this action. Kindly contact the system Administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                if (Action == "RestoreDatabase")
                                {
                                    // Does User Have rights to perform this action?
                                    if (CanRestoreDatabase)
                                    {
                                        //AppResources.AppFunctions.RestoreDatabase(this);
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show("Your is not authorized perform this action. Kindly contact the system Administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                if (Action == "RestoreTestDatabase")
                                {
                                    // Does User Have rights to perform this action?
                                    if (CanRestoreTestDatabase)
                                    {
                                        //AppResources.AppFunctions.RestoreDatabaseFromSpecifiedPath(this, AppResources.AppConstants.GetTestDatabasePath());
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show("Your is not authorized perform this action. Kindly contact the system Administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                if (Action == "ClearDatabase")
                                {
                                    // Does User Have rights to perform this action?
                                    if (CanClearDatabase)
                                    {
                                        //AppResources.AppFunctions.RestoreDatabaseFromSpecifiedPath(this, AppResources.AppConstants.GetCleanDatabasePath());
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show("Your is not authorized perform this action. Kindly contact the system Administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }                       

                    }
                    else
                    {
                        XtraMessageBox.Show("Your is not authorized perform this action. Kindly contact the system Administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("No account with the credentials provided was found. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        
       /**
       * Function returns true or false if user Can UserLogin into the software or not
       */
        private bool CanUserLogin(string RoleId)
        {
            string GetuserRoleInfoResponse = EF.UserRoleQueries.GetuserRoleInfo(RoleId);
            dynamic GetuserRoleInfoResponseObject = JObject.Parse(GetuserRoleInfoResponse);

            string CanLogin = GetuserRoleInfoResponseObject.CanLogin;

            return bool.Parse(CanLogin);
        }
        private bool GetUserRole(string RoleId)
        {
            bool IsMasterAdmin = false;

            //Get User Role Properties
            string GetuserRoleInfoResponse = EF.UserRoleQueries.GetuserRoleInfo(RoleId);
            dynamic GetuserRoleInfoResponseObject = JObject.Parse(GetuserRoleInfoResponse);


            string _IsMasterAdmin = GetuserRoleInfoResponseObject.IsMasterAdmin;
            IsMasterAdmin = bool.Parse(_IsMasterAdmin);

            //if Role is not a master Admin, set features role allows to access
            if (!IsMasterAdmin)
            {
                //Members Functionalities
                string _CanAddUser = GetuserRoleInfoResponseObject.CanAddUser;
                string _CanAddKin = GetuserRoleInfoResponseObject.CanAddKin;
                string _CanViewMemberProfile = GetuserRoleInfoResponseObject.CanViewMemberProfile;
                string _CanEditUser = GetuserRoleInfoResponseObject.CanEditUser;
                string _CanDeleteUser = GetuserRoleInfoResponseObject.CanDeleteUser;
                //Savings Functionalities
                string _CanAddSavings = GetuserRoleInfoResponseObject.CanAddSavings;
                string _CanAddWithdrawal = GetuserRoleInfoResponseObject.CanAddWithdrawal;
                string _CanAddBulkSavings = GetuserRoleInfoResponseObject.CanAddBulkSavings;
                //Loans Functionalities
                string _CanAddLoan = GetuserRoleInfoResponseObject.CanAddLoan;
                string _CanAddLoanRepayment = GetuserRoleInfoResponseObject.CanAddLoanRepayment;
                string _CanViewRepaymentHistory = GetuserRoleInfoResponseObject.CanViewRepaymentHistory;
                string _CanViewLoanGuarantors = GetuserRoleInfoResponseObject.CanViewLoanGuarantors;
                string _CanEditLoan = GetuserRoleInfoResponseObject.CanEditLoan;
                string _CanDeleteLoan = GetuserRoleInfoResponseObject.CanDeleteLoan;
                //Shares Functionalities
                string _CanAddShares = GetuserRoleInfoResponseObject.CanAddShares;
                string _CanViewShares = GetuserRoleInfoResponseObject.CanViewShares;
                //Expenses Functionalities
                string _CanAddExpenses = GetuserRoleInfoResponseObject.CanAddExpenses;
                string _CanEditExpenses = GetuserRoleInfoResponseObject.CanEditExpenses;
                string _CanDeleteExpenses = GetuserRoleInfoResponseObject.CanDeleteExpenses;

                CanAddUser = bool.Parse(_CanAddUser);
                CanAddUser = bool.Parse(_CanAddUser);
                CanAddKin = bool.Parse(_CanAddKin);

               
            }
            return true;
        }
    }
}