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
using SaccoBook.AppResources;
using Newtonsoft.Json;

namespace SaccoBook.Modules.Loans
{
    public partial class LoanRepayment : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        static bool IsEdit = false;
        string _NumberSeriesCode = XMLFormatter.GetContent("RepaymentNumberSeriesCode");
        bool IsDocumentCreated = false;
        bool IsView = false;

        public LoanRepayment()
        {
            InitializeComponent();

            EF.MemberQueries.LoadActiveMembers(_Search, _Search.EditValue.ToString());
        }
        public LoanRepayment(string DocumentNo, bool Edit, bool isView)
        {
            InitializeComponent();            

            EF.MemberQueries.LoadActiveMembers(_Search, _Search.EditValue.ToString());

            IsEdit = Edit;

            string MembershipNumber = LoadLoanRepayment(DocumentNo);

            IsView = isView;

            if (IsView)
            {
                AppResources.DevexpressFunctions.EnableDisableForm(layoutControl1, true);
            }

            LoadMemberInformation(MembershipNumber);
        }
        private string LoadLoanRepayment(string DocumentNo)
        {
            string Loan = EF.LoansQueries.GetLoanRepaymentInfo(DocumentNo);
            dynamic jsonLoanRepayment = JObject.Parse(Loan);

            _DocumentNumber.Text = jsonLoanRepayment.DocumentNumber;

            _ActiveLoans.EditValue = jsonLoanRepayment.LoanId;
            _DateOfRepayment.Text = jsonLoanRepayment.Date;
            _Member.EditValue = jsonLoanRepayment.MembershipNumber;
            _SourceOfPayment.EditValue = jsonLoanRepayment.Source;
            _SourceAccountNumber.EditValue = jsonLoanRepayment.SourceAccountNumber;
            _BankReference.Text = jsonLoanRepayment.BankReference;
            _InstallmentAmount.Text = jsonLoanRepayment.InstallmentAmount;
            _LoanInterest.Text = jsonLoanRepayment.InterestAmount;
            _Status.Text = jsonLoanRepayment.Status;
            
            return jsonLoanRepayment.MembershipNumber; 
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
        private void GetDocumentNumber(string DocumentNumberSeriesCode)
        {
            string _NumberSeriesData = EF.NumberSeriesQueries.GetNumberSeriesInfo(DocumentNumberSeriesCode);

            dynamic responseObject = JObject.Parse(_NumberSeriesData);
            string LastUsedNumber = responseObject.LastUsedNumber;

            if (LastUsedNumber != "")
            {
                _DocumentNumber.Text = AppResources.AppFunctions.GetNewDocumentNumber(DocumentNumberSeriesCode, LastUsedNumber);
                _Status.Text = "Open";
            }
            else
            {
                XtraMessageBox.Show("Encountered an error: The document number series has not been properly configured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                AppResources.DevexpressFunctions.EnableDisableForm(layoutControl1, true);
            }
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

                EF.LoansQueries.LoadMembersActiveLoans(_ActiveLoans, _Search.EditValue.ToString());

                _MembershipNumber.Text = MembershipNumber;
                _Name.Text = jsonGetMemberInfo.Name;               
                _NationalIdNumber.Text = jsonGetMemberInfo.NationalIdNumber;
                _DateJoined.Text = jsonGetMemberInfo.DateJoined.ToString();
                _MembershipStatus.Text = jsonGetMemberInfo.MembershipStatus;

                SplashScreenManager.CloseForm();
            }
        }

        private void _ActiveLoans_EditValueChanged(object sender, EventArgs e)
        {
            //Load loan information

            if(_ActiveLoans.EditValue != null) 
            {
                //Get Document Number

                GetDocumentNumber(_NumberSeriesCode);


                string Loan = EF.LoansQueries.GetLoanInfo(_ActiveLoans.EditValue.ToString());
                dynamic jsonLoan = JObject.Parse(Loan);

                string LoanAwardDate = "", LoanRepaymentDeadlineDate = "", InterestCalculationType = "";
                double InterestRate = 0, LoanAmount = 0, RepaymentPeriodInMonths = 0, Balance = 0;

                InterestRate = jsonLoan.InterestRate;
                LoanAmount = jsonLoan.LoanAmount;
                LoanAwardDate = jsonLoan.LoanAwardDate;
                LoanRepaymentDeadlineDate = jsonLoan.LoanRepaymentDeadlineDate;
                RepaymentPeriodInMonths = jsonLoan.RepaymentPeriodInMonths;
                Balance = jsonLoan.Balance;
                InterestCalculationType = jsonLoan.InterestCalculationType;

                _InterestCalculationType.Text = InterestCalculationType;
                _InterestRate.Text = InterestRate.ToString();
                _LoanAwardDate.Text = LoanAwardDate;
                _RepaymentPeriodInMonths.Text = RepaymentPeriodInMonths.ToString();
                _LoanRepaymentDeadlineDate.Text = LoanRepaymentDeadlineDate;
                _LoanAmount.Text = LoanAmount.ToString();
                _LoanBalance.Text = Balance.ToString();

                //Calculate Loan Repayment 

                //For standard Loan Calculation Formulas

                string LoanRepaymentInfo = AppResources.LoanCalculation.CalculateRepayment(InterestCalculationType, LoanAmount, Balance, InterestRate, RepaymentPeriodInMonths);
                dynamic jsonLoanRepaymentInfo = JObject.Parse(LoanRepaymentInfo);
                _InstallmentRepaymentAmount.Text = jsonLoanRepaymentInfo.InstallRepaymentAmount;
                _LoanInterest.Text = jsonLoanRepaymentInfo.LoanInterest;
                _InstallmentAmount.Text = jsonLoanRepaymentInfo.InstallmentAmount;
            }            
        }

        private void btn_addattachment_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_ActiveLoans.EditValue != null && _Status.Text == "Open")
            {
                AddAttachment _AddAttachment = new AddAttachment(_ActiveLoans.EditValue.ToString());
                _AddAttachment.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Encountered an error: You must select the loan type first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_viewattachments_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_ActiveLoans.EditValue != null)
            {
                Attachments _Attachments = new Attachments(_ActiveLoans.EditValue.ToString());
                _Attachments.ShowDialog();
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
                string InstallmentAmount = _InstallmentAmount.Text;
                string LoanInterest = _LoanInterest.Text;

                InstallmentAmount = InstallmentAmount.Replace(",", "");
                LoanInterest = LoanInterest.Replace(",", "");

                if (EF.LoansQueries.UpdateRepayment(_DocumentNumber.Text, _ActiveLoans.EditValue.ToString(), _DateOfRepayment.Text, _Member.EditValue.ToString(), _SourceOfPayment.EditValue.ToString(), _SourceAccountNumber.EditValue.ToString(), _SourceAccountNumber.EditValue.ToString(), _BankReference.Text, _BankReference.Text, InstallmentAmount, LoanInterest, _Status.Text, Login.LoggedInUser, Login.LoggedInUser, DateTime.Now.ToString()))
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
                string InstallmentAmount = _InstallmentAmount.Text;
                string LoanInterest = _LoanInterest.Text;

                InstallmentAmount = InstallmentAmount.Replace(",", "");
                LoanInterest = LoanInterest.Replace(",", "");

                if (EF.LoansQueries.CreateRepayment(_DocumentNumber.Text, _ActiveLoans.EditValue.ToString(), _DateOfRepayment.Text, _Member.EditValue.ToString(), _SourceOfPayment.EditValue.ToString(),_SourceAccountNumber.EditValue.ToString(), _SourceAccountNumber.EditValue.ToString(), _BankReference.Text, _BankReference.Text, InstallmentAmount, LoanInterest, _Status.Text, Login.LoggedInUser, Login.LoggedInUser, DateTime.Now.ToString()))
                {
                    EF.NumberSeriesQueries.UpdateLastUsedNumberSeries(_NumberSeriesCode, _DocumentNumber.Text);

                    IsDocumentCreated = true;

                    status = true;
                }
            }

