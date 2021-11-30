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

namespace SaccoBook.Modules.SystemUsers
{
    public partial class ViewSystemUsers : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ViewSystemUsers()
        {
            InitializeComponent();
            LoadUserList();
        }
        private void LoadUserList()
        {
            string sqlUsersList = EF.SystemUserQueries.GetSystemUsers();

            AppResources.AppFunctions.LoadTable(gridControl1, gridView1, sqlUsersList);
        }

        private void btn_adduser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SystemUser _SystemUser = new SystemUser();
            _SystemUser.ShowDialog();
        }

        private void btn_definerole_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Settings.UserRoles.DefineRole _DefineRole = new Settings.UserRoles.DefineRole();
            _DefineRole.ShowDialog();
        }
    }
}