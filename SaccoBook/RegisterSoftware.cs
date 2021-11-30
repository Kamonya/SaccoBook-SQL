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
using Microsoft.Win32;

namespace SaccoBook
{
    public partial class RegisterSoftware : DevExpress.XtraEditors.XtraForm
    {
        string _AppPassword;
        string _GlobalPath;
        public RegisterSoftware()
        {
            InitializeComponent();
        }
        public RegisterSoftware(string AppPassword, string GlobalPath)
        {
            InitializeComponent();
            _AppPassword = AppPassword;
            _GlobalPath = GlobalPath;
        }
        public bool passwordEntry(String originalPass, String pass)
        {
            if (originalPass == pass)
            {
                RegistryKey regkey = Registry.CurrentUser;
                regkey = regkey.CreateSubKey(_GlobalPath); //path

                if (regkey != null)
                {
                    regkey.SetValue("Password", pass); //Value Name,Value Data
                }
                return true;
            }
            else
                return false;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            bool value = passwordEntry(_AppPassword, txt_regkey.Text);
            if (value == true)
            {
                XtraMessageBox.Show("Thank you for activation!", "Activate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                this.btn_register.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.DialogResult = DialogResult.OK;
            }
            else
                XtraMessageBox.Show("Product Key is not valid! Please Enter a valid Product Key!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}