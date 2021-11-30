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

namespace SaccoBook.Modules.SaccoMembers
{
    public partial class ViewMembersList : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string MembershipNumber = null;

        public ViewMembersList()
        {
            InitializeComponent();
        }
        public ViewMembersList(string status)
        {
            InitializeComponent();
            LoadMembersList(status);
        }

        private void LoadMembersList(string status)
        {
            string sqlMembersList = EF.MemberQueries.LoadMembersList(status);

            AppResources.AppFunctions.LoadTable(gridControlMembersList, gridViewMembersList, sqlMembersList);
        }

        private void btn_viewmemberprofile_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MembershipNumber != null)
            {
                Modules.SaccoMembers.SaccoMemberInformation _SaccoMemberInformation = new Modules.SaccoMembers.SaccoMemberInformation(MembershipNumber);
                _SaccoMemberInformation.ShowDialog();
            }
        }

        private void gridViewMembersList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            MembershipNumber = AppResources.DevexpressFunctions.GetItemFocusedRowChanged(gridViewMembersList, sender, e, "MembershipNumber");
        }

        private void gridViewMembersList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            MembershipNumber = AppResources.DevexpressFunctions.GetItemrowClick(gridViewMembersList, "MembershipNumber");
        }
    }
}