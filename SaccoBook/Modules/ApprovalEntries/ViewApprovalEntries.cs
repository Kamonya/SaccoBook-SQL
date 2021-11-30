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

namespace SaccoBook.Modules.ApprovalEntries
{
    public partial class ViewApprovalEntries : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string EntryNumber = null;
        string SequenceNumber = null;
        string DocumentType = null;
        string DocumentNumber = null;
        string Status = null;
        public ViewApprovalEntries()
        {
            InitializeComponent();
        }
        public ViewApprovalEntries(string status, string Title)
        {
            InitializeComponent();

            if(status != "Open")
            {
                btn_approve.Enabled = false;
                btn_delegate.Enabled = false;
                btn_reject.Enabled = false;
            }

            Status = status;

            this.Text = Title;

            LoadTable(status);
        }

        private void LoadTable(string status)
        {
            string sql = EF.ApprovalEntriesQueries.LoadApprovalEntries(status);

            AppResources.AppFunctions.LoadTable(GridControlApprovalEntries, GridViewApprovalEntries, sql);
        }

        private void btn_approve_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dlr = XtraMessageBox.Show("Go on and approve?", "System Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlr == DialogResult.Yes)
            {
                if (DocumentType == "Savings")
                {
                    if (AppResources.MakerChecker.ApproveAppovalRequest(Convert.ToInt16(EntryNumber), Convert.ToInt16(SequenceNumber), DocumentType, DocumentNumber, "[saccobook].[membersavings]"))
                    {
                        int PendingApprovals = EF.ApprovalEntriesQueries.GetNumberOfPendingApprovers(DocumentType, DocumentNumber);

                        if (PendingApprovals == 0)
                        {
                            ProcessSavings();
                        }
                        else
                        {
                            XtraMessageBox.Show("The approval request was successfully approved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Failed to approve", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if (DocumentType == "Withdrawal")
                {

                    if (AppResources.MakerChecker.ApproveAppovalRequest(Convert.ToInt16(EntryNumber), Convert.ToInt16(SequenceNumber), DocumentType, DocumentNumber, "[saccobook].[membersavings]"))
                    {
                        int PendingApprovals = EF.ApprovalEntriesQueries.GetNumberOfPendingApprovers(DocumentType, DocumentNumber);

                        if (PendingApprovals == 0)
                        {
                             ProcessWithdrawals();
                        }
                        else
                        {
                            XtraMessageBox.Show("The approval request was successfully approved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Failed to approve", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if (DocumentType == "Loans")
                {
                    int PendingApprovals = EF.ApprovalEntriesQueries.GetNumberOfPendingApprovers(DocumentType, DocumentNumber);

                    if (AppResources.MakerChecker.ApproveAppovalRequest(Convert.ToInt16(EntryNumber), Convert.ToInt16(SequenceNumber), DocumentType, DocumentNumber, "[saccobook].[memberloans]"))
                    {

                        if (PendingApprovals == 0)
                        {
                            ProcessLoan();                           
                        }
                        else
                        {
                            XtraMessageBox.Show("The approval request was successfully approved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Failed to approve", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if (DocumentType == "Repayments")
                {
                    int PendingApprovals = EF.ApprovalEntriesQueries.GetNumberOfPendingApprovers(DocumentType, DocumentNumber);

                    if (AppResources.MakerChecker.ApproveAppovalRequest(Convert.ToInt16(EntryNumber), Convert.ToInt16(SequenceNumber), DocumentType, DocumentNumber, "[saccobook].[memberloans]"))
                    {

                        if (PendingApprovals == 0)
                        {
                            ProcessLoanRepayment();
                        }
                        else
                        {
                            XtraMessageBox.Show("The approval request was successfully approved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Failed to approve", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            

            LoadTable(Status);
        }

        private void ProcessLoanRepayment()
        {
            //Get Amount repaid, Interest Paid

            //Get Loan Repayment Details
            string Loan = EF.LoansQueries.GetLoanRepaymentInfo(DocumentNumber);
            dynamic jsonLoanRepayment = JObject.Parse(Loan);

            double InstallmentAmount = 0, InterestAmount = 0;
            InstallmentAmount = jsonLoanRepayment.InstallmentAmount;
            InterestAmount = jsonLoanRepayment.InterestAmount;
            string LoanId = jsonLoanRepayment.LoanId;

            //Process Loan Interest

            //Process Amount Repaid  
            if (EF.LoansQueries.CommitLoanRepayment(DocumentNumber, LoanId, InstallmentAmount))
            {
                XtraMessageBox.Show("The approval request was successfully approved and loan repaid", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Failed to commit changes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ProcessLoan()
        {
            //Update loan balance to Amount Awarded

            //Get Loan Details
            string Loan = EF.LoansQueries.GetLoanInfo(DocumentNumber);
            dynamic jsonLoan = JObject.Parse(Loan);

            double LoanAmount = 0;            
            LoanAmount = jsonLoan.LoanAmount;

            if (EF.LoansQueries.CommitLoan(DocumentNumber, LoanAmount))
            {
                XtraMessageBox.Show("The approval request was successfully approved and loan granted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Failed to commit changes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void ProcessSavings()
        {
            //commit changes to Accounts here bc its the lasty approver in the chain

            //Get Savings Record Information from DocumentNumber
            string SavingsLine = EF.SavingsQueries.GetSavingInfo(DocumentNumber);

            dynamic jsonSavingsLine = JObject.Parse(SavingsLine);

            string AccountNumber = jsonSavingsLine.DestinationAccount;
            double DepositAmount = jsonSavingsLine.CreditAmount;

            if (EF.SavingsQueries.CommitSavings(AccountNumber, DepositAmount))
            {
                string MemberRegistrationSetting = EF.NotificationTemplatesQueries.GetNotificationSettingInfo("REQUESTDOCUMENTAPPROVAL");

                dynamic GetNotificationSettingInfoResponseObject = JObject.Parse(MemberRegistrationSetting);

                string NotificationTemplateId = GetNotificationSettingInfoResponseObject.NotificationTemplateId;

                bool NotificationsEnabled = GetNotificationSettingInfoResponseObject.NotificationsEnabled;

                if (NotificationsEnabled)
                {
                    //EF.NotificationTemplatesQueries.QueueNotification(NotificationTemplateId, "", ApproverName, "", "", "", "", "", "", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToShortTimeString(), ApproverEmail, _DocumentType + " Approval");
                }

                XtraMessageBox.Show("The approval request was successfully approved and savings were committed to the member's account", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                XtraMessageBox.Show("Failed to commit changes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcessWithdrawals()
        {
            //commit changes to Accounts here bc its the lasty approver in the chain

            //Get Savings Record Information from DocumentNumber
            string SavingsLine = EF.SavingsQueries.GetSavingInfo(DocumentNumber);

            dynamic jsonSavingsLine = JObject.Parse(SavingsLine);

            string SourceAccount = jsonSavingsLine.SourceAccount;
            double WithdrawalAmount = jsonSavingsLine.DebitAmount;

            if (EF.SavingsQueries.CommitWithdrawals(SourceAccount, WithdrawalAmount))
            {

                string MemberRegistrationSetting = EF.NotificationTemplatesQueries.GetNotificationSettingInfo("WITHDRAWALSAPPROVAL");

                dynamic GetNotificationSettingInfoResponseObject = JObject.Parse(MemberRegistrationSetting);

                string NotificationTemplateId = GetNotificationSettingInfoResponseObject.NotificationTemplateId;

                bool NotificationsEnabled = GetNotificationSettingInfoResponseObject.NotificationsEnabled;

                if (NotificationsEnabled)
                {
                    //EF.NotificationTemplatesQueries.QueueNotification(NotificationTemplateId, "", ApproverName, "", "", "", "", "", "", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToShortTimeString(), ApproverEmail, _DocumentType + " Approval");
                }

                XtraMessageBox.Show("The approval request was successfully approved and funds were debited to the member's account", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Failed to commit changes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_reject_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (DocumentType == "Savings")
            {
                if (AppResources.MakerChecker.RejectAppovalRequest(DocumentType, DocumentNumber))
                {
                    XtraMessageBox.Show("The approval request was successfully rejected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LoadTable(Status);
        }

        private void btn_delegate_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (AppResources.MakerChecker.DelegateAppovalRequest(Convert.ToInt16(EntryNumber), DocumentType, SequenceNumber))
            {
                XtraMessageBox.Show("The approval request was successfully delegated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadTable(Status);
        }

        private void btn_view_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (DocumentType == "Savings")
            {
                SavingsWithdrawals.Savings.MakeSaving _MakeSaving = new SavingsWithdrawals.Savings.MakeSaving(DocumentNumber);
                _MakeSaving.ShowDialog();
            }
            else if (DocumentType == "Withdrawal")
            {
                SavingsWithdrawals.Withdrawal.MakeWithdrawal _MakeWithdrawal = new SavingsWithdrawals.Withdrawal.MakeWithdrawal(DocumentNumber);
                _MakeWithdrawal.ShowDialog();
            }
            else if (DocumentType == "Loans")
            {
                Loans.LoanDisbursement _LoanDisbursement = new Loans.LoanDisbursement(DocumentNumber, false, true);
                _LoanDisbursement.ShowDialog();
            }
            else if (DocumentType == "Repayments")
            {
                Loans.LoanRepayment _LoanRepayment = new Loans.LoanRepayment(DocumentNumber, false, true);
                _LoanRepayment.ShowDialog();
            }
        }

        private void GridViewApprovalEntries_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            EntryNumber = AppResources.DevexpressFunctions.GetItemFocusedRowChanged(GridViewApprovalEntries, sender, e, "EntryNumber"); 
            SequenceNumber = AppResources.DevexpressFunctions.GetItemFocusedRowChanged(GridViewApprovalEntries, sender, e, "SequenceNumber"); 
            DocumentType = AppResources.DevexpressFunctions.GetItemFocusedRowChanged(GridViewApprovalEntries, sender, e, "DocumentType"); 
            DocumentNumber = AppResources.DevexpressFunctions.GetItemFocusedRowChanged(GridViewApprovalEntries, sender, e, "DocumentNumber");            
        }

        private void GridViewApprovalEntries_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           
            EntryNumber = AppResources.DevexpressFunctions.GetItemrowClick(GridViewApprovalEntries, "EntryNumber");
            SequenceNumber = AppResources.DevexpressFunctions.GetItemrowClick(GridViewApprovalEntries, "SequenceNumber");
            DocumentType = AppResources.DevexpressFunctions.GetItemrowClick(GridViewApprovalEntries, "DocumentType");
            DocumentNumber = AppResources.DevexpressFunctions.GetItemrowClick(GridViewApprovalEntries, "DocumentNumber");
        }
    }
}