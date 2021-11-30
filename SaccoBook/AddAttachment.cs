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
using System.IO;
using DevExpress.XtraEditors;

namespace SaccoBook
{
    public partial class AddAttachment : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        static string DocumentNumber = null;
        public AddAttachment()
        {
            InitializeComponent();
        }
        public AddAttachment(string _DocumentNo)
        {
            InitializeComponent();
            DocumentNumber = _DocumentNo;
            _DocumentNumber.Text = DocumentNumber;
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog {};

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _FilePath.Text = ofd.FileName;

                _FileName.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
                _Extension.Text = Path.GetExtension(ofd.FileName);
            }
        }

        private void btn_save_ItemClick(object sender, ItemClickEventArgs e)
        {
            AppResources.AppFunctions.CreateAppFolders();

            if (dxValidationProviderAddAttachment.Validate().Equals(true))
            {
                if (EF.AttachmentsQueries.AddAttachment(_DocumentNumber.Text, _FileName.Text, _Extension.Text, "", _Description.Text, Login.LoggedInUser, Login.LoggedInUser, DateTime.Now.ToString()))
                {
                    // copy file to Attachments Folder

                    string oldfile = _FilePath.Text;
                    string destFile = Application.StartupPath + @"\Attachments\" + _FileName.Text + _Extension.Text;

                    System.IO.File.Copy(oldfile, destFile, true);

                    XtraMessageBox.Show("Information has been successfully saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}