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

namespace SaccoBook.Modules.SaccoMembers.Kins
{
    public partial class ViewKins : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string _MembershipNumber = null;
        private string _KinIdentificationDocumentNumber = null;
        public ViewKins()
        {
            InitializeComponent();
        }
        public ViewKins(string MembershipNumber)
        {
            InitializeComponent();
            _MembershipNumber = MembershipNumber;
            KinsGridControl.DataSource = EF.KinsQueries.GetKinsList(_MembershipNumber);
        }

        private void btn_addkin_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(_MembershipNumber != null)
            {
                KinInformation _KinInformation = new KinInformation(_MembershipNumber);
                _KinInformation.ShowDialog();
            }
        }

        private void btn_edit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(_KinIdentificationDocumentNumber != null)
            {
                KinInformation _KinInformation = new KinInformation(_MembershipNumber, _KinIdentificationDocumentNumber, true);
                _KinInformation.ShowDialog();
            }            
        }

        private void KinsGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            _KinIdentificationDocumentNumber = AppResources.DevexpressFunctions.GetItemrowClick(KinsGridView, "IdentificationDocumentNumber");
        }

        private void KinsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _KinIdentificationDocumentNumber = AppResources.DevexpressFunctions.GetItemFocusedRowChanged(KinsGridView, sender, e, "IdentificationDocumentNumber");
        }

        private void btn_delete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dlr = XtraMessageBox.Show("Are you sure you want to delete record?", "System Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlr == DialogResult.Yes)
            {
                if (EF.KinsQueries.DeleteKin(_KinIdentificationDocumentNumber))
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
            KinsGridControl.DataSource = EF.KinsQueries.GetKinsList(_MembershipNumber);
            SplashScreenManager.CloseForm();
        }
    }
}