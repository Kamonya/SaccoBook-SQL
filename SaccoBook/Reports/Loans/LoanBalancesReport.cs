using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.IO;
using System.Windows.Forms;

namespace SaccoBook.Reports.Loans
{
    public partial class LoanBalancesReport : DevExpress.XtraReports.UI.XtraReport
    {
        string pathtoPhoto = Path.GetDirectoryName(Application.ExecutablePath) + @"\Photos\";
        public LoanBalancesReport()
        {
            InitializeComponent();
        }

        private void LoanBalancesReport_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            this.Parameters["AppPath"].Value = pathtoPhoto;
        }

        private void LoanBalancesReport_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            this.Parameters["AppPath"].Value = pathtoPhoto;
        }

        private void LoanBalancesReport_ParametersRequestValueChanged(object sender, DevExpress.XtraReports.Parameters.ParametersRequestValueChangedEventArgs e)
        {
            this.Parameters["AppPath"].Value = pathtoPhoto;
        }
    }
}
