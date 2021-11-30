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
    public partial class CreateSystemUser : DevExpress.XtraEditors.XtraForm
    {
        public CreateSystemUser()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate().Equals(true))
            {
                //is there users?
                if (EF.SystemUserQueries.CountUsers() < 1)
                {
                    if (EF.SystemUserQueries.CreateUser(_Username.Text, "ADMIN", "ADMIN", _FirstName.Text, _LastName.Text, _Password.Text, _IdNumber.Text, _PhoneNumber.Text, "1", DateTime.Now.ToString()))
                    {
                        XtraMessageBox.Show("System user information has been successfully saved. You need to restart the application to effect changes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (EF.SystemUserQueries.CreateUser(_Username.Text, "ADMIN", "ADMIN", _FirstName.Text, _LastName.Text, _Password.Text, _IdNumber.Text, _PhoneNumber.Text, Login.LoggedInUser, DateTime.Now.ToString()))
                    {
                        XtraMessageBox.Show("System user information has been successfully saved. You need to restart the application to effect changes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                    
            }
        }
    }
}