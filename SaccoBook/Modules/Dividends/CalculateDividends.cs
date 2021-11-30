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
using Newtonsoft.Json;

namespace SaccoBook.Modules.Dividends
{
    public partial class CalculateDividends : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public CalculateDividends()
        {
            InitializeComponent();
        }
        public CalculateDividends(string MembershipNumber)
        {
            InitializeComponent();

            CalculateMemberDividends(MembershipNumber);
        }
        private void CalculateMemberDividends(string MembershipNumber)
        {
            double WHTRate = 0.05;
            double WHT = 0.00;
            double DividendCapitalisation = 0.00;
            double ProcessingFee = 330.00;
            double ExciseDuty = 30.00;

            double ShareCapitalPayable = 0.00;
            double ShareCapitalPayableRate = 0.17;


            double SharesBalanceOfCurrentYear = 20000.00;
            double DepositsBalanceOfYearBeforeCurrentYear = 10000.00; //Current year -1

            double TotalQualifyingDeposits = 0.00;
            double TotalInterestsPayable = 0.00;
            double GrossDividends = 0.00;









            ShareCapitalPayable = ShareCapitalPayableRate * SharesBalanceOfCurrentYear;

            DataSet ds = new DataSet();

            DataTable dt = new DataTable("ShareCapiatl");



            dt.Columns.Add(new DataColumn("Month", typeof(string)));
            dt.Columns.Add(new DataColumn("Qualifying Deposits", typeof(string)));
            dt.Columns.Add(new DataColumn("Interests on Deposits", typeof(string)));

            //dt.

            DataRow drheader = dt.NewRow();
           // drheader["Date"] = "Eaxmple";
            drheader["Month"] = "Total Deposits as at 31st Dec 2016";
            drheader["Qualifying Deposits"] = 12;
            drheader["Interests on Deposits"] = 12;
            dt.Rows.Add(drheader);
            TotalQualifyingDeposits = TotalQualifyingDeposits + DepositsBalanceOfYearBeforeCurrentYear;


           
            double QualifyingDeposits = 0.00;
            double InterestsOnDeposits = 0.00;
            string DividendsList = EF.DividendsQueries.GetDividendsList(MembershipNumber);

            dynamic _DividendsList = JsonConvert.DeserializeObject(DividendsList);

            foreach (var dividend in _DividendsList)
            {
                int MonthNumber = dividend.MonthNumber;
                string MonthName = dividend.Month;
                string Year = dividend.Year;
                double SavingsAmount = dividend.Amount;

                DataRow dr = dt.NewRow();

                QualifyingDeposits = (13 - MonthNumber) * SavingsAmount / 12;
                InterestsOnDeposits = 10.5 * QualifyingDeposits / 100;

                QualifyingDeposits = Math.Round(QualifyingDeposits, 2, MidpointRounding.ToEven);
                InterestsOnDeposits = Math.Round(InterestsOnDeposits, 2, MidpointRounding.ToEven);

                dr["Month"] = MonthName + " " + Year;
                dr["Qualifying Deposits"] = string.Format("{0:N2}", QualifyingDeposits) ;
                dr["Interests on Deposits"] = string.Format("{0:N2}", InterestsOnDeposits);
                TotalQualifyingDeposits = TotalQualifyingDeposits + QualifyingDeposits;


                dt.Rows.Add(dr);

            }
            ds.Tables.Add(dt);

            gridView1.Columns.Clear();

            gridControl1.DataSource = null;

            gridControl1.DataSource = ds.Tables[0];

            TotalInterestsPayable = 10.5 * TotalQualifyingDeposits / 100;

            GrossDividends = TotalInterestsPayable + ShareCapitalPayable;

            WHT = WHTRate * GrossDividends;

            if (SharesBalanceOfCurrentYear < 50000)
            {
                DividendCapitalisation = ShareCapitalPayable * 17 / 17;
            }
            else
            {
                DividendCapitalisation = ShareCapitalPayable * 0;
            }

            double NetPayable = GrossDividends - WHT - DividendCapitalisation - ProcessingFee - ExciseDuty;

            TotalInterestsPayable = Math.Round(TotalInterestsPayable, 2, MidpointRounding.ToEven);
            _TotalInterestsPayable.Text = TotalInterestsPayable.ToString();

            GrossDividends = Math.Round(GrossDividends, 2, MidpointRounding.ToEven);
            _GrossDividends.Text = GrossDividends.ToString();

            WHT = Math.Round(WHT, 2, MidpointRounding.ToEven);
            _WHT.Text = "-" + WHT.ToString();

            DividendCapitalisation = Math.Round(DividendCapitalisation, 2, MidpointRounding.ToEven);
            _DividendCapitalisation.Text = "-" + DividendCapitalisation.ToString();

            ProcessingFee = Math.Round(ProcessingFee, 2, MidpointRounding.ToEven);
            _ProcessingFee.Text = "-" + ProcessingFee.ToString();

            ExciseDuty = Math.Round(ExciseDuty, 2, MidpointRounding.ToEven);
            _ExciseDuty.Text = "-" + ExciseDuty.ToString();

            NetPayable = Math.Round(NetPayable, 2, MidpointRounding.ToEven);
            _NetPayable.Text = NetPayable.ToString();
        }
    }
}