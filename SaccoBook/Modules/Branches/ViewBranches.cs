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

namespace SaccoBook.Modules.Branches
{
    public partial class ViewBranches : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ViewBranches()
        {
            InitializeComponent();
            LoadBranches();
        }

        private void LoadBranches()
        {
            string sql = "select \"saccobook.branches\".\"Id\", \"saccobook.branches\".\"BranchName\", \"saccobook.branches\".\"Location\", \"saccobook.branches\".\"LastModifiedBy\", \"saccobook.branches\".\"LastModifiedAt\" from \"saccobook\".\"branches\" \"saccobook.branches\"";

            AppResources.AppFunctions.LoadTable(gridControl1, gridView1, sql);
        }

        private void btn_newbranch_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaccoBranch _SaccoBranch = new SaccoBranch();
            _SaccoBranch.ShowDialog();
        }
    }
}