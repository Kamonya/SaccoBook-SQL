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

namespace SaccoBook.Modules.Loans
{
    public partial class LoanGuarantor : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string LoanId = null;
        public LoanGuarantor()
        {
            InitializeComponent();
        }
        public LoanGuarantor(string _LoanId)
        {
            InitializeComponent();
            LoanId = _LoanId;
        }

        private void btn_save_ItemClick(object sender, ItemClickEventArgs e)
        {
            byte[] Photo = null;

            string filename = Application.StartupPath + @"\Photos\Portrait_Placeholder.png";
            Image img = Image.FromFile(filename);
            Photo = ImageToByteArray(img);

            if (EF.LoansQueries.CreateGuarantor(LoanId, _IdNumber.Text, _Name.Text, _DateOfBirth.Text, "", true, false, false, Photo, Photo, "", "", "", "", _Phone.Text, "", _Address.Text, _Email.Text, "", "", "", "", "", "", Convert.ToDouble(_AmountGuaranteed.Text)))
            {
                //send Guarantor SMS

                XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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