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

namespace SaccoBook.Modules.Settings.Loans
{
    public partial class LoanProducts : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string DocumentNumber = null;
        public LoanProducts()
        {
            InitializeComponent();

            LoadTable();
        }

        private void LoadTable()
        {
            string sqlLoanProducts = EF.LoansQueries.GetLoanProducts();

            AppResources.AppFunctions.LoadTable(gridControlLoanProducts, gridViewLoanProducts, sqlLoanProducts);
        }

        private void btn_newloanproduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoanProduct _LoanProduct = new LoanProduct();
            _LoanProduct.ShowDialog();
        }

        private void btn_edit_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoanProduct _LoanProduct = new LoanProduct(DocumentNumber, true);
            _LoanProduct.ShowDialog();
        }

        private void gridViewLoanProducts_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DocumentNumber = AppResources.DevexpressFunctions.GetItemrowClick(gridViewLoanProducts, "Code");
        }

        private void gridViewLoanProducts_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DocumentNumber = AppResources.DevexpressFunctions.GetItemFocusedRowChanged(gridViewLoanProducts, sender, e, "Code");
        }

        private void btn_delete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dlr = XtraMessageBox.Show("Are you sure you want to delete record?", "System Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlr == DialogResult.Yes)
            {
                if (EF.LoansQueries.DeleteLoanProduct(DocumentNumber))
                {
                    XtraMessageBox.Show("The specified record has been successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}