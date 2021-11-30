using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SaccoBook
{
    public partial class About : DevExpress.XtraEditors.XtraForm
    {
        public About()
        {
            InitializeComponent();
            LoadStatus();
        }
        private void LoadStatus()
        {
            bool chpass = checkPassword(AppResources.AppConstants.GetAppPassword());
            if (chpass == true)
            {
               label_SoftwareStatus.Text = "Software is activated";
            }
            else
            {
                label_SoftwareStatus.Text = "You are using a trial version. " + DayRemaining() + " days remaining.";
            }
        }
        private bool checkPassword(String pass)
        {
            RegistryKey regkey = Registry.CurrentUser;
            regkey = regkey.CreateSubKey(AppResources.AppConstants.GetGlobalPath()); //path
            string Br = (string)regkey.GetValue("Password");
            if (Br == pass)
                return true; //good
            else
                return false;//bad
        }
        private string DayRemaining()
        {
            // get present date from system
            DateTime dt = DateTime.Now;
            string today = dt.ToShortDateString();
            DateTime presentDate = Convert.ToDateTime(today);

            // get instalation date
            RegistryKey regkey = Registry.CurrentUser;
            regkey = regkey.CreateSubKey(AppResources.AppConstants.GetGlobalPath()); //path
            string Br = (string)regkey.GetValue("Install");
            DateTime installationDate = Convert.ToDateTime(Br);

            TimeSpan diff = presentDate.Subtract(installationDate); //first.Subtract(second);
            int totaldays = (int)diff.TotalDays;

            // special check if user chenge date in system
            string usd = (string)regkey.GetValue("Use");
            DateTime lastUse = Convert.ToDateTime(usd);
            TimeSpan diff1 = presentDate.Subtract(lastUse); //first.Subtract(second);
            int useBetween = (int)diff1.TotalDays;

            // put next use day in registry
            regkey.SetValue("Use", today); //Value Name,Value Data

            if (useBetween >= 0)
            {

                if (totaldays < 0)
                    return "Error"; // if user change date in system like date set before installation
                else if (totaldays >= 0 && totaldays <= AppResources.AppConstants.GetTrialPeriod())
                    return Convert.ToString(AppResources.AppConstants.GetTrialPeriod() - totaldays); //how many days remaining
                else
                    return "Expired"; //Expired
            }
            else
                return "Error"; // if user change date in system
        }
    }
}
