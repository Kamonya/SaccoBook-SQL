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

namespace SaccoBook.Modules.SystemUsers
{
    public partial class SystemUser : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public SystemUser()
        {
            InitializeComponent();
            EF.UserRoleQueries.LoadRoles(_Roles);
            _Roles.Properties.ValueMember = "RoleId";
            _Roles.Properties.DisplayMember = "RoleId";
        }

        private void btn_save_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dxValidationProvider1.Validate().Equals(true))
            {
                if (EF.SystemUserQueries.CreateUser(_Username.Text, "ADMIN", "ADMIN", _FirstName.Text, _LastName.Text, _Password.Text, _IdNumber.Text, _PhoneNumber.Text, Login.LoggedInUser, DateTime.Now.ToString()))
                {
                    XtraMessageBox.Show("System user information has been successfully saved. You need to restart the application to effect changes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}