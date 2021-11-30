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
using Newtonsoft.Json.Linq;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraSplashScreen;
using SaccoBook.AppResources;

namespace SaccoBook.Modules.SaccoMembers.GroupMembership
{
    public partial class GroupMembership : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string _NumberSeriesCode = XMLFormatter.GetContent("MembersNumberSeriesCode");
        private static string GroupMembershipNo = null;
        private static bool IsEdit = false;
        public GroupMembership()
        {
            InitializeComponent();
            GetDocumentNumber(_NumberSeriesCode);
            btn_add_signatory.Enabled = false;
        }
        public GroupMembership(string GroupMembershipNo)
        {
            InitializeComponent();
            LoadGroupInformation(GroupMembershipNo);
            IsEdit = true;
        }

        private void LoadGroupInformation(string groupMembershipNo)
        {
            

            SplashScreenManager.ShowForm(this, typeof(AppWaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Please wait");
            SplashScreenManager.Default.SetWaitFormDescription("Loading...");

            string GetMemberInfoJSON = EF.MemberQueries.GetMemberInfo(groupMembershipNo);
            dynamic jsonGetMemberInfo = JObject.Parse(GetMemberInfoJSON);

            _MembershipNumber.Text = groupMembershipNo;
            GroupMembershipNo = groupMembershipNo;

            _Name.Text = jsonGetMemberInfo.Name;            
            _TaxPIN.Text = jsonGetMemberInfo.TaxPIN;
            _DateJoined.Text = jsonGetMemberInfo.DateJoined;
            _MembershipStatus.Text = jsonGetMemberInfo.MembershipStatus;
            _PhoneNumber.Text = jsonGetMemberInfo.PhoneNumber;
            _AlternativeNumber.Text = jsonGetMemberInfo.AlternativeNumber;
            _Email.Text = jsonGetMemberInfo.Email;
            _Address.Text = jsonGetMemberInfo.Address;
            LoadSignatories(groupMembershipNo);
            SplashScreenManager.CloseForm();
        }

        private void btn_add_signatory_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddSignatory _AddSignatory = new AddSignatory(GroupMembershipNo);
            _AddSignatory.ShowDialog();
        }
        private void GetDocumentNumber(string DocumentNumberSeriesCode)
        {
            string _NumberSeriesData = EF.NumberSeriesQueries.GetNumberSeriesInfo(DocumentNumberSeriesCode);

            dynamic responseObject = JObject.Parse(_NumberSeriesData);
            string LastUsedNumber = responseObject.LastUsedNumber;

            if (LastUsedNumber != "")
            {
                string DocumentNumber = AppResources.AppFunctions.GetNewDocumentNumber(DocumentNumberSeriesCode, LastUsedNumber);
                GroupMembershipNo = DocumentNumber;
                _MembershipNumber.Text = DocumentNumber;
                LoadSignatories(DocumentNumber);
            }
            else
            {
                XtraMessageBox.Show("Encountered an error: The document number series has not been properly configured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppResources.DevexpressFunctions.EnableDisableForm(layoutControl1, true);
            }
        }

        private void btn_save_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!IsEdit)
            {
                if (dxValidationProvider1.Validate().Equals(true))
                {
                    byte[] Photo = null;

                    string filename = Application.StartupPath + @"\Photos\Portrait_Placeholder.png";
                    Image img = Image.FromFile(filename);
                    Photo = ImageToByteArray(img);

                    if (EF.GroupQueries.CreateGroup(_MembershipNumber.Text, _Name.Text, "", "", "", _PhoneNumber.Text, _AlternativeNumber.Text, _Email.Text, "", "", "", "", _TaxPIN.Text, _Address.Text, Photo, "", "", "", "", "", "", "", "", _DateJoined.Text, _MembershipStatus.Text, Login.LoggedInUser, DateTime.Now.ToString()))
                    {
                        //Update number series
                        EF.NumberSeriesQueries.UpdateLastUsedNumberSeries(_NumberSeriesCode, _MembershipNumber.Text);

                        XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                if (dxValidationProvider1.Validate().Equals(true))
                {
                    byte[] Photo = null;

                    string filename = Application.StartupPath + @"\Photos\Portrait_Placeholder.png";
                    Image img = Image.FromFile(filename);
                    Photo = ImageToByteArray(img);

                    if (EF.GroupQueries.UpdateGroup(_MembershipNumber.Text, _Name.Text, "", "", "", _PhoneNumber.Text, _AlternativeNumber.Text, _Email.Text, "", "", "", "", _TaxPIN.Text, _Address.Text, Photo, "", "", "", "", "", "", "", "", _DateJoined.Text, _MembershipStatus.Text, Login.LoggedInUser, DateTime.Now.ToString()))
                    {
                        XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }                    
            }
            
        }
        public byte[] ImageToByteArray(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void LoadSignatories(string groupMembershipNo)
        {
            string sqlSignatories = EF.GroupQueries.LoadSignatories(groupMembershipNo);

            AppResources.AppFunctions.LoadTable(gridControl1, gridView1, sqlSignatories);
        }

        private void btn_refresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadSignatories(GroupMembershipNo);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //edit signatory
            if(GroupMembershipNo != null)
            {
                AddSignatory _AddSignatory = new AddSignatory(GroupMembershipNo);
                _AddSignatory.ShowDialog();
            }           
        }
    }
}