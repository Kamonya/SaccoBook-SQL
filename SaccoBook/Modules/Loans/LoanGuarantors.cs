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

namespace SaccoBook.Modules.Loans
{
    public partial class LoanGuarantors : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        static string LoanId = null;
        public LoanGuarantors()
        {
            InitializeComponent();
        }
        public LoanGuarantors(string _LoanId)
        {
            InitializeComponent();
            this.Text = "Loan Guarantors - Loan ID " + _LoanId;
            LoanId = _LoanId;
            LoadGuarantors(_LoanId);
        }

        private void LoadGuarantors(string loanId)
        {
            string sqlSignatories = EF.LoansQueries.LoadGuarantors(loanId);

            AppResources.AppFunctions.LoadTable(gridControl1, gridView1, sqlSignatories);
        }

        private void btn_refresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadGuarantors(LoanId);
        }

        private void btn_guarantor_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoanGuarantor _LoanGuarantor = new LoanGuarantor(LoanId);
            _LoanGuarantor.ShowDialog();
        }
    }
}