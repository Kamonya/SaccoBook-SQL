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
using DevExpress.XtraSplashScreen;

namespace SaccoBook.Modules.SaccoMembers.Beneficiaries
{
    public partial class ViewBeneficiaries : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string _MembershipNumber = null;
        private string _BeneficiaryIdentificationDocumentNumber = null;
        public ViewBeneficiaries()
        {
            InitializeComponent();
        }
        public ViewBeneficiaries(string MembershipNumber)
        {
            InitializeComponent();
            _MembershipNumber = MembershipNumber;
            BeneficiariesGridControl.DataSource = EF.KinsQueries.GetKinsList(_MembershipNumber);
        }

        private void btn_addbeneficiary_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(_MembershipNumber != null)
            {
                BeneficiaryInformation _KinInformation = new BeneficiaryInformation(_MembershipNumber);
                _KinInformation.ShowDialog();
            }
        }

        private void btn_edit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(_BeneficiaryIdentificationDocumentNumber != null)
            {
                BeneficiaryInformation _KinInformation = new BeneficiaryInformation(_MembershipNumber, _BeneficiaryIdentificationDocumentNumber, true);
                _KinInformation.ShowDialog();
            }            
        }

        private void BeneficiariesGridViewView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            _BeneficiaryIdentificationDocumentNumber = AppResources.DevexpressFunctions.GetItemrowClick(BeneficiariesGridView, "IdentificationDocumentNumber");
        }

        private void BeneficiariesGridViewView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _BeneficiaryIdentificationDocumentNumber = AppResources.DevexpressFunctions.GetItemFocusedRowChanged(BeneficiariesGridView, sender, e, "IdentificationDocumentNumber");
        }

        private void btn_delete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dlr = XtraMessageBox.Show("Are you sure you want to delete record?", "System Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlr == DialogResult.Yes)
            {
                if (EF.BeneficiariesQueries.DeleteBeneficiary(_BeneficiaryIdentificationDocumentNumber))
                {
                    XtraMessageBox.Show("The specified record has been successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }            
        }

        private void btn_refresh_ItemClick(object sender, ItemClickEventArgs e)
        {

            SplashScreenManager.ShowForm(this, typeof(AppWaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Please wait");
            SplashScreenManager.Default.SetWaitFormDescription("Refreshing...");
            BeneficiariesGridControl.DataSource = EF.KinsQueries.GetKinsList(_MembershipNumber);
            SplashScreenManager.CloseForm();
        }
    }
}