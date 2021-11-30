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

namespace SaccoBook.Modules.Loans
{
    public partial class ViewLoans : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        static string DocumentType = null;
        static string DocumentNumber = null;
        static string ApprovalStatus = null;
        public ViewLoans()
        {
            InitializeComponent();
           
        }
        public ViewLoans(string status, string title, string Type)
        {
            InitializeComponent();

            this.Text = title; 

            if (status != "Open")
            {
                btn_edit.Enabled = false;
                btn_sendapprovalrequest.Enabled = false;
            }

            DocumentType = Type;

            ApprovalStatus = status;

            LoadLoans(status, Type);
        }

        private void LoadLoans(string status, string Type)
        {
            if (Type == "Disbursement")
            {
                if (status == "Open")
                {
                    string OpenLoanDisbursementEntries = EF.LoansQueries.LoadLoanDisbursementEntries(status);

                    AppResources.AppFunctions.LoadTable(gridControlViewLoans, gridViewViewLoans, OpenLoanDisbursementEntries);
                }
                else if (status == "Approved")
                {
                    string ApprovedLoanDisbursementEntries = EF.LoansQueries.LoadLoanDisbursementEntries(status);

                    AppResources.AppFunctions.LoadTable(gridControlViewLoans, gridViewViewLoans, ApprovedLoanDisbursementEntries);
                }
                else if (status == "Rejected")
                {
                    string RejectedLoanDisbursementEntries = EF.LoansQueries.LoadLoanDisbursementEntries(status);

                    AppResources.AppFunctions.LoadTable(gridControlViewLoans, gridViewViewLoans, RejectedLoanDisbursementEntries);
                }
                else if (status == "Active")
                {
                    string ActiveLoans = EF.LoansQueries.LoadActiveLoans();

                    AppResources.AppFunctions.LoadTable(gridControlViewLoans, gridViewViewLoans, ActiveLoans);
                }
                else if (status == "Defaulted")
                {
                    string DefaultedLoans = EF.LoansQueries.LoadDefaultedLoans();

                    AppResources.AppFunctions.LoadTable(gridControlViewLoans, gridViewViewLoans, DefaultedLoans);
                }
                else if (status == "Settled")
                {
                    string SettledLoans = EF.LoansQueries.LoadSettledLoans();

                    AppResources.AppFunctions.LoadTable(gridControlViewLoans, gridViewViewLoans, SettledLoans);
                }
            }
            else
            {
                //if (status == "Open")
                //{
                //    string OpenLoanRepeymentEntries = EF.LoansQueries.LoadLoanRepaymentEntries(status);

                //    AppResources.AppFunctions.LoadTable(gridControlViewLoans, gridViewViewLoans, OpenLoanRepeymentEntries);
                //}
                //else if (status == "Approved")
                //{
                //    string ApprovedLoanRepeymentEntries = EF.LoansQueries.LoadLoanRepaymentEntries(status);

                //    AppResources.AppFunctions.LoadTable(gridControlViewLoans, gridViewViewLoans, ApprovedLoanRepeymentEntries);
                //}
                //else if (status == "Rejected")
                //{
                //    string RejectedLoanRepeymentEntries = EF.LoansQueries.LoadLoanRepaymentEntries(status);

                //    AppResources.AppFunctions.LoadTable(gridControlViewLoans, gridViewViewLoans, RejectedLoanRepeymentEntries);
                //}
                //else if (status == "Rejected")
                //{
                //    string RejectedLoanRepeymentEntries = EF.LoansQueries.LoadLoanRepaymentEntries(status);

                //    AppResources.AppFunctions.LoadTable(gridControlViewLoans, gridViewViewLoans, RejectedLoanRepeymentEntries);
                //}
                string Entries = EF.LoansQueries.LoadLoanRepaymentEntries(status);
                AppResources.AppFunctions.LoadTable(gridControlViewLoans, gridViewViewLoans, Entries);
            }
        }

        private void btn_sendapprovalrequest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DocumentType == "Disbursement")
            {
                if (LoanDisbursement.SendApprovalRequest(DocumentNumber))
                {
                    XtraMessageBox.Show("An approval request sent to the approver", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadLoans(ApprovalStatus, DocumentType);
                }
            }
            else
            {
                if (LoanRepayment.SendApprovalRequest(DocumentNumber))
                {
                    XtraMessageBox.Show("An approval request sent to the approver", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadLoans(ApprovalStatus, DocumentType);
                }
            }
        }

        private void btn_view_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DocumentType == "Disbursement")
            {
                LoanDisbursement _LoanDisbursement = new LoanDisbursement(DocumentNumber, false, true);
                _LoanDisbursement.ShowDialog();
            }
            else
            {
                LoanRepayment _LoanRepayment = new LoanRepayment(DocumentNumber, false, true);
                _LoanRepayment.ShowDialog();
            }
        }

        private void gridViewViewLoans_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DocumentNumber = AppResources.DevexpressFunctions.GetItemFocusedRowChanged(gridViewViewLoans, sender, e, "DocumentNumber");
        }

        private void gridViewViewLoans_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DocumentNumber = AppResources.DevexpressFunctions.GetItemrowClick(gridViewViewLoans, "DocumentNumber");
        }

        private void btn_edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DocumentType == "Disbursement")
            {
                LoanDisbursement _LoanDisbursement = new LoanDisbursement(DocumentNumber, true, false);
                _LoanDisbursement.ShowDialog();
            }
            else
            {
                LoanRepayment _LoanRepayment = new LoanRepayment(DocumentNumber, true, false);
                _LoanRepayment.ShowDialog();
            }
        }
    }
}