namespace SaccoBook.Modules.SavingsWithdrawals.Savings
{
    partial class SavingsAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavingsAccounts));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_savings_account = new DevExpress.XtraBars.BarButtonItem();
            this.btn_refresh = new DevExpress.XtraBars.BarButtonItem();
            this.btn_savingsstatement = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.GridControlSavingsAccounts = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.GridViewSavingsAccounts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAccountType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMembershipNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreditAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebitAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlSavingsAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSavingsAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btn_savings_account,
            this.btn_refresh,
            this.btn_savingsstatement});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(929, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_savings_account
            // 
            this.btn_savings_account.Caption = "New Savings Account";
            this.btn_savings_account.Id = 1;
            this.btn_savings_account.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_savings_account.ImageOptions.Image")));
            this.btn_savings_account.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_savings_account.ImageOptions.LargeImage")));
            this.btn_savings_account.Name = "btn_savings_account";
            this.btn_savings_account.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_savings_account_ItemClick);
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
            // btn_savingsstatement
            // 
            this.btn_savingsstatement.Caption = "View Savings Statement";
            this.btn_savingsstatement.Id = 3;
            this.btn_savingsstatement.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_savingsstatement.ImageOptions.Image")));
            this.btn_savingsstatement.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_savingsstatement.ImageOptions.LargeImage")));
            this.btn_savingsstatement.Name = "btn_savingsstatement";
            this.btn_savingsstatement.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_savingsstatement_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_savings_account);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "New";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_refresh);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Refresh";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_savingsstatement);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Savings Summary";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(929, 31);
            // 
            // GridControlSavingsAccounts
            // 
            this.GridControlSavingsAccounts.DataMember = "membersavingsaccounts";
            this.GridControlSavingsAccounts.DataSource = this.sqlDataSource1;
            this.GridControlSavingsAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlSavingsAccounts.Location = new System.Drawing.Point(0, 143);
            this.GridControlSavingsAccounts.MainView = this.GridViewSavingsAccounts;
            this.GridControlSavingsAccounts.MenuManager = this.ribbon;
            this.GridControlSavingsAccounts.Name = "GridControlSavingsAccounts";
            this.GridControlSavingsAccounts.Size = new System.Drawing.Size(929, 275);
            this.GridControlSavingsAccounts.TabIndex = 2;
            this.GridControlSavingsAccounts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewSavingsAccounts});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "SaccoBookConnection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery4.Name = "membersavingsaccounts";
            customSqlQuery4.Sql = resources.GetString("customSqlQuery4.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery4});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // GridViewSavingsAccounts
            // 
            this.GridViewSavingsAccounts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAccountType,
            this.colAccountName,
            this.colAccountNumber,
            this.colMembershipNumber,
            this.colName,
            this.colCreditAmount,
            this.colDebitAmount,
            this.colBalance});
            this.GridViewSavingsAccounts.GridControl = this.GridControlSavingsAccounts;
            this.GridViewSavingsAccounts.Name = "GridViewSavingsAccounts";
            this.GridViewSavingsAccounts.OptionsBehavior.Editable = false;
            this.GridViewSavingsAccounts.OptionsFind.AlwaysVisible = true;
            this.GridViewSavingsAccounts.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewSavingsAccounts_RowClick);
            this.GridViewSavingsAccounts.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewSavingsAccounts_FocusedRowChanged);
            this.GridViewSavingsAccounts.DoubleClick += new System.EventHandler(this.GridViewSavingsAccounts_DoubleClick);
            // 
            // colAccountType
            // 
            this.colAccountType.FieldName = "AccountType";
            this.colAccountType.Name = "colAccountType";
            this.colAccountType.Visible = true;
            this.colAccountType.VisibleIndex = 0;
            // 
            // colAccountName
            // 
            this.colAccountName.FieldName = "AccountName";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.Visible = true;
            this.colAccountName.VisibleIndex = 1;
            // 
            // colAccountNumber
            // 
            this.colAccountNumber.FieldName = "AccountNumber";
            this.colAccountNumber.Name = "colAccountNumber";
            this.colAccountNumber.Visible = true;
            this.colAccountNumber.VisibleIndex = 2;
            // 
            // colMembershipNumber
            // 
            this.colMembershipNumber.FieldName = "MembershipNumber";
            this.colMembershipNumber.Name = "colMembershipNumber";
            this.colMembershipNumber.Visible = true;
            this.colMembershipNumber.VisibleIndex = 3;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 4;
            // 
            // colCreditAmount
            // 
            this.colCreditAmount.FieldName = "CreditAmount";
            this.colCreditAmount.Name = "colCreditAmount";
            this.colCreditAmount.Visible = true;
            this.colCreditAmount.VisibleIndex = 5;
            // 
            // colDebitAmount
            // 
            this.colDebitAmount.FieldName = "DebitAmount";
            this.colDebitAmount.Name = "colDebitAmount";
            this.colDebitAmount.Visible = true;
            this.colDebitAmount.VisibleIndex = 6;
            // 
            // colBalance
            // 
            this.colBalance.FieldName = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.Visible = true;
            this.colBalance.VisibleIndex = 7;
            // 
            // SavingsAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 449);
            this.Controls.Add(this.GridControlSavingsAccounts);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SavingsAccounts";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Savings Accounts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlSavingsAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSavingsAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl GridControlSavingsAccounts;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewSavingsAccounts;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountType;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountName;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colMembershipNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colBalance;
        private DevExpress.XtraBars.BarButtonItem btn_savings_account;
        private DevExpress.XtraBars.BarButtonItem btn_refresh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_savingsstatement;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}