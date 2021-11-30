using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace SaccoBook.Reports.Loans
{
    public partial class LoanDefaultersReport : DevExpress.XtraReports.UI.XtraReport
    {
        public LoanDefaultersReport()
        {
            InitializeComponent();
        }

        private void LoanDefaultersReport_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            this.Parameters["CurrentDate"].Value = DateTime.Now;
        }

        private void LoanDefaultersReport_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            this.Parameters["CurrentDate"].Value = DateTime.Now;
        }

        private void LoanDefaultersReport_ParametersRequestValueChanged(object sender, DevExpress.XtraReports.Parameters.ParametersRequestValueChangedEventArgs e)
        {
            this.Parameters["CurrentDate"].Value = DateTime.Now;
        }
    }
}
