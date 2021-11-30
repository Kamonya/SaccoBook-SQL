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
    public partial class CreateRole : DevExpress.XtraEditors.XtraForm
    {
        public CreateRole()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool status = _CanAddBulkSavings.Checked;
            if (EF.UserRoleQueries.CreateUserRole("ADMIN", _CanLogin.Checked, _IsMasterAdmin.Checked, _CanAddUser.Checked,
                _CanAddKin.Checked, _CanViewMemberProfile.Checked, _CanEditUser.Checked, _CanDeleteUser.Checked, _CanAddSavings.Checked,
                _CanAddWithdrawal.Checked, _CanAddBulkSavings.Checked, _CanAddLoan.Checked, _CanAddLoanRepayment.Checked, _CanViewRepaymentHistory.Checked,
                _CanViewLoanGuarantors.Checked, _CanEditLoan.Checked, _CanDeleteLoan.Checked, _CanAddShares.Checked, _CanViewShares.Checked, _CanAddExpenses.Checked,
                _CanEditExpenses.Checked, _CanDeleteExpenses.Checked, "USER", DateTime.Now.ToString()))
            {
                XtraMessageBox.Show("System user role information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}