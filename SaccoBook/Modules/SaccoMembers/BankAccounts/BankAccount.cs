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
using DevExpress.XtraSplashScreen;
using System.Threading;
using Newtonsoft.Json;

namespace SaccoBook.Modules.SaccoMembers.BankAccounts
{
    public partial class BankAccount : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        static bool _Edit = false;
        static string _BankAccountNumber = null;
        static string MembershipNumber = null;
        public BankAccount()
        {
            InitializeComponent();
        }
        public BankAccount(string _MembershipNumber)
        {
            InitializeComponent();
            LoadMemberInformation(_MembershipNumber);
        }
        public BankAccount(string _MembershipNumber, string BankAccountNumber, bool edit)
        {
            InitializeComponent();
            _Edit = edit;
            _BankAccountNumber = BankAccountNumber;
            MembershipNumber = _MembershipNumber;
            LoadMemberInformation(MembershipNumber);
            LoadBankAccountInformation(_BankAccountNumber);
        }
        private void LoadMemberInformation(string MembershipNumber)
        {

            SplashScreenManager.ShowForm(this, typeof(AppWaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Please wait");
            SplashScreenManager.Default.SetWaitFormDescription("Loading...");

            string GetMemberInfoJSON = EF.MemberQueries.GetMemberInfo(MembershipNumber);
            Member jsonGetMemberInfo = JsonConvert.DeserializeObject<Member>(GetMemberInfoJSON);

            _MembershipNumber.Text = MembershipNumber;
            _Name.Text = jsonGetMemberInfo.Name;            
            _NationalIdNumber.Text = jsonGetMemberInfo.NationalIdNumber;
            _DateJoined.Text = jsonGetMemberInfo.DateJoined.ToString();
            _MembershipStatus.Text = jsonGetMemberInfo.MembershipStatus;

            SplashScreenManager.CloseForm();
        }

        private void LoadBankAccountInformation(string _BankAccountNumber)
        {
            string GetBankAccountInfoJSON = EF.BankQueries.GetBankAccountInfo(MembershipNumber, _BankAccountNumber);
            dynamic jsonGetBankAccountInfo = JObject.Parse(GetBankAccountInfoJSON);
            _BankName.Text = jsonGetBankAccountInfo.BankName;
            _Branch.Text = jsonGetBankAccountInfo.Branch;
            _AccountNumber.Text = jsonGetBankAccountInfo.AccountNumber; 
        }

        private void btn_save_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dxValidationProviderBankAccount.Validate().Equals(true))
            {
                if (_Edit == true)
                {
                    if (EF.BankQueries.UpdateBankAccount(_MembershipNumber.Text, _BankName.Text, _Branch.Text, _AccountNumber.Text, Login.LoggedInUser, DateTime.Now.ToString()))
                    {
                        XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (EF.BankQueries.CreateBankAccount(_MembershipNumber.Text, _BankName.Text, _Branch.Text, _AccountNumber.Text, Login.LoggedInUser, DateTime.Now.ToString()))
                    {
                        XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }
    }
}