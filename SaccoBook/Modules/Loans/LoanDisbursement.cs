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
using DevExpress.XtraSplashScreen;
using DevExpress.XtraEditors;
using Newtonsoft.Json;

namespace SaccoBook.Modules.Loans
{
    public partial class LoanDisbursement : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        bool IsEdit = false;
        bool IsDocumentCreated = false;
        bool IsView = false;
        string LoanId = null;
        public LoanDisbursement()
        {
            InitializeComponent();
            EF.MemberQueries.LoadActiveMembers(_Search, _Search.EditValue.ToString());
            EF.LoansQueries.LoadLoanProducts(_LoanType);
            btn_addguarantor.Enabled = false;
        }
        public LoanDisbursement(string DocumentNo, bool Edit, bool isView)
        {
            InitializeComponent();
                        
            IsEdit = Edit;

            IsView = isView;

            LoanId = DocumentNo;

            if (IsView)
            {
                AppResources.DevexpressFunctions.EnableDisableForm(layoutControl1, true);
            }            

            string MembershipNumber = LoadLoan(DocumentNo);

            LoadMemberInformation(MembershipNumber);

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
            _Search.EditValue = MembershipNumber;

            try
            {
                SplashScreenManager.CloseForm();
            }
            catch(Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Sacco Book", ex.ToString(),
                                       System.Diagnostics.EventLogEntryType.Warning);
            }
        }
        private string LoadLoan(string DocumentNo)
        {
            string Loan = EF.LoansQueries.GetLoanInfo(DocumentNo);
            dynamic jsonLoan = JObject.Parse(Loan);

            string LoanAwardDate = "", LoanRepaymentDeadlineDate = "", InterestCalculationType = "", MembershipNumber ="", LoanType = "", Status ="";
            double InterestRate = 0, LoanAmount = 0, RepaymentPeriodInMonths = 0, Balance = 0;

            InterestRate = jsonLoan.InterestRate;
            LoanAmount = jsonLoan.LoanAmount;
            LoanAwardDate = jsonLoan.LoanAwardDate;
            LoanRepaymentDeadlineDate = jsonLoan.LoanRepaymentDeadlineDate;
            RepaymentPeriodInMonths = jsonLoan.RepaymentPeriodInMonths;
            Balance = jsonLoan.Balance;
            InterestCalculationType = jsonLoan.InterestCalculationType;
            MembershipNumber = jsonLoan.MembershipNumber;
            LoanType = jsonLoan.LoanType;
            Status = jsonLoan.Status;

            _LoanType.EditValue = LoanType;
            _InterestCalculationType.Text = InterestCalculationType;
            _InterestRate.Text = InterestRate.ToString();
            _LoanAwardDate.Text = LoanAwardDate;
            _RepaymentPeriodInMonths.Text = RepaymentPeriodInMonths.ToString();
            _LoanRepaymentDeadlineDate.Text = LoanRepaymentDeadlineDate;
            _LoanAmount.Text = LoanAmount.ToString();
            _DocumentNumber.Text = DocumentNo;
            _Status.Text = Status;

            LoadLoanType(LoanType);

            return MembershipNumber;
        }

        private void _Search_EditValueChanged(object sender, EventArgs e)
        {
            if (_Search.EditValue != null)
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

        private void _LoanType_EditValueChanged(object sender, EventArgs e)
        {
            if(_LoanType.EditValue != null)
            {
                LoadLoanType(_LoanType.EditValue.ToString());

                if (!IsEdit || !IsView)
                {
                    GetDocumentNumber(_LoanType.EditValue.ToString());
                }               
                
            }
        }

        private void LoadLoanType(string LoanType)
        {
            string CreditProductInfoJSON = EF.LoansQueries.GetCreditProductInfo(LoanType);
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

            _InterestRate.Text = InterestRate;
            _InterestCalculationType.Text = InterestCalculationType;
            _MaximumLoanAmount.Text = MaximumLoanAmount;
            _MaxRepaymentPeriodInMonths.Text = MaxRepaymentPeriodInMonths;
            _MinimumDepositContribution.Text = MinimumDepositContribution;
        }

        private void GetDocumentNumber(string DocumentNumberSeriesCode)
        {
            string _NumberSeriesData = EF.NumberSeriesQueries.GetNumberSeriesInfo(DocumentNumberSeriesCode);

            dynamic responseObject = JObject.Parse(_NumberSeriesData);
            string LastUsedNumber = responseObject.LastUsedNumber;

            if (LastUsedNumber != "")
            {
                string DocumentNo = AppResources.AppFunctions.GetNewDocumentNumber(DocumentNumberSeriesCode, LastUsedNumber);
                LoanId = DocumentNo;
                _DocumentNumber.Text = LoanId;
                _Status.Text = "Open";
            }
            else
            {
                XtraMessageBox.Show("Encountered an error: The document number series has not been properly configured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppResources.DevexpressFunctions.EnableDisableForm(layoutControl1, true);
            }
        }

        private void btn_save_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsEdit)
            {
                if (update())
                {
                    alertControl1.Show(this, "Success!", "Information has been successfully saved");
                    //XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                
            }
            else
            {
                if (!IsDocumentCreated)
                {
                    if (save())
                    {
                        alertControl1.Show(this, "Success!", "Information has been successfully saved");
                        //XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (update())
                    {
                        alertControl1.Show(this, "Success!", "Information has been successfully saved");
                        //XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                                
            }
        }

        private bool update()
        {
            bool status = false;

            if (dxValidationProviderLoanDisbursement.Validate().Equals(true))
            {
                string Amount = _LoanAmount.Text;

                Amount = Amount.Replace(",", "");

                if (EF.LoansQueries.UpdateLoanRecord(_DocumentNumber.Text, _MembershipNumber.Text, _LoanType.Text, _LoanAwardDate.Text, _LoanRepaymentDeadlineDate.Text, _InterestRate.Text, _InterestCalculationType.Text, Amount, _RepaymentPeriodInMonths.Text, _Description.Text, "Open", Login.LoggedInUser, DateTime.Now.ToString()))
                {
                    status = true;
                }
            }
            return status;
        }

        private bool save()
        {
            bool status = false;

            if (dxValidationProviderLoanDisbursement.Validate().Equals(true))
            {
                if (EF.LoansQueries.CreateLoanRecord(_DocumentNumber.Text, _MembershipNumber.Text, 
                    _LoanType.EditValue.ToString(), _LoanAwardDate.Text,
                    _LoanRepaymentDeadlineDate.Text, _InterestRate.Text,
                    _InterestCalculationType.Text, _LoanAmount.Text, 
                    _RepaymentPeriodInMonths.Text, _Description.Text,
                    "Open", Login.LoggedInUser, Login.LoggedInUser, DateTime.Now.ToString()))
                {
                    EF.NumberSeriesQueries.UpdateLastUsedNumberSeries(_LoanType.EditValue.ToString(), _DocumentNumber.Text);

                    IsDocumentCreated = true;

                    status = true;
                }
            }
            return status;
        }
        public static bool SendApprovalRequest(string ApprovalDocumentNumber)
        {
            bool status = false;
            //Created,Open,Canceled,Rejected,Approved

            //send for approval
            if (AppResources.MakerChecker.SendApprovalRequest("Loans", ApprovalDocumentNumber, "[saccobook].[memberloans]"))
            {
                status = true;
            }
            return status;

        }

        private void btn_sendapprovalrequest_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void btn_addattachments_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(_DocumentNumber.Text != "" && _Status.Text == "Open")
            {
                AddAttachment _AddAttachment = new AddAttachment(_DocumentNumber.Text);
                _AddAttachment.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Encountered an error: You must select the loan type first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);           
            }            
        }

        private void btn_viewattachments_ItemClick(object sender, ItemClickEventArgs e)
        {
            Attachments _Attachments = new Attachments(_DocumentNumber.Text);
            _Attachments.ShowDialog();
        }

        private void _RepaymentPeriodInMonths_EditValueChanged(object sender, EventArgs e)
        {
            if(_LoanAwardDate.Text != "")
            {
                if (_RepaymentPeriodInMonths.Text != "")
                {
                    string NoOfMonths = _RepaymentPeriodInMonths.Text.Replace(",", "");
                    int Months = Convert.ToInt32(NoOfMonths);

                    DateTime AwardDate = Convert.ToDateTime(_LoanAwardDate.Text);
                    DateTime NextRepaymentDate = AwardDate.AddMonths(Months);

                    _LoanRepaymentDeadlineDate.Text = NextRepaymentDate.ToString();
                }
            }
        }

        private void btn_addguarantor_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoanGuarantors _LoanGuarantors = new LoanGuarantors(LoanId);
            _LoanGuarantors.ShowDialog();
        }
    }
}