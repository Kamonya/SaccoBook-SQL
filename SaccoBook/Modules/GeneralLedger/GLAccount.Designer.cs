namespace SaccoBook.Modules.GeneralLedger
{
    partial class GLAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GLAccount));
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_save = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._DirectPosting = new DevExpress.XtraEditors.CheckEdit();
            this._AccountType = new DevExpress.XtraEditors.ComboBoxEdit();
            this._ParentGLAccount = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.saccobook_generalledgeraccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this._IsBlocked = new DevExpress.XtraEditors.CheckEdit();
            this._BalanceSheetIncomeStatement = new DevExpress.XtraEditors.ComboBoxEdit();
            this._Name = new DevExpress.XtraEditors.TextEdit();
            this._Description = new DevExpress.XtraEditors.TextEdit();
            this._GLCode = new DevExpress.XtraEditors.TextEdit();
            this._IsParentGLAccount = new System.Windows.Forms.CheckBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProviderGLAccount = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._DirectPosting.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AccountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ParentGLAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saccobook_generalledgeraccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._IsBlocked.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BalanceSheetIncomeStatement.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GLCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderGLAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btn_save});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(614, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_save
            // 
            this.btn_save.Caption = "Save";
            this.btn_save.Id = 1;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.Image")));
            this.btn_save.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.LargeImage")));
            this.btn_save.Name = "btn_save";
            this.btn_save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_save_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_save);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Save";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 420);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(614, 31);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._DirectPosting);
            this.layoutControl1.Controls.Add(this._AccountType);
            this.layoutControl1.Controls.Add(this._ParentGLAccount);
            this.layoutControl1.Controls.Add(this._IsBlocked);
            this.layoutControl1.Controls.Add(this._BalanceSheetIncomeStatement);
            this.layoutControl1.Controls.Add(this._Name);
            this.layoutControl1.Controls.Add(this._Description);
            this.layoutControl1.Controls.Add(this._GLCode);
            this.layoutControl1.Controls.Add(this._IsParentGLAccount);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 143);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(614, 277);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _DirectPosting
            // 
            this._DirectPosting.Location = new System.Drawing.Point(120, 210);
            this._DirectPosting.MenuManager = this.ribbon;
            this._DirectPosting.Name = "_DirectPosting";
            this._DirectPosting.Properties.Caption = "";
            this._DirectPosting.Size = new System.Drawing.Size(470, 19);
            this._DirectPosting.StyleController = this.layoutControl1;
            this._DirectPosting.TabIndex = 13;
            // 
            // _AccountType
            // 
            this._AccountType.Location = new System.Drawing.Point(120, 162);
            this._AccountType.MenuManager = this.ribbon;
            this._AccountType.Name = "_AccountType";
            this._AccountType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._AccountType.Properties.Items.AddRange(new object[] {
            "Posting",
            "Heading",
            "Total",
            "Begin-Total",
            "End-Total"});
            this._AccountType.Size = new System.Drawing.Size(470, 20);
            this._AccountType.StyleController = this.layoutControl1;
            this._AccountType.TabIndex = 12;
            // 
            // _ParentGLAccount
            // 
            this._ParentGLAccount.EditValue = "";
            this._ParentGLAccount.Location = new System.Drawing.Point(120, 66);
            this._ParentGLAccount.MenuManager = this.ribbon;
            this._ParentGLAccount.Name = "_ParentGLAccount";
            this._ParentGLAccount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._ParentGLAccount.Properties.DataSource = this.saccobook_generalledgeraccountsBindingSource;
            this._ParentGLAccount.Properties.DisplayMember = "Name";
            this._ParentGLAccount.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this._ParentGLAccount.Properties.ValueMember = "Code";
            this._ParentGLAccount.Size = new System.Drawing.Size(470, 20);
            this._ParentGLAccount.StyleController = this.layoutControl1;
            this._ParentGLAccount.TabIndex = 11;
            this._ParentGLAccount.EditValueChanged += new System.EventHandler(this._ParentGLAccount_EditValueChanged);
            // 
            // saccobook_generalledgeraccountsBindingSource
            // 
            this.saccobook_generalledgeraccountsBindingSource.DataMember = "saccobook_generalledgeraccounts";
            this.saccobook_generalledgeraccountsBindingSource.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "SaccoBookConnection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "Code";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"324\" />";
            table1.Name = "saccobook.generalledgeraccounts";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "Name";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "AccountType";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "IncomeBalanceSheet";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "DirectPosting";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Name = "saccobook_generalledgeraccounts";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.KeyFieldName = "Code";
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.ParentFieldName = "ParentCode";
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // _IsBlocked
            // 
            this._IsBlocked.Location = new System.Drawing.Point(120, 233);
            this._IsBlocked.MenuManager = this.ribbon;
            this._IsBlocked.Name = "_IsBlocked";
            this._IsBlocked.Properties.Caption = "";
            this._IsBlocked.Size = new System.Drawing.Size(470, 19);
            this._IsBlocked.StyleController = this.layoutControl1;
            this._IsBlocked.TabIndex = 10;
            // 
            // _BalanceSheetIncomeStatement
            // 
            this._BalanceSheetIncomeStatement.Location = new System.Drawing.Point(120, 186);
            this._BalanceSheetIncomeStatement.MenuManager = this.ribbon;
            this._BalanceSheetIncomeStatement.Name = "_BalanceSheetIncomeStatement";
            this._BalanceSheetIncomeStatement.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._BalanceSheetIncomeStatement.Properties.Items.AddRange(new object[] {
            "Income Statement",
            "Balance Sheet"});
            this._BalanceSheetIncomeStatement.Size = new System.Drawing.Size(470, 20);
            this._BalanceSheetIncomeStatement.StyleController = this.layoutControl1;
            this._BalanceSheetIncomeStatement.TabIndex = 9;
            // 
            // _Name
            // 
            this._Name.Location = new System.Drawing.Point(120, 114);
            this._Name.MenuManager = this.ribbon;
            this._Name.Name = "_Name";
            this._Name.Size = new System.Drawing.Size(470, 20);
            this._Name.StyleController = this.layoutControl1;
            this._Name.TabIndex = 7;
            // 
            // _Description
            // 
            this._Description.Location = new System.Drawing.Point(120, 138);
            this._Description.MenuManager = this.ribbon;
            this._Description.Name = "_Description";
            this._Description.Size = new System.Drawing.Size(470, 20);
            this._Description.StyleController = this.layoutControl1;
            this._Description.TabIndex = 6;
            // 
            // _GLCode
            // 
            this._GLCode.Location = new System.Drawing.Point(120, 90);
            this._GLCode.MenuManager = this.ribbon;
            this._GLCode.Name = "_GLCode";
            this._GLCode.Size = new System.Drawing.Size(470, 20);
            this._GLCode.StyleController = this.layoutControl1;
            this._GLCode.TabIndex = 4;
            // 
            // _IsParentGLAccount
            // 
            this._IsParentGLAccount.Location = new System.Drawing.Point(120, 42);
            this._IsParentGLAccount.Name = "_IsParentGLAccount";
            this._IsParentGLAccount.Size = new System.Drawing.Size(470, 20);
            this._IsParentGLAccount.TabIndex = 3;
            this._IsParentGLAccount.UseVisualStyleBackColor = true;
            this._IsParentGLAccount.CheckedChanged += new System.EventHandler(this._IsParentGLAccount_CheckedChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(614, 277);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem8,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem3,
            this.layoutControlItem7,
            this.layoutControlItem9});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(594, 257);
            this.layoutControlGroup1.Text = "General";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._IsParentGLAccount;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(570, 24);
            this.layoutControlItem1.Text = "Is Parent Account:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this._ParentGLAccount;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(570, 24);
            this.layoutControlItem8.Text = "Parent GL Account:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._GLCode;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(570, 24);
            this.layoutControlItem2.Text = "Code:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._Name;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(570, 24);
            this.layoutControlItem5.Text = "Name:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this._Description;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(570, 24);
            this.layoutControlItem4.Text = "Description:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this._AccountType;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(570, 24);
            this.layoutControlItem6.Text = "Account Type:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._BalanceSheetIncomeStatement;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(570, 24);
            this.layoutControlItem3.Text = "Income/Balance:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this._IsBlocked;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 191);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(570, 24);
            this.layoutControlItem7.Text = "Is Blocked:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this._DirectPosting;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(570, 23);
            this.layoutControlItem9.Text = "Direct Posting:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(93, 13);
            // 
            // GLAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 451);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GLAccount";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "GL Account";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._DirectPosting.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AccountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ParentGLAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saccobook_generalledgeraccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._IsBlocked.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BalanceSheetIncomeStatement.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GLCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderGLAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit _Name;
        private DevExpress.XtraEditors.TextEdit _Description;
        private DevExpress.XtraEditors.TextEdit _GLCode;
        private System.Windows.Forms.CheckBox _IsParentGLAccount;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraBars.BarButtonItem btn_save;
        private DevExpress.XtraEditors.CheckEdit _IsBlocked;
        private DevExpress.XtraEditors.ComboBoxEdit _BalanceSheetIncomeStatement;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderGLAccount;
        private DevExpress.XtraEditors.TreeListLookUpEdit _ParentGLAccount;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.ComboBoxEdit _AccountType;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.CheckEdit _DirectPosting;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private System.Windows.Forms.BindingSource saccobook_generalledgeraccountsBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}