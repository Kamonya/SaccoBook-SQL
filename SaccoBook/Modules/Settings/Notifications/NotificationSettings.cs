using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Newtonsoft.Json.Linq;
using DevExpress.XtraEditors;

namespace SaccoBook.Modules.Settings.Notifications
{
    public partial class NotificationSettings : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public NotificationSettings()
        {
            InitializeComponent();
            LoadNotificationSettings();
        }

        private void LoadNotificationSettings()
        {
            string GetSystemSettingsResponse = EF.SystemSettingsQueries.GetSystemSettings();
            dynamic GetSystemSettingsResponseObject = JObject.Parse(GetSystemSettingsResponse);

            string AfricasTalkingUsername = GetSystemSettingsResponseObject.AfricasTalkingUsername;
            _AfricasTalkingUsername.Text = AfricasTalkingUsername;
            string AfricasTalkingAPIKey = GetSystemSettingsResponseObject.AfricasTalkingAPIKey;
            _AfricasTalkingAPIKey.Text = AfricasTalkingAPIKey;
            string SMSNotificationsEnabled = GetSystemSettingsResponseObject.SMSNotificationsEnabled;
            _SMSNotificationsEnabled.Checked = bool.Parse(SMSNotificationsEnabled);
            string SMTPServer = GetSystemSettingsResponseObject.SMTPServer;
            _SMTPServer.Text = SMTPServer;
            string SMTPServerPort = GetSystemSettingsResponseObject.SMTPServerPort;
            _SMTPServerPort.Text = SMTPServerPort;
            string UserId = GetSystemSettingsResponseObject.UserId;
            _UserId.Text = UserId;
            string Password = GetSystemSettingsResponseObject.Password;
            _Password.Text = Password;
            string EmailNotificationsEnabled = GetSystemSettingsResponseObject.EmailNotificationsEnabled;
            _EmailNotificationsEnabled.Checked = bool.Parse(EmailNotificationsEnabled);
        }

        private void btn_save_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (EF.SystemSettingsQueries.UpdateSettings(_AfricasTalkingUsername.Text, _AfricasTalkingAPIKey.Text, _SMSNotificationsEnabled.Checked, _SMTPServer.Text, _SMTPServerPort.Text, _UserId.Text, _Password.Text, _EmailNotificationsEnabled.Checked, Login.LoggedInUser, DateTime.Now.ToString()))
            {
                XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
         
        private void btn_sendtestmail_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = XtraInputBox.Show("Enter email address", "Send Test Mail", _UserId.Text);

            if (result != "" && AppResources.RegexFunctions.IsValidEmailAddress(result))
            {
                if (AppResources.EmailFunctions.SendMail(result, result, "Test Email", "This is a test mail. Do not reply."))
                {
                    XtraMessageBox.Show("The test mail has been successfully sent", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_sendtestsms_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = XtraInputBox.Show("Enter phone number", "Send Test SMS", "254720000000");

            if (result != "" && AppResources.RegexFunctions.IsValidPhoneNumber(result))
            {
                if (AppResources.AppFunctions.SendTextMessage(result, "Dear Winjoy  Kathomi 0727333557. Reverse MPESA transaction PB92I1AVY8 of Ksh 1000 credited to your MPESA account or we will take action"))
                {
                    XtraMessageBox.Show("The test sms has been successfully sent", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("Encountered an error: " + "You must provide a valid recipient phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}