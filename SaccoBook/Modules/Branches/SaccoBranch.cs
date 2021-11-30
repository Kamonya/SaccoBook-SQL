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

namespace SaccoBook.Modules.Branches
{
    public partial class SaccoBranch : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public SaccoBranch()
        {
            InitializeComponent();
        }

        private void btn_save_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dxValidationProviderSaccoBranch.Validate().Equals(true))
            {
                if (EF.SaccoBranchQueries.CreateBranch(_BranchName.Text, _Location.Text, Login.LoggedInUser, DateTime.Now.ToString()))
                {
                    XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}