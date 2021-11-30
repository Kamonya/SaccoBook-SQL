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
using Newtonsoft.Json;

namespace SaccoBook.Modules.SavingsWithdrawals.Savings
{
    public partial class SavingsAccount : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        bool IsDocumentCreated = false;
        static string _NumberSeriesCode = null;
        public SavingsAccount()
        {
            InitializeComponent();

            EF.MemberQueries.LoadActiveMembers(_Search, _Search.EditValue.ToString());
            EF.SavingsQueries.LoadSavingAccountTypes(AccountsTypeSearchLookUp);
            AccountsTypeSearchLookUp.Properties.DisplayMember = "Name";
            AccountsTypeSearchLookUp.Properties.ValueMember = "Code";

        }
        private void GetAccountNumber(string DocumentNumberSeriesCode)
        {
            string _NumberSeriesData = EF.NumberSeriesQueries.GetNumberSeriesInfo(DocumentNumberSeriesCode);

            dynamic responseObject = JObject.Parse(_NumberSeriesData);
            string LastUsedNumber = responseObject.LastUsedNumber;

            if (LastUsedNumber != "")
            {
                MemberAccountNumber.Text = AppResources.AppFunctions.GetNewDocumentNumber(DocumentNumberSeriesCode, LastUsedNumber);
            }
            else
            {
                XtraMessageBox.Show("Encountered an error: The document number series has not been properly configured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppResources.DevexpressFunctions.EnableDisableForm(layoutControl1, true);
            }           
        }
        private void _Search_EditValueChanged(object sender, EventArgs e)
        {
            if(_Search.EditValue != null)
            {
                SplashScreenManager.ShowForm(this, typeof(AppWaitForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Please wait");
                SplashScreenManager.Default.SetWaitFormDescription("Loading...");

                string MembershipNumber = _Search.EditValue.ToString();
                string GetMemberInfoJSON = EF.MemberQueries.GetMemberInfo(MembershipNumber);
                Member jsonGetMemberInfo = JsonConvert.DeserializeObject<Member>(GetMemberInfoJSON);

                _MembershipNumber.Text = MembershipNumber;
                _Name.Text = jsonGetMemberInfo.Name;                
                _NationalIdNumber.Text = jsonGetMemberInfo.NationalIdNumber;
                _DateJoined.Text = jsonGetMemberInfo.DateJoined.ToString();
                _MembershipStatus.Text = jsonGetMemberInfo.MembershipStatus;

                SplashScreenManager.CloseForm();
            }            
        }

        private void AccountsTypeSearchLookUp_EditValueChanged(object sender, EventArgs e)
        {

            if (AccountsTypeSearchLookUp.EditValue != null)
            {
                //Get Account Code
                string AccountCode = AccountsTypeSearchLookUp.EditValue.ToString();
                //Get Account Number from Number Series

                GetAccountNumber(AccountCode);

                _NumberSeriesCode = AccountCode;
            }
        }

        private void btn_save_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!IsDocumentCreated)
            {
                save();
            }
            else
            {
                update();
            }            
        }

        private void save()
        {
            if (dxValidationProviderSavingsAccount.Validate().Equals(true))
            {
                string OpeningBalance = _OpeningBalance.Text.Replace(",", "");

                if (EF.SavingsQueries.CreateMemberSavingsAccount(MemberAccountNumber.Text, AccountsTypeSearchLookUp.EditValue.ToString(), AccountsTypeSearchLookUp.Text, _MembershipNumber.Text, OpeningBalance, "0.00", OpeningBalance, _DateCreated.Text, _AccountStatus.Text, Login.LoggedInUser, DateTime.Now.ToString()))
                {
                    EF.NumberSeriesQueries.UpdateLastUsedNumberSeries(_NumberSeriesCode, MemberAccountNumber.Text);

                    IsDocumentCreated = true;

                    XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void update()
        {
            if (dxValidationProviderSavingsAccount.Validate().Equals(true))
            {
                string OpeningBalance = _OpeningBalance.Text.Replace(",", "");

                if (EF.SavingsQueries.UpdateMemberSavingsAccountType(MemberAccountNumber.Text, AccountsTypeSearchLookUp.EditValue.ToString(), AccountsTypeSearchLookUp.Text, _MembershipNumber.Text, OpeningBalance, "0.00", OpeningBalance, _DateCreated.Text, _AccountStatus.Text, Login.LoggedInUser, DateTime.Now.ToString()))
                {
                    IsDocumentCreated = true;
                    XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}