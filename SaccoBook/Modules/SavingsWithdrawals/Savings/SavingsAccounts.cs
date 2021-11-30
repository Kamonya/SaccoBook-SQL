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

namespace SaccoBook.Modules.SavingsWithdrawals.Savings
{
    public partial class SavingsAccounts : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        static string AccountNumber = null;
        public SavingsAccounts()
        {
            InitializeComponent();
            LoadTable();
        }

        private void LoadTable()
        {
            string sqlAccounts = EF.SavingsQueries.LoadSavingsAccountBalances();

            AppResources.AppFunctions.LoadTable(GridControlSavingsAccounts, GridViewSavingsAccounts, sqlAccounts);
        }

        private void btn_savings_account_ItemClick(object sender, ItemClickEventArgs e)
        {
            SavingsAccount _SavingsAccount = new SavingsAccount();
            _SavingsAccount.ShowDialog();
        }

        private void btn_refresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(AppWaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Please wait");
            SplashScreenManager.Default.SetWaitFormDescription("Refreshing...");
            string sqlMembers = EF.MemberQueries.LoadMembersRecords();
            LoadTable();
            SplashScreenManager.CloseForm();
           
        }

        private void btn_savingsstatement_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(AccountNumber != null)
            {
                SavingsStatement _SavingsStatement = new SavingsStatement(AccountNumber);
                _SavingsStatement.ShowDialog();
            }            
        }

        private void GridViewSavingsAccounts_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            AccountNumber = AppResources.DevexpressFunctions.GetItemrowClick(GridViewSavingsAccounts, "AccountNumber");
        }

        private void GridViewSavingsAccounts_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            AccountNumber = AppResources.DevexpressFunctions.GetItemFocusedRowChanged(GridViewSavingsAccounts, sender, e, "AccountNumber");
        }

        private void GridViewSavingsAccounts_DoubleClick(object sender, EventArgs e)
        {
            if (AccountNumber != null)
            {
                SavingsStatement _SavingsStatement = new SavingsStatement(AccountNumber);
                _SavingsStatement.ShowDialog();
            }
        }
    }
}