            return status;
        }

        private void btn_sendapprovalrequest_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsEdit)
            {
                if (update())
                {
                    //send approval request
                    if (_Status.Text == "Open")
                    {
                        if (SendApprovalRequest(_DocumentNumber.Text))
                        {
                            _Status.Text = "Pending Approval";

                            XtraMessageBox.Show("Information has been successfully saved and an approval request sent to the approver", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Encountered an error: The record has already been sent for Approval", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (!IsDocumentCreated)
                {
                    if (save())
                    {
                        if (_Status.Text == "Open")
                        {
                            if (SendApprovalRequest(_DocumentNumber.Text))
                            {
                                _Status.Text = "Pending Approval";

                                XtraMessageBox.Show("Information has been successfully saved and an approval request sent to the approver", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            _Status.Text = "Pending Approval";

                            XtraMessageBox.Show("Encountered an error: The record has already been sent for Approval", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    if (update())
                    {
                        //send approval request
                        if (_Status.Text == "Open")
                        {
                            if (SendApprovalRequest(_DocumentNumber.Text))
                            {
                                _Status.Text = "Pending Approval";

                                XtraMessageBox.Show("Information has been successfully saved and an approval request sent to the approver", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Encountered an error: The record has already been sent for Approval", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }                
            }
        }
        public static bool SendApprovalRequest(string ApprovalDocumentNumber)
        {
            bool status = false;
            //Created,Open,Canceled,Rejected,Approved

            //send for approval

            if (AppResources.MakerChecker.SendApprovalRequest("Repayments", ApprovalDocumentNumber, "[saccobook].[memberloanrepayments]"))
            {
                status = true;
            }
            return status;
        }

        private void _SourceOfPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_SourceOfPayment.Text == "From Cash")
            {
                _Member.Enabled = false;
                _SourceAccountNumber.Enabled = false;
                _BankReference.Enabled = false;
            }
            else if (_SourceOfPayment.Text == "From Bank")
            {
                _Member.Enabled = false;
                _SourceAccountNumber.Enabled = false;
                _BankReference.Enabled = true;
            }
            else if (_SourceOfPayment.Text == "From Members Own Savings Account")
            {
                _Member.Enabled = false;
                _SourceAccountNumber.Enabled = true;
                _BankReference.Enabled = false;
                EF.SavingsQueries.LoadMembersActiveAccounts(_SourceAccountNumber, _Search.EditValue.ToString());
            }
            else if (_SourceOfPayment.Text == "From Other Members Savings Account")
            {
                _Member.Enabled = true;
                _SourceAccountNumber.Enabled = true;
                _BankReference.Enabled = false;
                EF.MemberQueries.LoadMembers(_Member, _Search.EditValue.ToString());
            }
        }
    }
}