namespace SaccoBook.Modules.Settings.UserRoles
{
    partial class DefineRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefineRole));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_newRole = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRoleId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsMasterAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanAddUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanAddKin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanViewMemberProfile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanEditUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanDeleteUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanAddSavings = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanAddWithdrawal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanAddBulkSavings = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanAddLoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanAddLoanRepayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanViewRepaymentHistory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanViewLoanGuarantors = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanEditLoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanDeleteLoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanAddShares = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanViewShares = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanAddExpenses = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanEditExpenses = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanDeleteExpenses = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btn_newRole,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(955, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btn_newRole
            // 
            this.btn_newRole.Caption = "New Role";
            this.btn_newRole.Id = 1;
            this.btn_newRole.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btn_newRole.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btn_newRole.Name = "btn_newRole";
            this.btn_newRole.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_newRole_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Edit";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Delete";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Refresh";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Previous";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Next";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Print";
            this.barButtonItem7.Id = 8;
            this.barButtonItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.barButtonItem7.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Close";
            this.barButtonItem8.Id = 9;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_newRole);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "New";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Edit";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Delete";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Refresh";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Navigate";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Print";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.AllowTextClipping = false;
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Close";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 435);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(955, 31);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Query";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 143);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(955, 292);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "SaccoBookConnection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRoleId,
            this.colCanLogin,
            this.colIsMasterAdmin,
            this.colCanAddUser,
            this.colCanAddKin,
            this.colCanViewMemberProfile,
            this.colCanEditUser,
            this.colCanDeleteUser,
            this.colCanAddSavings,
            this.colCanAddWithdrawal,
            this.colCanAddBulkSavings,
            this.colCanAddLoan,
            this.colCanAddLoanRepayment,
            this.colCanViewRepaymentHistory,
            this.colCanViewLoanGuarantors,
            this.colCanEditLoan,
            this.colCanDeleteLoan,
            this.colCanAddShares,
            this.colCanViewShares,
            this.colCanAddExpenses,
            this.colCanEditExpenses,
            this.colCanDeleteExpenses});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsClipboard.AllowCsvFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsClipboard.AllowExcelFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colRoleId
            // 
            this.colRoleId.FieldName = "RoleId";
            this.colRoleId.Name = "colRoleId";
            this.colRoleId.Visible = true;
            this.colRoleId.VisibleIndex = 0;
            // 
            // colCanLogin
            // 
            this.colCanLogin.FieldName = "CanLogin";
            this.colCanLogin.Name = "colCanLogin";
            this.colCanLogin.Visible = true;
            this.colCanLogin.VisibleIndex = 1;
            // 
            // colIsMasterAdmin
            // 
            this.colIsMasterAdmin.FieldName = "IsMasterAdmin";
            this.colIsMasterAdmin.Name = "colIsMasterAdmin";
            this.colIsMasterAdmin.Visible = true;
            this.colIsMasterAdmin.VisibleIndex = 2;
            // 
            // colCanAddUser
            // 
            this.colCanAddUser.FieldName = "CanAddUser";
            this.colCanAddUser.Name = "colCanAddUser";
            this.colCanAddUser.Visible = true;
            this.colCanAddUser.VisibleIndex = 3;
            // 
            // colCanAddKin
            // 
            this.colCanAddKin.FieldName = "CanAddKin";
            this.colCanAddKin.Name = "colCanAddKin";
            this.colCanAddKin.Visible = true;
            this.colCanAddKin.VisibleIndex = 4;
            // 
            // colCanViewMemberProfile
            // 
            this.colCanViewMemberProfile.FieldName = "CanViewMemberProfile";
            this.colCanViewMemberProfile.Name = "colCanViewMemberProfile";
            this.colCanViewMemberProfile.Visible = true;
            this.colCanViewMemberProfile.VisibleIndex = 5;
            // 
            // colCanEditUser
            // 
            this.colCanEditUser.FieldName = "CanEditUser";
            this.colCanEditUser.Name = "colCanEditUser";
            this.colCanEditUser.Visible = true;
            this.colCanEditUser.VisibleIndex = 6;
            // 
            // colCanDeleteUser
            // 
            this.colCanDeleteUser.FieldName = "CanDeleteUser";
            this.colCanDeleteUser.Name = "colCanDeleteUser";
            this.colCanDeleteUser.Visible = true;
            this.colCanDeleteUser.VisibleIndex = 7;
            // 
            // colCanAddSavings
            // 
            this.colCanAddSavings.FieldName = "CanAddSavings";
            this.colCanAddSavings.Name = "colCanAddSavings";
            this.colCanAddSavings.Visible = true;
            this.colCanAddSavings.VisibleIndex = 8;
            // 
            // colCanAddWithdrawal
            // 
            this.colCanAddWithdrawal.FieldName = "CanAddWithdrawal";
            this.colCanAddWithdrawal.Name = "colCanAddWithdrawal";
            this.colCanAddWithdrawal.Visible = true;
            this.colCanAddWithdrawal.VisibleIndex = 9;
            // 
            // colCanAddBulkSavings
            // 
            this.colCanAddBulkSavings.FieldName = "CanAddBulkSavings";
            this.colCanAddBulkSavings.Name = "colCanAddBulkSavings";
            this.colCanAddBulkSavings.Visible = true;
            this.colCanAddBulkSavings.VisibleIndex = 10;
            // 
            // colCanAddLoan
            // 
            this.colCanAddLoan.FieldName = "CanAddLoan";
            this.colCanAddLoan.Name = "colCanAddLoan";
            this.colCanAddLoan.Visible = true;
            this.colCanAddLoan.VisibleIndex = 11;
            // 
            // colCanAddLoanRepayment
            // 
            this.colCanAddLoanRepayment.FieldName = "CanAddLoanRepayment";
            this.colCanAddLoanRepayment.Name = "colCanAddLoanRepayment";
            this.colCanAddLoanRepayment.Visible = true;
            this.colCanAddLoanRepayment.VisibleIndex = 12;
            // 
            // colCanViewRepaymentHistory
            // 
            this.colCanViewRepaymentHistory.FieldName = "CanViewRepaymentHistory";
            this.colCanViewRepaymentHistory.Name = "colCanViewRepaymentHistory";
            this.colCanViewRepaymentHistory.Visible = true;
            this.colCanViewRepaymentHistory.VisibleIndex = 13;
            // 
            // colCanViewLoanGuarantors
            // 
            this.colCanViewLoanGuarantors.FieldName = "CanViewLoanGuarantors";
            this.colCanViewLoanGuarantors.Name = "colCanViewLoanGuarantors";
            this.colCanViewLoanGuarantors.Visible = true;
            this.colCanViewLoanGuarantors.VisibleIndex = 14;
            // 
            // colCanEditLoan
            // 
            this.colCanEditLoan.FieldName = "CanEditLoan";
            this.colCanEditLoan.Name = "colCanEditLoan";
            this.colCanEditLoan.Visible = true;
            this.colCanEditLoan.VisibleIndex = 15;
            // 
            // colCanDeleteLoan
            // 
            this.colCanDeleteLoan.FieldName = "CanDeleteLoan";
            this.colCanDeleteLoan.Name = "colCanDeleteLoan";
            this.colCanDeleteLoan.Visible = true;
            this.colCanDeleteLoan.VisibleIndex = 16;
            // 
            // colCanAddShares
            // 
            this.colCanAddShares.FieldName = "CanAddShares";
            this.colCanAddShares.Name = "colCanAddShares";
            this.colCanAddShares.Visible = true;
            this.colCanAddShares.VisibleIndex = 17;
            // 
            // colCanViewShares
            // 
            this.colCanViewShares.FieldName = "CanViewShares";
            this.colCanViewShares.Name = "colCanViewShares";
            this.colCanViewShares.Visible = true;
            this.colCanViewShares.VisibleIndex = 18;
            // 
            // colCanAddExpenses
            // 
            this.colCanAddExpenses.FieldName = "CanAddExpenses";
            this.colCanAddExpenses.Name = "colCanAddExpenses";
            this.colCanAddExpenses.Visible = true;
            this.colCanAddExpenses.VisibleIndex = 19;
            // 
            // colCanEditExpenses
            // 
            this.colCanEditExpenses.FieldName = "CanEditExpenses";
            this.colCanEditExpenses.Name = "colCanEditExpenses";
            this.colCanEditExpenses.Visible = true;
            this.colCanEditExpenses.VisibleIndex = 20;
            // 
            // colCanDeleteExpenses
            // 
            this.colCanDeleteExpenses.FieldName = "CanDeleteExpenses";
            this.colCanDeleteExpenses.Name = "colCanDeleteExpenses";
            this.colCanDeleteExpenses.Visible = true;
            this.colCanDeleteExpenses.VisibleIndex = 21;
            // 
            // DefineRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 466);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DefineRole";
            this.Ribbon = this.ribbonControl1;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Define User Role";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btn_newRole;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleId;
        private DevExpress.XtraGrid.Columns.GridColumn colCanLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colIsMasterAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn colCanAddUser;
        private DevExpress.XtraGrid.Columns.GridColumn colCanAddKin;
        private DevExpress.XtraGrid.Columns.GridColumn colCanViewMemberProfile;
        private DevExpress.XtraGrid.Columns.GridColumn colCanEditUser;
        private DevExpress.XtraGrid.Columns.GridColumn colCanDeleteUser;
        private DevExpress.XtraGrid.Columns.GridColumn colCanAddSavings;
        private DevExpress.XtraGrid.Columns.GridColumn colCanAddWithdrawal;
        private DevExpress.XtraGrid.Columns.GridColumn colCanAddBulkSavings;
        private DevExpress.XtraGrid.Columns.GridColumn colCanAddLoan;
        private DevExpress.XtraGrid.Columns.GridColumn colCanAddLoanRepayment;
        private DevExpress.XtraGrid.Columns.GridColumn colCanViewRepaymentHistory;
        private DevExpress.XtraGrid.Columns.GridColumn colCanViewLoanGuarantors;
        private DevExpress.XtraGrid.Columns.GridColumn colCanEditLoan;
        private DevExpress.XtraGrid.Columns.GridColumn colCanDeleteLoan;
        private DevExpress.XtraGrid.Columns.GridColumn colCanAddShares;
        private DevExpress.XtraGrid.Columns.GridColumn colCanViewShares;
        private DevExpress.XtraGrid.Columns.GridColumn colCanAddExpenses;
        private DevExpress.XtraGrid.Columns.GridColumn colCanEditExpenses;
        private DevExpress.XtraGrid.Columns.GridColumn colCanDeleteExpenses;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
    }
}