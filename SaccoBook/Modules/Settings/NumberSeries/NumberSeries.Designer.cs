namespace SaccoBook.Modules.Settings.NumberSeries
{
    partial class NumberSeries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumberSeries));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Sorting sorting1 = new DevExpress.DataAccess.Sql.Sorting();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_definenumberseries = new DevExpress.XtraBars.BarButtonItem();
            this.btn_editnumberseries = new DevExpress.XtraBars.BarButtonItem();
            this.btn_assign_no_series = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControlNumberSeries = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridViewNumberSeries = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartingNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndingNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastUsedNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNumberSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNumberSeries)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btn_definenumberseries,
            this.btn_editnumberseries,
            this.btn_assign_no_series});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(770, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_definenumberseries
            // 
            this.btn_definenumberseries.Caption = "New";
            this.btn_definenumberseries.Id = 1;
            this.btn_definenumberseries.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_definenumberseries.ImageOptions.Image")));
            this.btn_definenumberseries.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_definenumberseries.ImageOptions.LargeImage")));
            this.btn_definenumberseries.Name = "btn_definenumberseries";
            this.btn_definenumberseries.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_definenumberseries_ItemClick);
            // 
            // btn_editnumberseries
            // 
            this.btn_editnumberseries.Caption = "Edit";
            this.btn_editnumberseries.Id = 2;
            this.btn_editnumberseries.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_editnumberseries.ImageOptions.Image")));
            this.btn_editnumberseries.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_editnumberseries.ImageOptions.LargeImage")));
            this.btn_editnumberseries.Name = "btn_editnumberseries";
            // 
            // btn_assign_no_series
            // 
            this.btn_assign_no_series.Caption = "Assign Number Series";
            this.btn_assign_no_series.Id = 3;
            this.btn_assign_no_series.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_assign_no_series.ImageOptions.Image")));
            this.btn_assign_no_series.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_assign_no_series.ImageOptions.LargeImage")));
            this.btn_assign_no_series.Name = "btn_assign_no_series";
            this.btn_assign_no_series.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_assign_no_series_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_definenumberseries);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "New";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_assign_no_series);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Assign";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_editnumberseries);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Edit";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 370);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(770, 31);
            // 
            // gridControlNumberSeries
            // 
            this.gridControlNumberSeries.DataMember = "numberseries";
            this.gridControlNumberSeries.DataSource = this.sqlDataSource1;
            this.gridControlNumberSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNumberSeries.Location = new System.Drawing.Point(0, 143);
            this.gridControlNumberSeries.MainView = this.gridViewNumberSeries;
            this.gridControlNumberSeries.MenuManager = this.ribbon;
            this.gridControlNumberSeries.Name = "gridControlNumberSeries";
            this.gridControlNumberSeries.Size = new System.Drawing.Size(770, 227);
            this.gridControlNumberSeries.TabIndex = 8;
            this.gridControlNumberSeries.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNumberSeries});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "SaccoBookConnection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "Code";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"191\" />";
            table1.Name = "numberseries";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "Description";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "StartingNumber";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "EndingNumber";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "LastUsedNumber";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "LastModifiedBy";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "LastModifiedAt";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Name = "numberseries";
            sorting1.Direction = System.ComponentModel.ListSortDirection.Descending;
            columnExpression8.ColumnName = "LastModifiedAt";
            columnExpression8.Table = table1;
            sorting1.Expression = columnExpression8;
            selectQuery1.Sorting.Add(sorting1);
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridViewNumberSeries
            // 
            this.gridViewNumberSeries.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colDescription,
            this.colStartingNumber,
            this.colEndingNumber,
            this.colLastUsedNumber,
            this.colLastModifiedBy,
            this.colLastModifiedAt});
            this.gridViewNumberSeries.GridControl = this.gridControlNumberSeries;
            this.gridViewNumberSeries.Name = "gridViewNumberSeries";
            this.gridViewNumberSeries.OptionsBehavior.Editable = false;
            this.gridViewNumberSeries.OptionsFind.AlwaysVisible = true;
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // colStartingNumber
            // 
            this.colStartingNumber.FieldName = "StartingNumber";
            this.colStartingNumber.Name = "colStartingNumber";
            this.colStartingNumber.Visible = true;
            this.colStartingNumber.VisibleIndex = 2;
            // 
            // colEndingNumber
            // 
            this.colEndingNumber.FieldName = "EndingNumber";
            this.colEndingNumber.Name = "colEndingNumber";
            this.colEndingNumber.Visible = true;
            this.colEndingNumber.VisibleIndex = 3;
            // 
            // colLastUsedNumber
            // 
            this.colLastUsedNumber.FieldName = "LastUsedNumber";
            this.colLastUsedNumber.Name = "colLastUsedNumber";
            this.colLastUsedNumber.Visible = true;
            this.colLastUsedNumber.VisibleIndex = 4;
            // 
            // colLastModifiedBy
            // 
            this.colLastModifiedBy.FieldName = "LastModifiedBy";
            this.colLastModifiedBy.Name = "colLastModifiedBy";
            this.colLastModifiedBy.Visible = true;
            this.colLastModifiedBy.VisibleIndex = 5;
            // 
            // colLastModifiedAt
            // 
            this.colLastModifiedAt.FieldName = "LastModifiedAt";
            this.colLastModifiedAt.Name = "colLastModifiedAt";
            this.colLastModifiedAt.Visible = true;
            this.colLastModifiedAt.VisibleIndex = 6;
            // 
            // NumberSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 401);
            this.Controls.Add(this.gridControlNumberSeries);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NumberSeries";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Number Series";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNumberSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNumberSeries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btn_definenumberseries;
        private DevExpress.XtraBars.BarButtonItem btn_editnumberseries;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.GridControl gridControlNumberSeries;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNumberSeries;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colStartingNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colEndingNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUsedNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModifiedAt;
        private DevExpress.XtraBars.BarButtonItem btn_assign_no_series;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}