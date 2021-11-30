using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;

namespace SaccoBook.Reports.Loans
{
    public partial class LoansAwardedReport : DevExpress.XtraReports.UI.XtraReport
    {
        public LoansAwardedReport() 
        {
            InitializeComponent();
        }

        private void LoansAwardedReport_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            string ReportType = this.Parameters["ReportType"].Value.ToString();

            if (ReportType == "BiAnnual")
            {
                this.Parameters["Year"].Value = DateTime.Now.Year;
            }
            if (ReportType == "Monthly")
            {
                DevExpress.XtraEditors.DateEdit dateEdit = (e.ParametersInformation[0] as ParameterInfo).Editor as DevExpress.XtraEditors.DateEdit;
                dateEdit.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
                dateEdit.Properties.DisplayFormat.FormatString = "MMMM yyyy";
                dateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                dateEdit.Properties.EditFormat.FormatString = "MMMM yyyy ";
                dateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
                dateEdit.Properties.Mask.EditMask = "MMMM yyyy";
                this.Parameters["StartDate"].Value = DateTime.Now;
            }
            if (ReportType == "Quarterly")
            {
                this.Parameters["Year"].Value = DateTime.Now.Year;
            }
            if (ReportType == "Year")
            {
                this.Parameters["StartDate"].Value = DateTime.Now.Year;
            }
        }

        private void LoansAwardedReport_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            string ReportType = this.Parameters["ReportType"].Value.ToString();

            if (ReportType == "BiAnnual")
            {
                string BiAnnual = this.Parameters["BiAnnual"].Value.ToString();
                int year = Convert.ToInt32(this.Parameters["Year"].Value.ToString());

                SetBiAnnualDates(BiAnnual, year);
            }
            if (ReportType == "Monthly")
            {
                DateTime oDate = Convert.ToDateTime(this.Parameters["StartDate"].Value);
                this.Parameters["EndDate"].Value = SetMonthDates(oDate);
            }
            if (ReportType == "Quarterly")
            {
                string quaters = this.Parameters["Quarters"].Value.ToString();
                int year = Convert.ToInt32(this.Parameters["Year"].Value.ToString());

                SetQuarterDates(quaters, year);
            }
            if (ReportType == "Year")
            {
                int year = Convert.ToInt32(this.Parameters["Year"].Value.ToString());

                SetYearDates(year);
            }
        }

        private void LoansAwardedReport_ParametersRequestValueChanged(object sender, DevExpress.XtraReports.Parameters.ParametersRequestValueChangedEventArgs e)
        {
            string ReportType = this.Parameters["ReportType"].Value.ToString();

            if (ReportType == "BiAnnual")
            {
                string BiAnnual = this.Parameters["BiAnnual"].Value.ToString();
                int year = Convert.ToInt32(this.Parameters["Year"].Value.ToString());

                SetBiAnnualDates(BiAnnual, year);
            }
            if (ReportType == "Monthly")
            {
                DateTime oDate = Convert.ToDateTime(this.Parameters["StartDate"].Value);
                this.Parameters["EndDate"].Value = SetMonthDates(oDate);
            }
            if (ReportType == "Quarterly")
            {
                string quaters = this.Parameters["Quarters"].Value.ToString();
                int year = Convert.ToInt32(this.Parameters["Year"].Value.ToString());

                SetQuarterDates(quaters, year);
            }
            if (ReportType == "Year")
            {
                int year = Convert.ToInt32(this.Parameters["Year"].Value.ToString());

                SetYearDates(year);
            }
        }
        public static DateTime SetMonthDates(DateTime date)
        {
            //get Month from date then, get number of days in month, number of days is same as last day of month, create date time object from that to get exact day of month
            // Get month and Year from DateTime Object
            int Year = date.Year;
            int Month = date.Month;
            int Days = DateTime.DaysInMonth(Year, Month);

            DateTime FinalMonthDate = new System.DateTime(Year, Month, Days, 0, 0, 0, 0);
            return FinalMonthDate;
        }
        private void SetQuarterDates(string Quarter, int year)
        {
            if (Quarter == "Q1")
            {
                this.Parameters["StartDate"].Value = new System.DateTime(year, 1, 1, 0, 0, 0, 0);
                this.Parameters["EndDate"].Value = new System.DateTime(year, 3, 31, 0, 0, 0, 0);
            }
            else if (Quarter == "Q2")
            {
                this.Parameters["StartDate"].Value = new System.DateTime(year, 4, 1, 0, 0, 0, 0);
                this.Parameters["EndDate"].Value = new System.DateTime(year, 6, 30, 0, 0, 0, 0);
            }
            else if (Quarter == "Q3")
            {
                this.Parameters["StartDate"].Value = new System.DateTime(year, 7, 1, 0, 0, 0, 0);
                this.Parameters["EndDate"].Value = new System.DateTime(year, 9, 30, 0, 0, 0, 0);
            }
            else if (Quarter == "Q4")
            {
                this.Parameters["StartDate"].Value = new System.DateTime(year, 10, 1, 0, 0, 0, 0);
                this.Parameters["EndDate"].Value = new System.DateTime(year, 12, 31, 0, 0, 0, 0);
            }
        }
        private void SetBiAnnualDates(string BiAnnual, int year)
        {
            if (BiAnnual == "B1")
            {
                this.Parameters["StartDate"].Value = new System.DateTime(year, 1, 1, 0, 0, 0, 0);
                this.Parameters["EndDate"].Value = new System.DateTime(year, 6, 30, 0, 0, 0, 0);
            }
            else if (BiAnnual == "B2")
            {
                this.Parameters["StartDate"].Value = new System.DateTime(year, 7, 1, 0, 0, 0, 0);
                this.Parameters["EndDate"].Value = new System.DateTime(year, 12, 31, 0, 0, 0, 0);
            }
        }
        private void SetYearDates(int year)
        {
            this.Parameters["StartDate"].Value = new System.DateTime(year, 1, 1, 0, 0, 0, 0);
            this.Parameters["EndDate"].Value = new System.DateTime(year, 12, 31, 0, 0, 0, 0);
        }
    }
}
