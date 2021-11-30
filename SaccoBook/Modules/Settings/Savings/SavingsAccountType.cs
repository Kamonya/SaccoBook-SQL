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
using Newtonsoft.Json.Linq;
using SaccoBook.AppResources;

namespace SaccoBook.Modules.Settings.Savings
{
    public partial class SavingsAccountType : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string _NumberSeriesCode = XMLFormatter.GetContent("SavingsAccountTypeNumberSeriesCode");
        public SavingsAccountType()
        {
            InitializeComponent();
            GetDocumentNumber(_NumberSeriesCode);
        }
        private void GetDocumentNumber(string DocumentNumberSeriesCode)
        {
            string _NumberSeriesData = EF.NumberSeriesQueries.GetNumberSeriesInfo(DocumentNumberSeriesCode);

            dynamic responseObject = JObject.Parse(_NumberSeriesData);
            string LastUsedNumber = responseObject.LastUsedNumber;

            if (LastUsedNumber != "")
            {
                _Code.Text = AppResources.AppFunctions.GetNewDocumentNumber(DocumentNumberSeriesCode, LastUsedNumber);
            }
            else
            {
                XtraMessageBox.Show("Encountered an error: The document number series has not been properly configured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppResources.DevexpressFunctions.EnableDisableForm(layoutControl1, true);
            }
        }

        private void btn_save_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dxValidationProviderSavingsAccountType.Validate().Equals(true))
            {
                string Code = _Code.Text;
                string Name = _Name.Text;
                double MinimumOpeningBalance = Convert.ToDouble(_MinimumOpeningBalance.Text.Trim().Replace(",", ""));
                double MinimumMonthlyContributions = Convert.ToDouble(_MinimumMonthlyContributions.Text.Trim().Replace(",",""));
                double MaximumAmountWithdrawableInADay = Convert.ToDouble(_MaximumAmountWithdrawableInADay.Text.Trim().Replace(",",""));
                double WithdrawalCharge = Convert.ToDouble(_WithdrawalCharge.Text.Trim().Replace(",", ""));
                string Description = _Description.Text;

                if (EF.SavingsQueries.CreateSavingsAccountType(Code, Name, MinimumOpeningBalance, MinimumMonthlyContributions, MaximumAmountWithdrawableInADay, WithdrawalCharge, Description, Login.LoggedInUser, DateTime.Now.ToString()))
                {
                    XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    EF.NumberSeriesQueries.UpdateLastUsedNumberSeries(_NumberSeriesCode, Code);
                }
            }
        }

        private void _Code_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}