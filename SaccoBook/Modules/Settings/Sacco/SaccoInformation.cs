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
using System.IO;
using System.Data.SqlClient;
using Newtonsoft.Json.Linq;

namespace SaccoBook.Modules.Settings.Sacco
{
    public partial class SaccoInformation : DevExpress.XtraEditors.XtraForm
    {
        bool SystemSettingsExist = false;
        public SaccoInformation()
        {
            InitializeComponent();

            LoadSaccoInformation();

            if (EF.SystemSettingsQueries.HasSystemSettings())
            {
                SystemSettingsExist = true;
            }
        }

        private void LoadSaccoInformation()
        {
            string GetSaccoInfoJSON = EF.SystemSettingsQueries.GetSystemSettings();
            dynamic jsonSaccoInfo = JObject.Parse(GetSaccoInfoJSON);

            _Name.Text = jsonSaccoInfo.Name;
            _Address.Text = jsonSaccoInfo.Address;
            _Address2.Text = jsonSaccoInfo.Address2;
            _PostCode.Text = jsonSaccoInfo.PostCode;
            _City.Text = jsonSaccoInfo.City;
            _Country.Text = jsonSaccoInfo.Country;
            _PhoneNumber.Text = jsonSaccoInfo.Phone;
            _FaxNo.Text = jsonSaccoInfo.Fax;
            _Email.Text = jsonSaccoInfo.Email;
            _HomePage.Text = jsonSaccoInfo.HomePage;
            _Logo.EditValue = null;

            byte[] img = jsonSaccoInfo.Photo;

            if (img == null)
                _Logo.Image = null;
            else
            {
                MemoryStream mstream = new MemoryStream(img);
                _Logo.Image = System.Drawing.Image.FromStream(mstream);
            }           
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate().Equals(true))
            {
                if (!SystemSettingsExist)
                {
                    save();
                }
                else
                {
                    update();
                }
            }
        }

        private void save()
        {
            byte[] Photo = null;

            if (_Logo.EditValue != null)
            {
                MemoryStream stream = new MemoryStream();
                Photo = ImageToByteArray(_Logo.Image);
            }
            else
            {
                //get temp photo
                string filename = Application.StartupPath + @"\Photos\Portrait_Placeholder.png";
                Image img = Image.FromFile(filename);
                Photo = ImageToByteArray(img);
            }
            string Name = _Name.Text.Trim();
            string Address = _Address.Text.Trim();
            string Address2 = _Address2.Text.Trim();
            string PostCode = _PostCode.Text.Trim();
            string City = _City.Text.Trim();
            string Country = _Country.Text.Trim();
            string Phone = _PhoneNumber.Text.Trim();
            string Fax = _FaxNo.Text.Trim();
            string Email = _Email.Text.Trim();
            string HomePage = _HomePage.Text.Trim(); //Uri.IsWellFormedUriString(YourURLString, UriKind.RelativeOrAbsolute)
            string AfricasTalkingUsername = "";
            string AfricasTalkingAPIKey = "";
            bool SMSNotificationsEnabled = false;
            string SMTPServer = "";
            string SMTPServerPort = "";
            string UserId = "";
            string Password = "";
            bool EmailNotificationsEnabled = false;
            bool AutomaticDatabaseBackUpEnabled = false;
            string DatabaseBackUpPath = "";
            string CredentialType = "";
            string LastModifiedBy = Login.LoggedInUser;
            string LastModifiedAt = DateTime.Now.ToString();

            if (EF.SystemSettingsQueries.CreateSaccoInformation(Name, Address, Address2, PostCode, City, Country, Phone, Fax, Email, HomePage,  Photo, AfricasTalkingUsername, AfricasTalkingAPIKey, SMSNotificationsEnabled, SMTPServer, SMTPServerPort, UserId, Password, EmailNotificationsEnabled, AutomaticDatabaseBackUpEnabled, DatabaseBackUpPath, CredentialType, LastModifiedBy, LastModifiedAt))
            {
                XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void update()
        {
            byte[] Photo = null;

            if (_Logo.EditValue != null)
            {
                MemoryStream stream = new MemoryStream();
                Photo = ImageToByteArray(_Logo.Image);
            }
            else
            {
                //get temp photo
                string filename = Application.StartupPath + @"\Photos\Portrait_Placeholder.png";
                Image img = Image.FromFile(filename);
                Photo = ImageToByteArray(img);
            }

            string Name = _Name.Text.Trim();
            string Address = _Address.Text.Trim();
            string Address2 = _Address2.Text.Trim();
            string PostCode = _PostCode.Text.Trim();
            string City = _City.Text.Trim();
            string Country = _Country.Text.Trim();
            string Phone = _PhoneNumber.Text.Trim();
            string Fax = _FaxNo.Text.Trim();
            string Email = _Email.Text.Trim();
            string HomePage = _HomePage.Text.Trim();           

            if (EF.SystemSettingsQueries.UpdateSaccoInformation(Name, Address, Address2, PostCode, City, Country, Phone, Fax, Email, HomePage, Photo))
            {
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