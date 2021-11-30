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
using DevExpress.XtraSplashScreen;
using DevExpress.XtraEditors;

namespace SaccoBook.Modules.SavingsWithdrawals
{
    public partial class ViewSavingsWithdrawals : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string DocumentNumber = null;
        string Status = null;
        string DocumentType = null;

        public ViewSavingsWithdrawals()
        {
            InitializeComponent();
        }
        public ViewSavingsWithdrawals(string status, string documentType)
        { 
            InitializeComponent();

            Status = status;

            DocumentType = documentType;

            if(status != "Open")
            {
                btn_sendApproval.Enabled = false;
            }

            string sqlSavings = EF.SavingsQueries.LoadOpenSavingsWithdrawalsRecords(status, documentType);

            AppResources.AppFunctions.LoadTable(gridControlViewSavings, gridViewViewSavings, sqlSavings);
        }

        private void gridViewViewSavings_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DocumentType = AppResources.DevexpressFunctions.GetItemrowClick(gridViewViewSavings, "TransactionType");
            DocumentNumber = AppResources.DevexpressFunctions.GetItemrowClick(gridViewViewSavings, "DocumentNumber");
        }

        private void gridViewViewSavings_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DocumentType = AppResources.DevexpressFunctions.GetItemFocusedRowChanged(gridViewViewSavings, sender, e, "TransactionType");
            DocumentNumber = AppResources.DevexpressFunctions.GetItemFocusedRowChanged(gridViewViewSavings, sender, e, "DocumentNumber");
        }

        private void btn_view_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (DocumentType == "Saving")
            {
                Savings.MakeSaving _MakeSaving = new Savings.MakeSaving(DocumentNumber);
                _MakeSaving.ShowDialog();
            }
            else if (DocumentType == "Withdrawal")
            {
                Withdrawal.MakeWithdrawal _MakeWithdrawal = new Withdrawal.MakeWithdrawal(DocumentNumber);
                _MakeWithdrawal.ShowDialog();
            }
        }
        private bool SendApprovalRequest(string ApprovalDocumentNumber, string DocumentType)
        {
            bool status = false;
            //Created,Open,Canceled,Rejected,Approved

            //send for approval

            if (DocumentType == "Saving")
            {
                if (AppResources.MakerChecker.SendApprovalRequest("Savings", ApprovalDocumentNumber, "[saccobook].[membersavings]"))
                {
                    status = true;
                }
            }
            else if (DocumentType == "Withdrawal")
            {
                if (AppResources.MakerChecker.SendApprovalRequest("Withdrawal", ApprovalDocumentNumber, "[saccobook].[membersavings]"))
                {
                    status = true;
                }
            }

            
            return status;
        }

        private void btn_sendApproval_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (SendApprovalRequest(DocumentNumber, DocumentType))
            {
                XtraMessageBox.Show("An approval request was sent to the approver", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                string sqlSavings = EF.SavingsQueries.LoadOpenSavingsRecords(Status, DocumentType);

                AppResources.AppFunctions.LoadTable(gridControlViewSavings, gridViewViewSavings, sqlSavings);
            }
        }

        private void btn_edit_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btn_refresh_ItemClick(object sender, ItemClickEventArgs e)
        {

            SplashScreenManager.ShowForm(this, typeof(AppWaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Please wait");
            SplashScreenManager.Default.SetWaitFormDescription("Refreshing...");   
            string sqlSavings = EF.SavingsQueries.LoadOpenSavingsRecords(Status, DocumentType);
            AppResources.AppFunctions.LoadTable(gridControlViewSavings, gridViewViewSavings, sqlSavings);

            SplashScreenManager.CloseForm();
        }
    }
}