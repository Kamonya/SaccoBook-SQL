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

namespace SaccoBook.Modules.Settings.Savings
{
    public partial class SavingsAccountTypes : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public SavingsAccountTypes()
        {
            InitializeComponent();

            LoadSavingsAccounts();
        }

        private void btn_newAccountType_ItemClick(object sender, ItemClickEventArgs e)
        {
            SavingsAccountType _SavingsAccountType = new SavingsAccountType();
            _SavingsAccountType.ShowDialog();
        }

        private void btn_refresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadSavingsAccounts();
        }

        private void LoadSavingsAccounts()
        {
            //Load Members List
            string sql = EF.SavingsQueries.GetSavingAccountTypes();

            AppResources.AppFunctions.LoadTable(gridControlSavingsAccountTypes, gridViewSavingsAccountTypes, sql);
        }
    }
}