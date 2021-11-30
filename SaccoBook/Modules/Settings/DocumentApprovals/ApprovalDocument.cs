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

namespace SaccoBook.Modules.Settings.DocumentApprovals
{
    public partial class ApprovalDocument : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ApprovalDocument()
        {
            InitializeComponent();
        }

        private void btn_save_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dxValidationProvider_ApprovalDocument.Validate().Equals(true))
            {
                string DocumentType = _Document.Text.Trim();
                string ApprovalSequences = _ApprovalSequences.Text.Trim();
                ApprovalSequences = ApprovalSequences.Replace(".", "");
                string LastModifiedBy = Login.LoggedInUser;
                string LastModifiedAt = DateTime.Now.ToString();


                if (EF.DocumentApprovalsQueries.CreateApprovalDocument( DocumentType,  ApprovalSequences,  LastModifiedBy,  LastModifiedAt))
                {
                    XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}