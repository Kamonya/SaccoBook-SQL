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
using DevExpress.XtraEditors;
using System.IO;

namespace SaccoBook
{
    public partial class Attachments : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        static string Id = null;
        static string FileName = null;
        static string FileExtension = null;
        static string sourcefile = null;
        public Attachments()
        {
            InitializeComponent();
        }
        public Attachments(string DocumentNumber)
        {
            InitializeComponent();
            string sqlAttachments = "SELECT Id, DocumentId, Attachment, FileExtension, FileType, Description, User FROM attachments WHERE DocumentId = '" + DocumentNumber+"'";

            AppResources.AppFunctions.LoadTable(gridControlAttachments, gridViewAttachments, sqlAttachments);
        }

        private void btn_deleteAttachment_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dlr = XtraMessageBox.Show("Are you sure you want to delete record?", "System Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlr == DialogResult.Yes)
            {
                if (Id != null)
                {
                    if (EF.AttachmentsQueries.DeleteAttachment(Convert.ToInt32(Id)))
                    {
                        XtraMessageBox.Show("The specified record has been successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
                      
        }
        private void gridViewAttachments_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Id = AppResources.DevexpressFunctions.GetItemFocusedRowChanged(gridViewAttachments, sender, e, "Id");
            FileName = AppResources.DevexpressFunctions.GetItemFocusedRowChanged(gridViewAttachments, sender, e, "Attachment");
            FileExtension = AppResources.DevexpressFunctions.GetItemFocusedRowChanged(gridViewAttachments, sender, e, "FileExtension");
        }

        private void gridViewAttachments_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Id = AppResources.DevexpressFunctions.GetItemrowClick(gridViewAttachments, "Id");
            FileName = AppResources.DevexpressFunctions.GetItemrowClick(gridViewAttachments, "Attachment");
            FileExtension = AppResources.DevexpressFunctions.GetItemrowClick(gridViewAttachments, "FileExtension");
        }

        private void btn_download_ItemClick(object sender, ItemClickEventArgs e)
        {
            sourcefile = Application.StartupPath + @"\Attachments\" + FileName + FileExtension;

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "All files (*.*)|*.*";

                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName + Path.GetExtension(sourcefile);

                    File.Copy(sourcefile, exportFilePath);

                    if (File.Exists(exportFilePath))
                    {                       
                        DialogResult dlr = XtraMessageBox.Show("The specified file has been successfully downloaded. Do want to view the file?", "System Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dlr == DialogResult.Yes)
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                            
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        XtraMessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }        
    }
}