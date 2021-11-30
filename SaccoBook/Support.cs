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
    public partial class Support : DevExpress.XtraEditors.XtraForm
    {
        public Support()
        {
            InitializeComponent();
        }

        private void btn_mails_Click(object sender, EventArgs e)
        {
            this.backgroundWorker1.RunWorkerAsync(2000);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Utilities.BackgroundTasksManager _BackgroundTasksManager = new Utilities.BackgroundTasksManager();
           // _BackgroundTasksManager.BackgroundWorker_DoWork(sender, e, "1", "", "Thanos", "", "", "", "", "", "", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToShortTimeString(), "derrickwitness@gmail.com", "2" + " Approval");
        }
    }
}