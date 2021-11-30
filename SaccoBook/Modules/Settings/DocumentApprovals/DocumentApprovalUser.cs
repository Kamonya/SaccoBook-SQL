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
    public partial class DocumentApprovalUser : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DocumentApprovalUser()
        {
            InitializeComponent();
            FillCombo();
        }       

        public DocumentApprovalUser(string Document)
        {
            InitializeComponent();
            FillCombo();
        }
        private void FillCombo()
        {
            LoadComboEdit(_Approver, EF.SystemUserQueries.GetActiveSystemUserList());
            LoadComboEdit(_ApprovalSubstitute, EF.SystemUserQueries.GetActiveSystemUserList());
            LoadComboEdit(_Document, EF.DocumentApprovalsQueries.GetApprovalDocumentList());
        }
        private void LoadComboEdit(ComboBoxEdit combo, string[] list)
        {
            combo.Properties.Items.Clear();

            foreach (var item in list)
            {
                combo.Properties.Items.Add(item);
            }
        }
        private void btn_save_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dxValidationProvider_DocumentApprovalUser.Validate().Equals(true))
            {
                if (EF.DocumentApprovalsQueries.CreateApprovalUser(_Document.Text, _Approver.Text, _ApprovalSequence.Text, _ApproverEmail.Text, _ApprovalSubstitute.Text, _ApprovalSubstituteEmail.Text, Login.LoggedInUser, DateTime.Now.ToString()))
                {
                    XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void _Document_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_Document.Text != "")
            {
                LoadComboEdit(_ApprovalSequence, EF.DocumentApprovalsQueries.GetApprovalSequenceList(_Document.Text));
            }            
        }
    }
}