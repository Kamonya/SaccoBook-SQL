using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace SaccoBook.Modules.Settings.Loans
{
    public partial class LoanProduct : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string _NumberSeriesCode = "CRED";
        bool _edit = false;
        string _documentNumber = null;
        public LoanProduct()
        {
            InitializeComponent();
            GetDocumentNumber(_NumberSeriesCode);
        }
        public LoanProduct(string _DocumentNumber, bool edit)
        {
            InitializeComponent();
            _documentNumber = _DocumentNumber;
            LoadLoanProduct(_DocumentNumber);
            _edit = edit;
        }

        private void LoadLoanProduct(string documentNumber)
        {       
            SplashScreenManager.ShowForm(this, typeof(AppWaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Please wait");
            SplashScreenManager.Default.SetWaitFormDescription("Loading...");

            string CreditProductInfoJSON = EF.LoansQueries.GetCreditProductInfo(documentNumber);
            dynamic jsonGetMemberInfo = JObject.Parse(CreditProductInfoJSON);
            string Name = jsonGetMemberInfo.Name;
            string InterestRate = jsonGetMemberInfo.InterestRate;
            string RequiresMakerChecker = jsonGetMemberInfo.RequiresMakerChecker;
            string InterestCalculationType = jsonGetMemberInfo.InterestCalculationType;
            string MaximumLoanAmount = jsonGetMemberInfo.MaximumLoanAmount;
            string MaxRepaymentPeriodInMonths = jsonGetMemberInfo.MaxRepaymentPeriodInMonths;
            string MinimumDepositContribution = jsonGetMemberInfo.MinimumDepositContribution;
            string Description = jsonGetMemberInfo.Description;

            bool __RequiresMakerChecker = bool.Parse(RequiresMakerChecker);

            _DocumentNumber.Text = documentNumber;
            _Name.Text = Name;
            _InterestRate.Text = InterestRate;
            _RequiresMakerChecker.Checked = __RequiresMakerChecker;
            _InterestCalculationType.Text = InterestCalculationType;
            _MaximumLoanAmount.Text = MaximumLoanAmount;
            _MaxRepaymentPeriodInMonths.Text = MaxRepaymentPeriodInMonths;
            _MinimumDepositContribution.Text = MinimumDepositContribution;

            SplashScreenManager.CloseForm();
        }

        private void GetDocumentNumber(string DocumentNumberSeriesCode)
        {
            string _NumberSeriesData = EF.NumberSeriesQueries.GetNumberSeriesInfo(DocumentNumberSeriesCode);

            dynamic responseObject = JObject.Parse(_NumberSeriesData);
            string LastUsedNumber = responseObject.LastUsedNumber;

            if (LastUsedNumber != "")
            {
                _DocumentNumber.Text = AppResources.AppFunctions.GetNewDocumentNumber(DocumentNumberSeriesCode, LastUsedNumber);
            }
            else
            {
                XtraMessageBox.Show("Encountered an error: The document number series has not been properly configured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppResources.DevexpressFunctions.EnableDisableForm(layoutControl1, true);
            }
        }
        private void btn_save_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dxValidationProviderLoanProduct.Validate().Equals(true))
            {
                string DocumentNumber = _DocumentNumber.Text;
                string Name = _Name.Text;
                string Description = _Name.Text;
                double InterestRate = Convert.ToDouble(_InterestRate.Text.Trim().Replace(",",""));
                bool RequiresMakerChecker = _RequiresMakerChecker.Checked;
                string InterestCalculationType = _InterestCalculationType.Text;
                double MaximumLoanAmount = Convert.ToDouble(_MaximumLoanAmount.Text.Trim().Replace(",",""));
                string MaxRepaymentPeriodInMonths = _MaxRepaymentPeriodInMonths.Text;
                double MinimumDepositContribution = Convert.ToDouble(_MinimumDepositContribution.Text.Trim().Replace(",",""));

                if (!_edit)
                {
                    if (EF.LoansQueries.CreateLoanProduct(DocumentNumber, Name, Description, InterestRate, RequiresMakerChecker, InterestCalculationType, MaximumLoanAmount, MaxRepaymentPeriodInMonths, MinimumDepositContribution, Login.LoggedInUser, DateTime.Now.ToString()))
                    {
                        XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (EF.LoansQueries.UpdateLoanProduct(_documentNumber, Name, Description, InterestRate, RequiresMakerChecker, InterestCalculationType, MaximumLoanAmount, MaxRepaymentPeriodInMonths, MinimumDepositContribution, Login.LoggedInUser, DateTime.Now.ToString()))
                    {
                        XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                
            }
        }
    }
}