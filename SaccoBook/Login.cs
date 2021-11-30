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
using DevExpress.XtraSplashScreen;
using System.Threading;
using System.Globalization;

namespace SaccoBook
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public static string LoggedInUser;
        public Login()
        {
            InitializeComponent();
            AppResources.AppFunctions.CreateAppFolders();
        }

        private void ForgotPasswordLink_Click(object sender, EventArgs e)
        {

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
        /**
        * Function Authenticates User into software if Password and Username specified are correct
        */
        private void UserLogin()
        {
            //check if all fields have been filled as defined
            if (dxValidationProvider_login.Validate().Equals(true))
            {
                string Username = txt_username.Text.Trim();
                string Password = txt_password.Text;// Utilities.EnCryptDecrypt.Encrypt(txt_password.Text.Trim(), true);

                string CredentialType = AppResources.AppConstants.GetSystemCredentialType();

                if (CredentialType == "UserPassword" || CredentialType =="")
                {
                    AuthenticateUser(Username, Password);                   
                }
                else if (CredentialType == "WindowsAuthentication")
                {
                    string domain = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
                    string adPath = "LDAP://" + domain;

                    Utilities.LDAPAuthenticator auth = new Utilities.LDAPAuthenticator(adPath);                   

                    if (auth.authenticated(domain, Username, Password))
                    {
                        //Windows Password is correct, fetch user role ID by Windows Username.
                        //Windows Username Should be the same as registered

                        string GetuserRoleIDByWindowsUsernameResponse = EF.SystemUserQueries.GetuserRoleIDByWindowsUsername(Username);
                        dynamic UserLoginResponseObject = JObject.Parse(GetuserRoleIDByWindowsUsernameResponse);
                        string RoleId = UserLoginResponseObject.RoleId;

                        if(RoleId != "")
                        {
                            //Auth user
                            if (CanUserLogin(RoleId))
                            {
                                LoggedInUser = Username;


                                this.Hide();
                                SplashScreenManager.ShowForm(this, typeof(AppWaitForm), true, true, false);
                                SplashScreenManager.Default.SetWaitFormCaption("Please wait");
                                SplashScreenManager.Default.SetWaitFormDescription("Loading modules...");

                                Dashboard s = new Dashboard(RoleId);
                                s.Show();
                                SplashScreenManager.CloseForm();
                            }
                            else
                            {
                                XtraMessageBox.Show("Your account cannot perform this action. Kindly contact the system Administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Your profile is not well defined in " + AppResources.AppConstants.GetSoftwareName() + " . Kindly contact the system administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("No account with the credentials provided was found. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                    
            }
        }

        private void AuthenticateUser(string Username, string Password)
        {
            string RoleId = null;
            bool _CanLogin = false;

            if (EF.SystemUserQueries.CheckUserLogin(Username, Password))
            {
                if (EF.SystemUserQueries.CountUsers() <= 1)
                {
                    _CanLogin = true;
                    RoleId = "ADMIN";
                }
                else
                {
                    string UserLoginResponse = EF.SystemUserQueries.UserLogin(Username, Password);
                    dynamic UserLoginResponseObject = JObject.Parse(UserLoginResponse);
                    RoleId = UserLoginResponseObject.RoleId;
                    _CanLogin = CanUserLogin(RoleId);
                }

                if (_CanLogin)
                {
                    LoggedInUser = Username;


                    this.Hide();
                    SplashScreenManager.ShowForm(this, typeof(AppWaitForm), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Please wait");
                    SplashScreenManager.Default.SetWaitFormDescription("Loading modules...");

                    Dashboard s = new Dashboard(RoleId);
                    s.Show();
                    SplashScreenManager.CloseForm();
                }
                else
                {
                    XtraMessageBox.Show("Your account cannot perform this action. Kindly contact the system Administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("No account with the credentials provided was found. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            UserLogin();
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UserLogin();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Thread.Sleep(8000);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}