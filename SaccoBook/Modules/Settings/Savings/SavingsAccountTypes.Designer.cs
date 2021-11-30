namespace SaccoBook.Modules.Settings.Savings
{
    partial class SavingsAccountTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavingsAccountTypes));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.AllColumns allColumns1 = new DevExpress.DataAccess.Sql.AllColumns();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_newAccountType = new DevExpress.XtraBars.BarButtonItem();
            this.btn_refresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControlSavingsAccountTypes = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridViewSavingsAccountTypes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinimumOpeningBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinimumMonthlyContributions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaximumAmountWithdrawableInADay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWithdrawalCharge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSavingsAccountTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSavingsAccountTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btn_newAccountType,
            this.btn_refresh});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(943, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_newAccountType
            // 
            this.btn_newAccountType.Caption = "Add Savings Account Type";
            this.btn_newAccountType.Id = 1;
            this.btn_newAccountType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_newAccountType.ImageOptions.Image")));
            this.btn_newAccountType.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_newAccountType.ImageOptions.LargeImage")));
            this.btn_newAccountType.Name = "btn_newAccountType";
            this.btn_newAccountType.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_newAccountType_ItemClick);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Caption = "Refresh";
            this.btn_refresh.Id = 2;
            this.btn_refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.ImageOptions.Image")));
            this.btn_refresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_refresh.ImageOptions.LargeImage")));
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_refresh_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_newAccountType);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "New";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_refresh);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Refresh";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 359);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(943, 31);
            // 
            // gridControlSavingsAccountTypes
            // 
            this.gridControlSavingsAccountTypes.DataMember = "savingsaccounttypes";
            this.gridControlSavingsAccountTypes.DataSource = this.sqlDataSource1;
            this.gridControlSavingsAccountTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSavingsAccountTypes.Location = new System.Drawing.Point(0, 143);
            this.gridControlSavingsAccountTypes.MainView = this.gridViewSavingsAccountTypes;
            this.gridControlSavingsAccountTypes.MenuManager = this.ribbon;
            this.gridControlSavingsAccountTypes.Name = "gridControlSavingsAccountTypes";
            this.gridControlSavingsAccountTypes.Size = new System.Drawing.Size(943, 216);
            this.gridControlSavingsAccountTypes.TabIndex = 2;
            this.gridControlSavingsAccountTypes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSavingsAccountTypes});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "SaccoBookConnection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"229\" />";
            table1.Name = "saccobook.savingsaccounttypes";
            allColumns1.Table = table1;
            selectQuery1.Columns.Add(allColumns1);
            selectQuery1.Name = "savingsaccounttypes";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridViewSavingsAccountTypes
            // 
            this.gridViewSavingsAccountTypes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colName,
            this.colDescription,
            this.colMinimumOpeningBalance,
            this.colMinimumMonthlyContributions,
            this.colMaximumAmountWithdrawableInADay,
            this.colWithdrawalCharge,
            this.colLastModifiedBy,
            this.colLastModifiedAt});
            this.gridViewSavingsAccountTypes.GridControl = this.gridControlSavingsAccountTypes;
            this.gridViewSavingsAccountTypes.Name = "gridViewSavingsAccountTypes";
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // colMinimumOpeningBalance
            // 
            this.colMinimumOpeningBalance.FieldName = "MinimumOpeningBalance";
            this.colMinimumOpeningBalance.Name = "colMinimumOpeningBalance";
            this.colMinimumOpeningBalance.Visible = true;
            this.colMinimumOpeningBalance.VisibleIndex = 3;
            // 
            // colMinimumMonthlyContributions
            // 
            this.colMinimumMonthlyContributions.FieldName = "MinimumMonthlyContributions";
            this.colMinimumMonthlyContributions.Name = "colMinimumMonthlyContributions";
            this.colMinimumMonthlyContributions.Visible = true;
            this.colMinimumMonthlyContributions.VisibleIndex = 4;
            // 
            // colMaximumAmountWithdrawableInADay
            // 
            this.colMaximumAmountWithdrawableInADay.FieldName = "MaximumAmountWithdrawableInADay";
            this.colMaximumAmountWithdrawableInADay.Name = "colMaximumAmountWithdrawableInADay";
            this.colMaximumAmountWithdrawableInADay.Visible = true;
            this.colMaximumAmountWithdrawableInADay.VisibleIndex = 5;
            // 
            // colWithdrawalCharge
            // 
            this.colWithdrawalCharge.FieldName = "WithdrawalCharge";
            this.colWithdrawalCharge.Name = "colWithdrawalCharge";
            this.colWithdrawalCharge.Visible = true;
            this.colWithdrawalCharge.VisibleIndex = 6;
            // 
            // colLastModifiedBy
            // 
            this.colLastModifiedBy.FieldName = "LastModifiedBy";
            this.colLastModifiedBy.Name = "colLastModifiedBy";
            this.colLastModifiedBy.Visible = true;
            this.colLastModifiedBy.VisibleIndex = 7;
            // 
            // colLastModifiedAt
            // 
            this.colLastModifiedAt.FieldName = "LastModifiedAt";
            this.colLastModifiedAt.Name = "colLastModifiedAt";
            this.colLastModifiedAt.Visible = true;
            this.colLastModifiedAt.VisibleIndex = 8;
            // 
            // SavingsAccountTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 390);
            this.Controls.Add(this.gridControlSavingsAccountTypes);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SavingsAccountTypes";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "SavingsAccountTypes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSavingsAccountTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSavingsAccountTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl gridControlSavingsAccountTypes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSavingsAccountTypes;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colMinimumOpeningBalance;
        private DevExpress.XtraGrid.Columns.GridColumn colMinimumMonthlyContributions;
        private DevExpress.XtraGrid.Columns.GridColumn colMaximumAmountWithdrawableInADay;
        private DevExpress.XtraGrid.Columns.GridColumn colWithdrawalCharge;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModifiedAt;
        private DevExpress.XtraBars.BarButtonItem btn_newAccountType;
        private DevExpress.XtraBars.BarButtonItem btn_refresh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}