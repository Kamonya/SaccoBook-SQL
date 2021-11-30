namespace SaccoBook.Modules.Settings.Notifications
{
    partial class DocumentTemplates
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentTemplates));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_edit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.GridControlDocumentTemplates = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.GridViewDocumentTemplates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotificationsEnabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSMSTemplate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmailTemplate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_create_template = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlDocumentTemplates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDocumentTemplates)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btn_edit,
            this.btn_create_template});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(925, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_edit
            // 
            this.btn_edit.Caption = "Edit";
            this.btn_edit.Id = 1;
            this.btn_edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.ImageOptions.Image")));
            this.btn_edit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_edit.ImageOptions.LargeImage")));
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_edit_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_edit);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Edit";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 450);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(925, 31);
            // 
            // GridControlDocumentTemplates
            // 
            this.GridControlDocumentTemplates.DataMember = "notificationtemplatesettings";
            this.GridControlDocumentTemplates.DataSource = this.sqlDataSource1;
            this.GridControlDocumentTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlDocumentTemplates.Location = new System.Drawing.Point(0, 143);
            this.GridControlDocumentTemplates.MainView = this.GridViewDocumentTemplates;
            this.GridControlDocumentTemplates.MenuManager = this.ribbon;
            this.GridControlDocumentTemplates.Name = "GridControlDocumentTemplates";
            this.GridControlDocumentTemplates.Size = new System.Drawing.Size(925, 307);
            this.GridControlDocumentTemplates.TabIndex = 2;
            this.GridControlDocumentTemplates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewDocumentTemplates});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "SaccoBookConnection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression6.ColumnName = "Id";
            table3.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"172\" />";
            table3.Name = "saccobook.notificationtemplatesettings";
            columnExpression6.Table = table3;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "Description";
            columnExpression7.Table = table3;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "NotificationsEnabled";
            columnExpression8.Table = table3;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "EmailTemplate";
            table4.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"172\" />";
            table4.Name = "saccobook.notificationtemplates";
            columnExpression9.Table = table4;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "SMSTemplate";
            columnExpression10.Table = table4;
            column10.Expression = columnExpression10;
            selectQuery2.Columns.Add(column6);
            selectQuery2.Columns.Add(column7);
            selectQuery2.Columns.Add(column8);
            selectQuery2.Columns.Add(column9);
            selectQuery2.Columns.Add(column10);
            selectQuery2.Name = "notificationtemplatesettings";
            relationColumnInfo2.NestedKeyColumn = "Id";
            relationColumnInfo2.ParentKeyColumn = "NotificationTemplateId";
            join2.KeyColumns.Add(relationColumnInfo2);
            join2.Nested = table4;
            join2.Parent = table3;
            selectQuery2.Relations.Add(join2);
            selectQuery2.Tables.Add(table3);
            selectQuery2.Tables.Add(table4);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // GridViewDocumentTemplates
            // 
            this.GridViewDocumentTemplates.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDescription,
            this.colNotificationsEnabled,
            this.colSMSTemplate,
            this.colEmailTemplate});
            this.GridViewDocumentTemplates.GridControl = this.GridControlDocumentTemplates;
            this.GridViewDocumentTemplates.Name = "GridViewDocumentTemplates";
            this.GridViewDocumentTemplates.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewDocumentTemplates_RowClick);
            this.GridViewDocumentTemplates.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewDocumentTemplates_FocusedRowChanged);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // colNotificationsEnabled
            // 
            this.colNotificationsEnabled.FieldName = "NotificationsEnabled";
            this.colNotificationsEnabled.Name = "colNotificationsEnabled";
            this.colNotificationsEnabled.Visible = true;
            this.colNotificationsEnabled.VisibleIndex = 2;
            // 
            // colSMSTemplate
            // 
            this.colSMSTemplate.FieldName = "SMSTemplate";
            this.colSMSTemplate.Name = "colSMSTemplate";
            this.colSMSTemplate.Visible = true;
            this.colSMSTemplate.VisibleIndex = 3;
            // 
            // colEmailTemplate
            // 
            this.colEmailTemplate.FieldName = "EmailTemplate";
            this.colEmailTemplate.Name = "colEmailTemplate";
            this.colEmailTemplate.Visible = true;
            this.colEmailTemplate.VisibleIndex = 4;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_create_template);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "New";
            // 
            // btn_create_template
            // 
            this.btn_create_template.Caption = "Create Template";
            this.btn_create_template.Id = 2;
            this.btn_create_template.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btn_create_template.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btn_create_template.Name = "btn_create_template";
            this.btn_create_template.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_create_template_ItemClick);
            // 
            // DocumentTemplates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 481);
            this.Controls.Add(this.GridControlDocumentTemplates);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DocumentTemplates";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Document Templates";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlDocumentTemplates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDocumentTemplates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl GridControlDocumentTemplates;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewDocumentTemplates;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colSMSTemplate;
        private DevExpress.XtraGrid.Columns.GridColumn colEmailTemplate;
        private DevExpress.XtraBars.BarButtonItem btn_edit;
        private DevExpress.XtraGrid.Columns.GridColumn colNotificationsEnabled;
        private DevExpress.XtraBars.BarButtonItem btn_create_template;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}