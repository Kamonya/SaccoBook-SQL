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

namespace SaccoBook.Modules.SaccoMembers.GroupMembership
{
    public partial class AddSignatory : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private static string GroupMembershipNo = null;
        private static bool IsEdit = false;
        public AddSignatory()
        {
            InitializeComponent();
        }
        public AddSignatory(string _GroupMembershipNo)
        {
            InitializeComponent();
            GroupMembershipNo = _GroupMembershipNo;
        }

        public AddSignatory(string _GroupMembershipNo, string SignatoryId)
        {
            InitializeComponent();
            GroupMembershipNo = _GroupMembershipNo;
            IsEdit = true;
        }

        private void btn_save_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dxValidationProvider1.Validate().Equals(true))
            {
                byte[] Photo = null;

                string filename = Application.StartupPath + @"\Photos\Portrait_Placeholder.png";
                Image img = Image.FromFile(filename);
                Photo = ImageToByteArray(img);

                if (EF.GroupQueries.CreateSignatory(GroupMembershipNo, _IdNumber.Text, _Name.Text, _DateOfBirth.Text, "", true, false, false, Photo, Photo, "", "", "", "", _Phone.Text, "", _Address.Text, _Email.Text, "", "", "", "", "", ""))
                {
                    XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public byte[] ImageToByteArray(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}