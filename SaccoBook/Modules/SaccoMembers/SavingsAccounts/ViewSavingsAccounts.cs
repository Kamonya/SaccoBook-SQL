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
using DevExpress.XtraSplashScreen;

namespace SaccoBook.Modules.SaccoMembers.SavingsAccounts
{
    public partial class ViewSavingsAccounts : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        static string _MembershipNumber = null;
        static string _AccountNumber = null;
        public ViewSavingsAccounts()
        {
            InitializeComponent();
        }
        public ViewSavingsAccounts(string MembershipNumber)
        {
            InitializeComponent();
            _MembershipNumber = MembershipNumber;

            string MemberSavingsAccounts = EF.SavingsQueries.GetMemberSavingsAccountsList(MembershipNumber);
            AppResources.AppFunctions.LoadTable(SavingsAccountsGridControl, SavingsAccountsGridView, MemberSavingsAccounts);
        }

        private void btn_newaccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            MemberSavingsAccount _MemberSavingsAccount = new MemberSavingsAccount(_MembershipNumber);
            _MemberSavingsAccount.ShowDialog();

        }

        private void btn_edit_ItemClick(object sender, ItemClickEventArgs e)
        {
            MemberSavingsAccount _MemberSavingsAccount = new MemberSavingsAccount(_MembershipNumber, _AccountNumber, true);
            _MemberSavingsAccount.ShowDialog();
        }

        private void SavingsAccountsGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            _AccountNumber = AppResources.DevexpressFunctions.GetItemrowClick(SavingsAccountsGridView, "AccountNumber");
        }

        private void SavingsAccountsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _AccountNumber = AppResources.DevexpressFunctions.GetItemFocusedRowChanged(SavingsAccountsGridView, sender, e, "AccountNumber");
        }

        private void btn_refresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(AppWaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Please wait");
            SplashScreenManager.Default.SetWaitFormDescription("Refreshing...");         
            string MemberSavingsAccounts = EF.SavingsQueries.GetMemberSavingsAccountsList(_MembershipNumber);
            AppResources.AppFunctions.LoadTable(SavingsAccountsGridControl, SavingsAccountsGridView, MemberSavingsAccounts);
            SplashScreenManager.CloseForm();
        }
    }
}