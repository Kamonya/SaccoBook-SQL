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
using DevExpress.XtraEditors;
using System.Globalization;
using Newtonsoft.Json.Linq;

namespace SaccoBook.Modules.Settings.Notifications
{
    public partial class NotificationTemplate : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        static string PhoneNumber = "254701000000";
        static string FullName = "James Doe";
        static string IdNumber = "32448893";
        static string Balance = AppResources.AppConstants.GetCurrency()+ "10,000.00";
        static string Amount = AppResources.AppConstants.GetCurrency() + "10,000.00";
        static string TransactionReferenceNumber = "OARETRTSVHA";
        static string TransactionCharge = AppResources.AppConstants.GetCurrency() + "28.00";
        static string EnquiryNumber = "254701000000";
        static string Date = DateTime.Today.Date.ToString("dd/MM/yyyy");
        public NotificationTemplate()
        {
            InitializeComponent();
        }
        public NotificationTemplate(string Id)
        {
            InitializeComponent();
            LoadTemplate(Id);
        }

        private void LoadTemplate(string id)
        {
            string GetNotificationTemplateInfoResponse = EF.NotificationTemplatesQueries.GetNotificationTemplateInfo(id);
            dynamic GetNotificationTemplateInfoResponseObject = JObject.Parse(GetNotificationTemplateInfoResponse);

            string EmailTemplate = GetNotificationTemplateInfoResponseObject.EmailTemplate;
            string SMSTemplate = GetNotificationTemplateInfoResponseObject.SMSTemplate;
            string Document = GetNotificationTemplateInfoResponseObject.Document;
            _Name.Text = Document;
            _EmailTemplate.Text = EmailTemplate;
            _SMSTemplate.Text = SMSTemplate;
        }

        private void btn_save_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dxValidationProviderNotificationTemplate.Validate().Equals(true))
            {
                if(EF.NotificationTemplatesQueries.CreateNotificationTemplate(_Name.Text, _EmailTemplate.Text, _SMSTemplate.Text, Login.LoggedInUser, DateTime.Now.ToString()))
                {
                    XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_testsmstemplate_ItemClick(object sender, ItemClickEventArgs e)
        {
            string Time = DateTime.Now.ToString("hh:mm tt");
            string smstext = String.Format(_SMSTemplate.Text, PhoneNumber, FullName, IdNumber, Balance, Amount, TransactionReferenceNumber, TransactionCharge, EnquiryNumber, Date, Time);
            XtraMessageBox.Show(smstext);
        }

        private void btn_emailtemplate_ItemClick(object sender, ItemClickEventArgs e)
        {
            string Time = DateTime.Now.ToString("hh:mm tt");
            string emailtext = String.Format(_EmailTemplate.Text, PhoneNumber, FullName, IdNumber, Balance, Amount, TransactionReferenceNumber, TransactionCharge, EnquiryNumber, Date, Time);
            XtraMessageBox.Show(emailtext);
        }
    }
}