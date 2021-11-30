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
using DevExpress.XtraSplashScreen;

namespace SaccoBook.Modules.SaccoMembers.BankAccounts
{
    public partial class ViewBankAccounts : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        static string MembershipNumber = null;
        static string _BankAccountNumber = null;
        public ViewBankAccounts()
        {
            InitializeComponent();
        }
        public ViewBankAccounts(string _MembershipNumber)
        {
            InitializeComponent();
            MembershipNumber = _MembershipNumber;
            BankAccountGridControl.DataSource = EF.BankQueries.GetBankAccountsList(_MembershipNumber);
        }

        private void btn_addbankaccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            BankAccount _BankAccount = new BankAccount();
            _BankAccount.ShowDialog();
        }

        private void btn_edit_ItemClick(object sender, ItemClickEventArgs e)
        {
            BankAccount _BankAccount = new BankAccount(MembershipNumber, _BankAccountNumber, true);
            _BankAccount.ShowDialog();
        }

        private void BankAccountGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _BankAccountNumber = AppResources.DevexpressFunctions.GetItemFocusedRowChanged(BankAccountGridView, sender, e, "AccountNumber");
        }

        private void BankAccountGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            _BankAccountNumber = AppResources.DevexpressFunctions.GetItemrowClick(BankAccountGridView, "AccountNumber");
        }

        private void btn_delete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dlr = XtraMessageBox.Show("Are you sure you want to delete record?", "System Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlr == DialogResult.Yes)
            {
                if (EF.BankQueries.DeleteBankAccount(MembershipNumber, _BankAccountNumber))
                {
                    XtraMessageBox.Show("The specified record has been successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_refresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(AppWaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Please wait");
            SplashScreenManager.Default.SetWaitFormDescription("Refreshing...");
            BankAccountGridControl.DataSource = EF.BankQueries.GetBankAccountsList(MembershipNumber);
            SplashScreenManager.CloseForm();
        }
    }
}