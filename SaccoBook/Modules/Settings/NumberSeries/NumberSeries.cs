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

namespace SaccoBook.Modules.Settings.NumberSeries
{
    public partial class NumberSeries : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public NumberSeries()
        {
            InitializeComponent();
            LoadNumberSeriesList();
        }

        private void LoadNumberSeriesList()
        {
            //Load Members List
            string sql = EF.NumberSeriesQueries.GetNumberSeries();

            AppResources.AppFunctions.LoadTable(gridControlNumberSeries, gridViewNumberSeries, sql);
        }

        private void btn_definenumberseries_ItemClick(object sender, ItemClickEventArgs e)
        {
            DefineRecordNumbers _DefineRecordNumbers = new DefineRecordNumbers();
            _DefineRecordNumbers.ShowDialog();
        }

        private void btn_assign_no_series_ItemClick(object sender, ItemClickEventArgs e)
        {
            AssignedNumberSeries _AssignedNumberSeries = new AssignedNumberSeries();
            _AssignedNumberSeries.ShowDialog();
        }
    }
}