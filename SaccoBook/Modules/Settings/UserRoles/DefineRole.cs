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

namespace SaccoBook.Modules.Settings.UserRoles
{
    public partial class DefineRole : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DefineRole()
        {
            InitializeComponent();
            LoadRoles();
        }

        private void LoadRoles()
        {
            string sqlUserRolesList = EF.UserRoleQueries.GetUSerRoles();

            AppResources.AppFunctions.LoadTable(gridControl1, gridView1, sqlUserRolesList);
        }

        private void btn_newRole_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateRole _CreateRole = new CreateRole();
            _CreateRole.ShowDialog();
        }
    }
}