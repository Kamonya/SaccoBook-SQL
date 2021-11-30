﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace SaccoBook.Modules.Settings.Notifications
{
    public partial class DocumentTemplates : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string DocumentId = null;
        public DocumentTemplates()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill();
        }

        private void btn_edit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (DocumentId != null)
            {
                AssignDocumentTemplate _AssignDocumentTemplate = new AssignDocumentTemplate(DocumentId);
                _AssignDocumentTemplate.ShowDialog();
            }           
            
        }

        private void GridViewDocumentTemplates_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DocumentId = AppResources.DevexpressFunctions.GetItemFocusedRowChanged(GridViewDocumentTemplates, sender, e, "Id");
        }

        private void GridViewDocumentTemplates_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DocumentId = AppResources.DevexpressFunctions.GetItemrowClick(GridViewDocumentTemplates, "Id");
        }

        private void btn_create_template_ItemClick(object sender, ItemClickEventArgs e)
        {
            ViewNotificationTemplates _ViewNotificationTemplates = new ViewNotificationTemplates();
            _ViewNotificationTemplates.ShowDialog();
        }
    }
}