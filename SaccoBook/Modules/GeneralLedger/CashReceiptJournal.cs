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

namespace SaccoBook.Modules.GeneralLedger
{
    public partial class CashReceiptJournal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private bool IsEdit = false;
        public CashReceiptJournal()
        {
            InitializeComponent();
        }

        private void btn_journal_line_ItemClick(object sender, ItemClickEventArgs e)
        {
            CashReceiptJournalLine _CashReceiptJournalLine = new CashReceiptJournalLine();
            _CashReceiptJournalLine.ShowDialog();
        }

        private void btn_sendforapproval_ItemClick(object sender, ItemClickEventArgs e)
        {
            //if (IsEdit)
            //{
            //    if (update())
            //    {
            //        //send approval request
            //        if (_Status.Text == "Open")
            //        {
            //            if (SendApprovalRequest(_DocumentNumber.Text))
            //            {
            //               // _Status.Text = "Pending Approval";

            //                XtraMessageBox.Show("Information has been successfully saved and an approval request sent to the approver", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //        }
            //        else
            //        {
            //            XtraMessageBox.Show("Encountered an error: The record has already been sent for Approval", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
            //else
            //{
            //    if (!IsDocumentCreated)
            //    {
            //        if (save())
            //        {
            //            if (_Status.Text == "Open")
            //            {
            //                if (SendApprovalRequest(_DocumentNumber.Text))
            //                {
            //                    _Status.Text = "Pending Approval";

            //                    XtraMessageBox.Show("Information has been successfully saved and an approval request sent to the approver", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                }
            //            }
            //            else
            //            {
            //                XtraMessageBox.Show("Encountered an error: The record has already been sent for Approval", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //    }
            //    else
            //    {
            //        if (update())
            //        {
            //            //send approval request
            //            if (_Status.Text == "Open")
            //            {
            //                if (SendApprovalRequest(_DocumentNumber.Text))
            //                {
            //                    _Status.Text = "Pending Approval";

            //                    XtraMessageBox.Show("Information has been successfully saved and an approval request sent to the approver", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                }
            //            }
            //            else
            //            {
            //                XtraMessageBox.Show("Encountered an error: The record has already been sent for Approval", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //    }

            //}
        }
    }
}