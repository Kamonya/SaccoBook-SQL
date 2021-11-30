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

namespace SaccoBook
{
    public partial class ViewDashboard : DevExpress.XtraEditors.XtraForm
    {
        public ViewDashboard()
        {
            InitializeComponent();
        }
        public ViewDashboard(string Dashboard)
        {
            InitializeComponent();

            LoadDashboard(Dashboard);
        }

        private void LoadDashboard(string dashboard)
        {
            if(dashboard == "Members")
            {
                dashboardViewer1.DashboardSource = typeof(Dashboards.Members);
            }
            if (dashboard == "Savings")
            {
                dashboardViewer1.DashboardSource = typeof(Dashboards.SavingsDashboard);
            }
        }
    }
}