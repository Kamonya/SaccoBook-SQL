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
using DevExpress.XtraSplashScreen;

namespace SaccoBook.Modules.SaccoMembers.Kins
{
    public partial class KinInformation : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        bool _Edit = false;
        public KinInformation()
        {
            InitializeComponent();
        }
        public KinInformation(string MembershipNumber)
        {
            InitializeComponent();
            LoadMemberInformation(MembershipNumber);
        }
        public KinInformation(string MembershipNumber, string KinIdentificationDocumentNumber, bool Edit)
        {
            InitializeComponent();
            _Edit = Edit;
            LoadMemberInformation(MembershipNumber);
            LoadKinInformation(KinIdentificationDocumentNumber);
        }

        private void LoadKinInformation(string kinIdentificationDocumentNumber)
        {
            string GetKinInfoJSON = EF.KinsQueries.GetKinInfo(kinIdentificationDocumentNumber);
            dynamic jsonGetKinInfo = JObject.Parse(GetKinInfoJSON);

            _IdentificationDocumentNumber.Text = jsonGetKinInfo.IdentificationDocumentNumber;
            _KinFirstName.Text = jsonGetKinInfo.FirstName;
            _KinMiddleName.Text = jsonGetKinInfo.MiddleName;
            _KinLastName.Text = jsonGetKinInfo.LastName;
            _KinEmail.Text = jsonGetKinInfo.Email;
            _KinPhoneNumber.Text = jsonGetKinInfo.PhoneNumber;
            _KinRelationship.Text = jsonGetKinInfo.Relationship;
            _KinOccupation.Text = jsonGetKinInfo.Occupation;
        }

        private void LoadMemberInformation(string MembershipNumber)
        {
            SplashScreenManager.ShowForm(this, typeof(AppWaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Please wait");
            SplashScreenManager.Default.SetWaitFormDescription("Loading...");

            string GetMemberInfoJSON = EF.MemberQueries.GetMemberInfo(MembershipNumber);
            dynamic jsonGetMemberInfo = JObject.Parse(GetMemberInfoJSON);

            _MembershipNumber.Text = MembershipNumber;
            _Name.Text = jsonGetMemberInfo.Name;
            _FirstName.Text = jsonGetMemberInfo.FirstName;
            _MiddleName.Text = jsonGetMemberInfo.MiddleName;
            _LastName.Text = jsonGetMemberInfo.LastName;
            _DateOfBirth.Text = jsonGetMemberInfo.DateOfBirth;
            _Gender.Text = jsonGetMemberInfo.Gender;
            _Nationality.Text = jsonGetMemberInfo.Nationality;
            _NationalIdNumber.Text = jsonGetMemberInfo.NationalIdNumber;
            _TaxPIN.Text = jsonGetMemberInfo.TaxPIN;
            _DateJoined.Text = jsonGetMemberInfo.DateJoined;
            _MembershipStatus.Text = jsonGetMemberInfo.MembershipStatus;

            SplashScreenManager.CloseForm();
        }

        private void btn_save_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dxValidationProvider1.Validate().Equals(true))
            {
                if(_Edit == true)
                {
                    if (EF.KinsQueries.UpdateKin(_IdentificationDocumentNumber.Text, _MembershipNumber.Text, _KinFirstName.Text, _KinMiddleName.Text, _KinLastName.Text, _KinEmail.Text, _KinPhoneNumber.Text, _KinRelationship.Text, _KinOccupation.Text, Login.LoggedInUser, DateTime.Now.ToString()))
                    {
                        XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (EF.KinsQueries.CreateKin(_IdentificationDocumentNumber.Text, _MembershipNumber.Text, _KinFirstName.Text, _KinMiddleName.Text, _KinLastName.Text, _KinEmail.Text, _KinPhoneNumber.Text, _KinRelationship.Text, _KinOccupation.Text, Login.LoggedInUser, DateTime.Now.ToString()))
                    {
                        XtraMessageBox.Show("Information has been successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
               
            }
        }
    }
}