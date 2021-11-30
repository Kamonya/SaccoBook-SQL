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

namespace SaccoBook.Reports
{
    public partial class PeriodChooser : DevExpress.XtraEditors.XtraForm
    {
        static string Report = null;
        public PeriodChooser()
        {
            InitializeComponent();
        }
        public PeriodChooser(string _Report)
        {
            InitializeComponent();
            _ReportType.Text = _Report;
            Report = _Report;
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            if(Report == "Sacco Savings")
            {               
                if (_Period.Text == "Daily & Weekly")
                {
                    Reports.SavingsWithdrawals.Sacco.SaccoSavingsWithdrawal _SaccoSavingsWithdrawal = new Reports.SavingsWithdrawals.Sacco.SaccoSavingsWithdrawal();
                    _SaccoSavingsWithdrawal.Parameters["EndDate"].Value = DateTime.Now;
                    _SaccoSavingsWithdrawal.Parameters["StartDate"].Value = DateTime.Now;
                    //specify DataMember
                    _SaccoSavingsWithdrawal.DataMember = "membersavings";
                    _SaccoSavingsWithdrawal.FilterString = @"[TransactionDate] Between(?StartDate, ?EndDate)";
                    _SaccoSavingsWithdrawal.Parameters["EndDate"].Visible = true;
                    _SaccoSavingsWithdrawal.Parameters["Year"].Visible = false;
                    _SaccoSavingsWithdrawal.Parameters["StartDate"].Visible = true;
                    _SaccoSavingsWithdrawal.Parameters["BiAnnual"].Visible = false;
                    _SaccoSavingsWithdrawal.Parameters["Quarters"].Visible = false;
                    _SaccoSavingsWithdrawal.Parameters["ReportType"].Visible = false;
                    _SaccoSavingsWithdrawal.Parameters["ReportType"].Value = "Weekly";

                    AppResources.DevexpressFunctions.LoadReport(_SaccoSavingsWithdrawal, this);
                }
                if (_Period.Text == "Monthly")
                {
                    Reports.SavingsWithdrawals.Sacco.SaccoSavingsWithdrawal _SaccoSavingsWithdrawal = new Reports.SavingsWithdrawals.Sacco.SaccoSavingsWithdrawal();
                    _SaccoSavingsWithdrawal.Parameters["EndDate"].Value = DateTime.Now;
                    _SaccoSavingsWithdrawal.Parameters["StartDate"].Value = DateTime.Now;
                    //_SaccoSavingsWithdrawal.Parameters["Year"].Value = DateTime.Now.Year;
                    //specify DataMember
                    _SaccoSavingsWithdrawal.DataMember = "membersavings";
                    _SaccoSavingsWithdrawal.FilterString = @"[TransactionDate] Between(?StartDate, ?EndDate)";
                    _SaccoSavingsWithdrawal.Parameters["EndDate"].Visible = false;
                    _SaccoSavingsWithdrawal.Parameters["Year"].Visible = false;
                    _SaccoSavingsWithdrawal.Parameters["StartDate"].Visible = true;
                    _SaccoSavingsWithdrawal.Parameters["BiAnnual"].Visible = false;
                    _SaccoSavingsWithdrawal.Parameters["Quarters"].Visible = false;
                    _SaccoSavingsWithdrawal.Parameters["ReportType"].Visible = false;
                    _SaccoSavingsWithdrawal.Parameters["ReportType"].Value = "Monthly";

                    AppResources.DevexpressFunctions.LoadReport(_SaccoSavingsWithdrawal, this);
                }
                if (_Period.Text == "Quarterly")
                {
                    Reports.SavingsWithdrawals.Sacco.SaccoSavingsWithdrawal _SaccoSavingsWithdrawal = new Reports.SavingsWithdrawals.Sacco.SaccoSavingsWithdrawal();
                    _SaccoSavingsWithdrawal.Parameters["EndDate"].Value = DateTime.Now;
                    _SaccoSavingsWithdrawal.Parameters["StartDate"].Value = DateTime.Now;
                    _SaccoSavingsWithdrawal.Parameters["Year"].Value = DateTime.Now.Year;
                    //specify DataMember
                    _SaccoSavingsWithdrawal.DataMember = "membersavings";
                    _SaccoSavingsWithdrawal.FilterString = @"[TransactionDate] Between(?StartDate, ?EndDate)";
                    _SaccoSavingsWithdrawal.Parameters["EndDate"].Visible = false;
                    _SaccoSavingsWithdrawal.Parameters["Year"].Visible = true;
                    _SaccoSavingsWithdrawal.Parameters["StartDate"].Visible = false;
                    _SaccoSavingsWithdrawal.Parameters["BiAnnual"].Visible = false;
                    _SaccoSavingsWithdrawal.Parameters["Quarters"].Visible = true;
                    _SaccoSavingsWithdrawal.Parameters["ReportType"].Visible = false;
                    _SaccoSavingsWithdrawal.Parameters["ReportType"].Value = "Quarterly";

                    AppResources.DevexpressFunctions.LoadReport(_SaccoSavingsWithdrawal, this);
                }
                if (_Period.Text == "BiAnnual")
                {
                    Reports.SavingsWithdrawals.Sacco.SaccoSavingsWithdrawal _SaccoSavingsWithdrawal = new Reports.SavingsWithdrawals.Sacco.SaccoSavingsWithdrawal();
                    _SaccoSavingsWithdrawal.Parameters["EndDate"].Value = DateTime.Now;
                    _SaccoSavingsWithdrawal.Parameters["StartDate"].Value = DateTime.Now;
                    _SaccoSavingsWithdrawal.Parameters["Year"].Value = DateTime.Now.Year;
                    //specify DataMember
                    _SaccoSavingsWithdrawal.DataMember = "membersavings";
                    _SaccoSavingsWithdrawal.FilterString = @"[TransactionDate] Between(?StartDate, ?EndDate)";
                    _SaccoSavingsWithdrawal.Parameters["EndDate"].Visible = false;
                    _SaccoSavingsWithdrawal.Parameters["Year"].Visible = true;
                    _SaccoSavingsWithdrawal.Parameters["StartDate"].Visible = false;
                    _SaccoSavingsWithdrawal.Parameters["BiAnnual"].Visible = true;
                    _SaccoSavingsWithdrawal.Parameters["Quarters"].Visible = false;
                    _SaccoSavingsWithdrawal.Parameters["ReportType"].Visible = false;
                    _SaccoSavingsWithdrawal.Parameters["ReportType"].Value = "BiAnnual";

                    AppResources.DevexpressFunctions.LoadReport(_SaccoSavingsWithdrawal, this);
                }
                if (_Period.Text == "Annual")
                {
                    Reports.SavingsWithdrawals.Sacco.SaccoSavingsWithdrawal _SaccoSavingsWithdrawal = new Reports.SavingsWithdrawals.Sacco.SaccoSavingsWithdrawal();
                    _SaccoSavingsWithdrawal.Parameters["EndDate"].Value = DateTime.Now;
                    _SaccoSavingsWithdrawal.Parameters["StartDate"].Value = DateTime.Now;
                    _SaccoSavingsWithdrawal.Parameters["Year"].Value = DateTime.Now.Year;
                    //specify DataMember
                    _SaccoSavingsWithdrawal.DataMember = "membersavings";
                    _SaccoSavingsWithdrawal.FilterString = @"[TransactionDate] Between(?StartDate, ?EndDate)";
                    _SaccoSavingsWithdrawal.Parameters["EndDate"].Visible = false;
                    _SaccoSavingsWithdrawal.Parameters["Year"].Visible = true;
                    _SaccoSavingsWithdrawal.Parameters["StartDate"].Visible = false;
                    _SaccoSavingsWithdrawal.Parameters["BiAnnual"].Visible = false;
                    _SaccoSavingsWithdrawal.Parameters["Quarters"].Visible = false;
                    _SaccoSavingsWithdrawal.Parameters["ReportType"].Visible = false;
                    _SaccoSavingsWithdrawal.Parameters["ReportType"].Value = "Year";

                    AppResources.DevexpressFunctions.LoadReport(_SaccoSavingsWithdrawal, this);
                }
            }
            else if(Report == "Member Savings")
            {
                if (_Period.Text == "Daily & Weekly")
                {
                    Reports.SavingsWithdrawals.Member.MemberSavingsWithdrawal _MemberSavingsWithdrawal = new Reports.SavingsWithdrawals.Member.MemberSavingsWithdrawal();
                    _MemberSavingsWithdrawal.Parameters["EndDate"].Value = DateTime.Now;
                    _MemberSavingsWithdrawal.Parameters["StartDate"].Value = DateTime.Now;
                    //specify DataMember
                    _MemberSavingsWithdrawal.DataMember = "membersavings";
                    _MemberSavingsWithdrawal.FilterString = @"[TransactionDate] Between(?StartDate, ?EndDate)";
                    _MemberSavingsWithdrawal.Parameters["EndDate"].Visible = true;
                    _MemberSavingsWithdrawal.Parameters["Year"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["StartDate"].Visible = true;
                    _MemberSavingsWithdrawal.Parameters["BiAnnual"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["Quarters"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["ReportType"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["ReportType"].Value = "Weekly";

                    AppResources.DevexpressFunctions.LoadReport(_MemberSavingsWithdrawal, this);
                }
                if (_Period.Text == "Monthly")
                {
                    Reports.SavingsWithdrawals.Member.MemberSavingsWithdrawal _MemberSavingsWithdrawal = new Reports.SavingsWithdrawals.Member.MemberSavingsWithdrawal();
                    _MemberSavingsWithdrawal.Parameters["EndDate"].Value = DateTime.Now;
                    _MemberSavingsWithdrawal.Parameters["StartDate"].Value = DateTime.Now;
                    //_MemberSavingsWithdrawal.Parameters["Year"].Value = DateTime.Now.Year;
                    //specify DataMember
                    _MemberSavingsWithdrawal.DataMember = "membersavings";
                    _MemberSavingsWithdrawal.FilterString = @"[TransactionDate] Between(?StartDate, ?EndDate)";

                    _MemberSavingsWithdrawal.Parameters["EndDate"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["Year"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["StartDate"].Visible = true;
                    _MemberSavingsWithdrawal.Parameters["BiAnnual"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["Quarters"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["ReportType"].Value = "Monthly";
                    _MemberSavingsWithdrawal.Parameters["ReportType"].Visible = false;
                   
                    AppResources.DevexpressFunctions.LoadReport(_MemberSavingsWithdrawal, this);
                }
                if (_Period.Text == "Quarterly")
                {
                    Reports.SavingsWithdrawals.Member.MemberSavingsWithdrawal _MemberSavingsWithdrawal = new Reports.SavingsWithdrawals.Member.MemberSavingsWithdrawal();
                    _MemberSavingsWithdrawal.Parameters["EndDate"].Value = DateTime.Now;
                    _MemberSavingsWithdrawal.Parameters["StartDate"].Value = DateTime.Now;
                    _MemberSavingsWithdrawal.Parameters["Year"].Value = DateTime.Now.Year;
                    //specify DataMember
                    _MemberSavingsWithdrawal.DataMember = "membersavings";
                    _MemberSavingsWithdrawal.FilterString = @"[TransactionDate] Between(?StartDate, ?EndDate)";
                    _MemberSavingsWithdrawal.Parameters["EndDate"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["Year"].Visible = true;
                    _MemberSavingsWithdrawal.Parameters["StartDate"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["BiAnnual"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["Quarters"].Visible = true;
                    _MemberSavingsWithdrawal.Parameters["ReportType"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["ReportType"].Value = "Quarterly";

                    AppResources.DevexpressFunctions.LoadReport(_MemberSavingsWithdrawal, this);
                }
                if (_Period.Text == "BiAnnual")
                {
                    Reports.SavingsWithdrawals.Member.MemberSavingsWithdrawal _MemberSavingsWithdrawal = new Reports.SavingsWithdrawals.Member.MemberSavingsWithdrawal();
                    _MemberSavingsWithdrawal.Parameters["EndDate"].Value = DateTime.Now;
                    _MemberSavingsWithdrawal.Parameters["StartDate"].Value = DateTime.Now;
                    _MemberSavingsWithdrawal.Parameters["Year"].Value = DateTime.Now.Year;
                    //specify DataMember
                    _MemberSavingsWithdrawal.DataMember = "membersavings";
                    _MemberSavingsWithdrawal.FilterString = @"[TransactionDate] Between(?StartDate, ?EndDate)";
                    _MemberSavingsWithdrawal.Parameters["EndDate"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["Year"].Visible = true;
                    _MemberSavingsWithdrawal.Parameters["StartDate"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["BiAnnual"].Visible = true;
                    _MemberSavingsWithdrawal.Parameters["Quarters"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["ReportType"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["ReportType"].Value = "BiAnnual";

                    AppResources.DevexpressFunctions.LoadReport(_MemberSavingsWithdrawal, this);
                }
                if (_Period.Text == "Annual")
                {
                    Reports.SavingsWithdrawals.Member.MemberSavingsWithdrawal _MemberSavingsWithdrawal = new Reports.SavingsWithdrawals.Member.MemberSavingsWithdrawal();
                    _MemberSavingsWithdrawal.Parameters["EndDate"].Value = DateTime.Now;
                    _MemberSavingsWithdrawal.Parameters["StartDate"].Value = DateTime.Now;
                    _MemberSavingsWithdrawal.Parameters["Year"].Value = DateTime.Now.Year;
                    //specify DataMember
                    _MemberSavingsWithdrawal.DataMember = "membersavings";
                    _MemberSavingsWithdrawal.FilterString = @"[TransactionDate] Between(?StartDate, ?EndDate)";
                    _MemberSavingsWithdrawal.Parameters["EndDate"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["Year"].Visible = true;
                    _MemberSavingsWithdrawal.Parameters["StartDate"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["BiAnnual"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["Quarters"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["ReportType"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["ReportType"].Value = "Year";

                    AppResources.DevexpressFunctions.LoadReport(_MemberSavingsWithdrawal, this);
                }
            }
            else if (Report == "Awarded Loans Report")
            {
                if (_Period.Text == "Daily & Weekly")
                {
                    Loans.LoansAwardedReport _LoansAwardedReport = new Loans.LoansAwardedReport();
                    _LoansAwardedReport.Parameters["EndDate"].Value = DateTime.Now;
                    _LoansAwardedReport.Parameters["StartDate"].Value = DateTime.Now;
                    //specify DataMember
                    //_LoansAwardedReport.DataMember = "membersavings";
                    //_LoansAwardedReport.FilterString = @"[TransactionDate] Between(?StartDate, ?EndDate)";
                    _LoansAwardedReport.Parameters["EndDate"].Visible = true;
                    _LoansAwardedReport.Parameters["Year"].Visible = false;
                    _LoansAwardedReport.Parameters["StartDate"].Visible = true;
                    _LoansAwardedReport.Parameters["BiAnnual"].Visible = false;
                    _LoansAwardedReport.Parameters["Quarters"].Visible = false;
                    _LoansAwardedReport.Parameters["ReportType"].Visible = false;
                    _LoansAwardedReport.Parameters["ReportType"].Value = "Weekly";

                    AppResources.DevexpressFunctions.LoadReport(_LoansAwardedReport, this);
                }
                if (_Period.Text == "Monthly")
                {
                    Loans.LoansAwardedReport _LoansAwardedReport = new Loans.LoansAwardedReport();
                    _LoansAwardedReport.Parameters["EndDate"].Value = DateTime.Now;
                    _LoansAwardedReport.Parameters["StartDate"].Value = DateTime.Now;
                    //_LoansAwardedReport.Parameters["Year"].Value = DateTime.Now.Year;
                    //specify DataMember
                    //_LoansAwardedReport.DataMember = "membersavings";
                    //_LoansAwardedReport.FilterString = @"[TransactionDate] Between(?StartDate, ?EndDate)";

                    _LoansAwardedReport.Parameters["EndDate"].Visible = false;
                    _LoansAwardedReport.Parameters["Year"].Visible = false;
                    _LoansAwardedReport.Parameters["StartDate"].Visible = true;
                    _LoansAwardedReport.Parameters["BiAnnual"].Visible = false;
                    _LoansAwardedReport.Parameters["Quarters"].Visible = false;
                    _LoansAwardedReport.Parameters["ReportType"].Value = "Monthly";
                    _LoansAwardedReport.Parameters["ReportType"].Visible = false;

                    AppResources.DevexpressFunctions.LoadReport(_LoansAwardedReport, this);
                }
                if (_Period.Text == "Quarterly")
                {
                    Loans.LoansAwardedReport _LoansAwardedReport = new Loans.LoansAwardedReport();
                    _LoansAwardedReport.Parameters["EndDate"].Value = DateTime.Now;
                    _LoansAwardedReport.Parameters["StartDate"].Value = DateTime.Now;
                    _LoansAwardedReport.Parameters["Year"].Value = DateTime.Now.Year;
                    //specify DataMember
                    //_LoansAwardedReport.DataMember = "membersavings";
                    //_LoansAwardedReport.FilterString = @"[TransactionDate] Between(?StartDate, ?EndDate)";
                    _LoansAwardedReport.Parameters["EndDate"].Visible = false;
                    _LoansAwardedReport.Parameters["Year"].Visible = true;
                    _LoansAwardedReport.Parameters["StartDate"].Visible = false;
                    _LoansAwardedReport.Parameters["BiAnnual"].Visible = false;
                    _LoansAwardedReport.Parameters["Quarters"].Visible = true;
                    _LoansAwardedReport.Parameters["ReportType"].Visible = false;
                    _LoansAwardedReport.Parameters["ReportType"].Value = "Quarterly";

                    AppResources.DevexpressFunctions.LoadReport(_LoansAwardedReport, this);
                }
                if (_Period.Text == "BiAnnual")
                {
                    Loans.LoansAwardedReport _LoansAwardedReport = new Loans.LoansAwardedReport();
                    _LoansAwardedReport.Parameters["EndDate"].Value = DateTime.Now;
                    _LoansAwardedReport.Parameters["StartDate"].Value = DateTime.Now;
                    _LoansAwardedReport.Parameters["Year"].Value = DateTime.Now.Year;
                    //specify DataMember
                    //_LoansAwardedReport.DataMember = "membersavings";
                    //_LoansAwardedReport.FilterString = @"[TransactionDate] Between(?StartDate, ?EndDate)";
                    _LoansAwardedReport.Parameters["EndDate"].Visible = false;
                    _LoansAwardedReport.Parameters["Year"].Visible = true;
                    _LoansAwardedReport.Parameters["StartDate"].Visible = false;
                    _LoansAwardedReport.Parameters["BiAnnual"].Visible = true;
                    _LoansAwardedReport.Parameters["Quarters"].Visible = false;
                    _LoansAwardedReport.Parameters["ReportType"].Visible = false;
                    _LoansAwardedReport.Parameters["ReportType"].Value = "BiAnnual";

                    AppResources.DevexpressFunctions.LoadReport(_LoansAwardedReport, this);
                }
                if (_Period.Text == "Annual")
                {
                    Loans.LoansAwardedReport _LoansAwardedReport = new Loans.LoansAwardedReport();
                    _LoansAwardedReport.Parameters["EndDate"].Value = DateTime.Now;
                    _LoansAwardedReport.Parameters["StartDate"].Value = DateTime.Now;
                    _LoansAwardedReport.Parameters["Year"].Value = DateTime.Now.Year;
                    //specify DataMember
                    //_LoansAwardedReport.DataMember = "membersavings";
                    //_LoansAwardedReport.FilterString = @"[TransactionDate] Between(?StartDate, ?EndDate)";
                    _LoansAwardedReport.Parameters["EndDate"].Visible = false;
                    _LoansAwardedReport.Parameters["Year"].Visible = true;
                    _LoansAwardedReport.Parameters["StartDate"].Visible = false;
                    _LoansAwardedReport.Parameters["BiAnnual"].Visible = false;
                    _LoansAwardedReport.Parameters["Quarters"].Visible = false;
                    _LoansAwardedReport.Parameters["ReportType"].Visible = false;
                    _LoansAwardedReport.Parameters["ReportType"].Value = "Year";

                    AppResources.DevexpressFunctions.LoadReport(_LoansAwardedReport, this);
                }
            }
            else if (Report == "Member Savings Statement")
            {
                if (_Period.Text == "Daily & Weekly")
                {
                    Reports.SavingsWithdrawals.Member.MemberSavingsWithdrawal _MemberSavingsWithdrawal = new Reports.SavingsWithdrawals.Member.MemberSavingsWithdrawal();
                    _MemberSavingsWithdrawal.Parameters["EndDate"].Value = DateTime.Now;
                    _MemberSavingsWithdrawal.Parameters["StartDate"].Value = DateTime.Now;
                    //specify DataMember
                    _MemberSavingsWithdrawal.DataMember = "membersavings";
                    _MemberSavingsWithdrawal.FilterString = @"[TransactionDate] Between(?StartDate, ?EndDate)";
                    _MemberSavingsWithdrawal.Parameters["EndDate"].Visible = true;
                    _MemberSavingsWithdrawal.Parameters["Year"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["StartDate"].Visible = true;
                    _MemberSavingsWithdrawal.Parameters["BiAnnual"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["Quarters"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["ReportType"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["ReportType"].Value = "Weekly";

                    AppResources.DevexpressFunctions.LoadReport(_MemberSavingsWithdrawal, this);
                }
                if (_Period.Text == "Monthly")
                {
                    Reports.SavingsWithdrawals.Member.MemberSavingsWithdrawal _MemberSavingsWithdrawal = new Reports.SavingsWithdrawals.Member.MemberSavingsWithdrawal();
                    _MemberSavingsWithdrawal.Parameters["EndDate"].Value = DateTime.Now;
                    _MemberSavingsWithdrawal.Parameters["StartDate"].Value = DateTime.Now;
                    //_MemberSavingsWithdrawal.Parameters["Year"].Value = DateTime.Now.Year;
                    //specify DataMember
                    _MemberSavingsWithdrawal.DataMember = "membersavings";
                    _MemberSavingsWithdrawal.FilterString = @"[TransactionDate] Between(?StartDate, ?EndDate)";

                    _MemberSavingsWithdrawal.Parameters["EndDate"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["Year"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["StartDate"].Visible = true;
                    _MemberSavingsWithdrawal.Parameters["BiAnnual"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["Quarters"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["ReportType"].Value = "Monthly";
                    _MemberSavingsWithdrawal.Parameters["ReportType"].Visible = false;

                    AppResources.DevexpressFunctions.LoadReport(_MemberSavingsWithdrawal, this);
                }
                if (_Period.Text == "Quarterly")
                {
                    Reports.SavingsWithdrawals.Member.MemberSavingsWithdrawal _MemberSavingsWithdrawal = new Reports.SavingsWithdrawals.Member.MemberSavingsWithdrawal();
                    _MemberSavingsWithdrawal.Parameters["EndDate"].Value = DateTime.Now;
                    _MemberSavingsWithdrawal.Parameters["StartDate"].Value = DateTime.Now;
                    _MemberSavingsWithdrawal.Parameters["Year"].Value = DateTime.Now.Year;
                    //specify DataMember
                    _MemberSavingsWithdrawal.DataMember = "membersavings";
                    _MemberSavingsWithdrawal.FilterString = @"[TransactionDate] Between(?StartDate, ?EndDate)";
                    _MemberSavingsWithdrawal.Parameters["EndDate"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["Year"].Visible = true;
                    _MemberSavingsWithdrawal.Parameters["StartDate"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["BiAnnual"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["Quarters"].Visible = true;
                    _MemberSavingsWithdrawal.Parameters["ReportType"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["ReportType"].Value = "Quarterly";

                    AppResources.DevexpressFunctions.LoadReport(_MemberSavingsWithdrawal, this);
                }
                if (_Period.Text == "BiAnnual")
                {
                    Reports.SavingsWithdrawals.Member.MemberSavingsWithdrawal _MemberSavingsWithdrawal = new Reports.SavingsWithdrawals.Member.MemberSavingsWithdrawal();
                    _MemberSavingsWithdrawal.Parameters["EndDate"].Value = DateTime.Now;
                    _MemberSavingsWithdrawal.Parameters["StartDate"].Value = DateTime.Now;
                    _MemberSavingsWithdrawal.Parameters["Year"].Value = DateTime.Now.Year;
                    //specify DataMember
                    _MemberSavingsWithdrawal.DataMember = "membersavings";
                    _MemberSavingsWithdrawal.FilterString = @"[TransactionDate] Between(?StartDate, ?EndDate)";
                    _MemberSavingsWithdrawal.Parameters["EndDate"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["Year"].Visible = true;
                    _MemberSavingsWithdrawal.Parameters["StartDate"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["BiAnnual"].Visible = true;
                    _MemberSavingsWithdrawal.Parameters["Quarters"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["ReportType"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["ReportType"].Value = "BiAnnual";

                    AppResources.DevexpressFunctions.LoadReport(_MemberSavingsWithdrawal, this);
                }
                if (_Period.Text == "Annual")
                {
                    Reports.SavingsWithdrawals.Member.MemberSavingsWithdrawal _MemberSavingsWithdrawal = new Reports.SavingsWithdrawals.Member.MemberSavingsWithdrawal();
                    _MemberSavingsWithdrawal.Parameters["EndDate"].Value = DateTime.Now;
                    _MemberSavingsWithdrawal.Parameters["StartDate"].Value = DateTime.Now;
                    _MemberSavingsWithdrawal.Parameters["Year"].Value = DateTime.Now.Year;
                    //specify DataMember
                    _MemberSavingsWithdrawal.DataMember = "membersavings";
                    _MemberSavingsWithdrawal.FilterString = @"[TransactionDate] Between(?StartDate, ?EndDate)";
                    _MemberSavingsWithdrawal.Parameters["EndDate"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["Year"].Visible = true;
                    _MemberSavingsWithdrawal.Parameters["StartDate"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["BiAnnual"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["Quarters"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["ReportType"].Visible = false;
                    _MemberSavingsWithdrawal.Parameters["ReportType"].Value = "Year";

                    AppResources.DevexpressFunctions.LoadReport(_MemberSavingsWithdrawal, this);
                }
            }
        }
    }
}