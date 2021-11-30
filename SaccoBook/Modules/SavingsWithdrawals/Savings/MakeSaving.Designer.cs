namespace SaccoBook.Modules.SavingsWithdrawals.Savings
{
    partial class MakeSaving
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeSaving));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery3 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_save = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sendapprovalrequest = new DevExpress.XtraBars.BarButtonItem();
            this.btn_addattachment = new DevExpress.XtraBars.BarButtonItem();
            this.btn_viewattachments = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._Status = new DevExpress.XtraEditors.TextEdit();
            this._ReferenceNumber = new DevExpress.XtraEditors.TextEdit();
            this._DocumentNumber = new DevExpress.XtraEditors.TextEdit();
            this._TransactionDate = new DevExpress.XtraEditors.DateEdit();
            this._Description = new DevExpress.XtraEditors.MemoEdit();
            this._DestinationAccountType = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.membersavingsaccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._Member = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._SourceAccountNumber = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._Source = new DevExpress.XtraEditors.ComboBoxEdit();
            this._DestinationAccount = new DevExpress.XtraEditors.TextEdit();
            this._DestinationAccountBalance = new DevExpress.XtraEditors.TextEdit();
            this._Amount = new DevExpress.XtraEditors.TextEdit();
            this._Name = new DevExpress.XtraEditors.TextEdit();
            this._MembershipNumber = new DevExpress.XtraEditors.TextEdit();
            this._NationalIdNumber = new DevExpress.XtraEditors.TextEdit();
            this._DateJoined = new DevExpress.XtraEditors.DateEdit();
            this._MembershipStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this._Search = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.membersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource3 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup10 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem25 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem26 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem28 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProviderMakeSaving = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ReferenceNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DocumentNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._TransactionDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._TransactionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DestinationAccountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersavingsaccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Member.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._SourceAccountNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Source.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DestinationAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DestinationAccountBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Amount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._MembershipNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._NationalIdNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DateJoined.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DateJoined.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._MembershipStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMakeSaving)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btn_save,
            this.btn_sendapprovalrequest,
            this.btn_addattachment,
            this.btn_viewattachments});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(841, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_save
            // 
            this.btn_save.Caption = "Save";
            this.btn_save.Id = 2;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.Image")));
            this.btn_save.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.LargeImage")));
            this.btn_save.Name = "btn_save";
            this.btn_save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_save_ItemClick);
            // 
            // btn_sendapprovalrequest
            // 
            this.btn_sendapprovalrequest.Caption = "Send for Approval";
            this.btn_sendapprovalrequest.Id = 3;
            this.btn_sendapprovalrequest.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_sendapprovalrequest.ImageOptions.SvgImage")));
            this.btn_sendapprovalrequest.Name = "btn_sendapprovalrequest";
            this.btn_sendapprovalrequest.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_sendapprovalrequest_ItemClick);
            // 
            // btn_addattachment
            // 
            this.btn_addattachment.Caption = "Add Attachment";
            this.btn_addattachment.Id = 4;
            this.btn_addattachment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_addattachment.ImageOptions.Image")));
            this.btn_addattachment.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_addattachment.ImageOptions.LargeImage")));
            this.btn_addattachment.Name = "btn_addattachment";
            this.btn_addattachment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_addattachment_ItemClick);
            // 
            // btn_viewattachments
            // 
            this.btn_viewattachments.Caption = "View Attachments";
            this.btn_viewattachments.Id = 5;
            this.btn_viewattachments.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_viewattachments.ImageOptions.Image")));
            this.btn_viewattachments.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_viewattachments.ImageOptions.LargeImage")));
            this.btn_viewattachments.Name = "btn_viewattachments";
            this.btn_viewattachments.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_viewattachments_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_save);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Save";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_sendapprovalrequest);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Approvals";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Manage";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_addattachment);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_viewattachments, true);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Attachments";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 712);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(841, 31);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._Status);
            this.layoutControl1.Controls.Add(this._ReferenceNumber);
            this.layoutControl1.Controls.Add(this._DocumentNumber);
            this.layoutControl1.Controls.Add(this._TransactionDate);
            this.layoutControl1.Controls.Add(this._Description);
            this.layoutControl1.Controls.Add(this._DestinationAccountType);
            this.layoutControl1.Controls.Add(this._Member);
            this.layoutControl1.Controls.Add(this._SourceAccountNumber);
            this.layoutControl1.Controls.Add(this._Source);
            this.layoutControl1.Controls.Add(this._DestinationAccount);
            this.layoutControl1.Controls.Add(this._DestinationAccountBalance);
            this.layoutControl1.Controls.Add(this._Amount);
            this.layoutControl1.Controls.Add(this._Name);
            this.layoutControl1.Controls.Add(this._MembershipNumber);
            this.layoutControl1.Controls.Add(this._NationalIdNumber);
            this.layoutControl1.Controls.Add(this._DateJoined);
            this.layoutControl1.Controls.Add(this._MembershipStatus);
            this.layoutControl1.Controls.Add(this._Search);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 143);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(841, 569);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _Status
            // 
            this._Status.Location = new System.Drawing.Point(146, 525);
            this._Status.MenuManager = this.ribbon;
            this._Status.Name = "_Status";
            this._Status.Properties.ReadOnly = true;
            this._Status.Size = new System.Drawing.Size(671, 20);
            this._Status.StyleController = this.layoutControl1;
            this._Status.TabIndex = 91;
            // 
            // _ReferenceNumber
            // 
            this._ReferenceNumber.Location = new System.Drawing.Point(146, 390);
            this._ReferenceNumber.MenuManager = this.ribbon;
            this._ReferenceNumber.Name = "_ReferenceNumber";
            this._ReferenceNumber.Size = new System.Drawing.Size(671, 20);
            this._ReferenceNumber.StyleController = this.layoutControl1;
            this._ReferenceNumber.TabIndex = 90;
            // 
            // _DocumentNumber
            // 
            this._DocumentNumber.Location = new System.Drawing.Point(146, 366);
            this._DocumentNumber.MenuManager = this.ribbon;
            this._DocumentNumber.Name = "_DocumentNumber";
            this._DocumentNumber.Properties.ReadOnly = true;
            this._DocumentNumber.Size = new System.Drawing.Size(671, 20);
            this._DocumentNumber.StyleController = this.layoutControl1;
            this._DocumentNumber.TabIndex = 89;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value must be specified";
            this.dxValidationProviderMakeSaving.SetValidationRule(this._DocumentNumber, conditionValidationRule1);
            // 
            // _TransactionDate
            // 
            this._TransactionDate.EditValue = null;
            this._TransactionDate.Location = new System.Drawing.Point(146, 414);
            this._TransactionDate.MenuManager = this.ribbon;
            this._TransactionDate.Name = "_TransactionDate";
            this._TransactionDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._TransactionDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._TransactionDate.Properties.Mask.BeepOnError = true;
            this._TransactionDate.Properties.Mask.EditMask = "yyyy-MM-d";
            this._TransactionDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this._TransactionDate.Size = new System.Drawing.Size(671, 20);
            this._TransactionDate.StyleController = this.layoutControl1;
            this._TransactionDate.TabIndex = 88;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value must be specified";
            this.dxValidationProviderMakeSaving.SetValidationRule(this._TransactionDate, conditionValidationRule2);
            // 
            // _Description
            // 
            this._Description.Location = new System.Drawing.Point(146, 438);
            this._Description.MenuManager = this.ribbon;
            this._Description.Name = "_Description";
            this._Description.Size = new System.Drawing.Size(671, 83);
            this._Description.StyleController = this.layoutControl1;
            this._Description.TabIndex = 87;
            // 
            // _DestinationAccountType
            // 
            this._DestinationAccountType.EditValue = "";
            this._DestinationAccountType.Location = new System.Drawing.Point(566, 228);
            this._DestinationAccountType.MenuManager = this.ribbon;
            this._DestinationAccountType.Name = "_DestinationAccountType";
            this._DestinationAccountType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._DestinationAccountType.Properties.DataSource = this.membersavingsaccountsBindingSource;
            this._DestinationAccountType.Properties.DisplayMember = "AccountName";
            this._DestinationAccountType.Properties.NullText = "";
            this._DestinationAccountType.Properties.PopupView = this.searchLookUpEdit1View;
            this._DestinationAccountType.Properties.ValueMember = "AccountNumber";
            this._DestinationAccountType.Size = new System.Drawing.Size(251, 20);
            this._DestinationAccountType.StyleController = this.layoutControl1;
            this._DestinationAccountType.TabIndex = 86;
            this._DestinationAccountType.EditValueChanged += new System.EventHandler(this._DestinationAccountType_EditValueChanged);
            // 
            // membersavingsaccountsBindingSource
            // 
            this.membersavingsaccountsBindingSource.DataMember = "membersavingsaccounts";
            this.membersavingsaccountsBindingSource.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "SaccoBookConnection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "Name";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"571\" />";
            table1.Name = "saccobook.members";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "AccountNumber";
            table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"267\" />";
            table2.Name = "saccobook.membersavingsaccounts";
            columnExpression2.Table = table2;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "AccountName";
            columnExpression3.Table = table2;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "Balance";
            columnExpression4.Table = table2;
            column4.Expression = columnExpression4;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.FilterString = "[saccobook.members.MembershipNumber] = ?MembershipNumberParameter And [saccobook." +
    "membersavingsaccounts.Status] = \'Active\'";
            selectQuery1.GroupFilterString = "";
            selectQuery1.Name = "membersavingsaccounts";
            queryParameter1.Name = "MembershipNumberParameter";
            queryParameter1.Type = typeof(string);
            selectQuery1.Parameters.Add(queryParameter1);
            relationColumnInfo1.NestedKeyColumn = "MembershipNumber";
            relationColumnInfo1.ParentKeyColumn = "MembershipNumber";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // _Member
            // 
            this._Member.EditValue = "";
            this._Member.Location = new System.Drawing.Point(146, 252);
            this._Member.MenuManager = this.ribbon;
            this._Member.Name = "_Member";
            this._Member.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._Member.Properties.DataSource = this.membersBindingSource;
            this._Member.Properties.DisplayMember = "Name";
            this._Member.Properties.NullText = "";
            this._Member.Properties.PopupView = this.gridView2;
            this._Member.Properties.ValueMember = "MembershipNumber";
            this._Member.Size = new System.Drawing.Size(270, 20);
            this._Member.StyleController = this.layoutControl1;
            this._Member.TabIndex = 85;
            this._Member.EditValueChanged += new System.EventHandler(this._Member_EditValueChanged);
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "members";
            this.membersBindingSource.DataSource = this.sqlDataSource2;
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "SaccoBookConnection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            columnExpression5.ColumnName = "MembershipNumber";
            table3.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"571\" />";
            table3.Name = "saccobook.members";
            columnExpression5.Table = table3;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "Name";
            columnExpression6.Table = table3;
            column6.Expression = columnExpression6;
            selectQuery2.Columns.Add(column5);
            selectQuery2.Columns.Add(column6);
            selectQuery2.FilterString = "[saccobook.members.MembershipStatus] = \'Active\'";
            selectQuery2.GroupFilterString = "";
            selectQuery2.Name = "members";
            selectQuery2.Tables.Add(table3);
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery2});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // _SourceAccountNumber
            // 
            this._SourceAccountNumber.EditValue = "";
            this._SourceAccountNumber.Location = new System.Drawing.Point(146, 276);
            this._SourceAccountNumber.MenuManager = this.ribbon;
            this._SourceAccountNumber.Name = "_SourceAccountNumber";
            this._SourceAccountNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._SourceAccountNumber.Properties.DataSource = this.membersavingsaccountsBindingSource;
            this._SourceAccountNumber.Properties.DisplayMember = "Name";
            this._SourceAccountNumber.Properties.NullText = "";
            this._SourceAccountNumber.Properties.PopupView = this.searchLookUpEdit2View;
            this._SourceAccountNumber.Properties.ValueMember = "AccountNumber";
            this._SourceAccountNumber.Size = new System.Drawing.Size(270, 20);
            this._SourceAccountNumber.StyleController = this.layoutControl1;
            this._SourceAccountNumber.TabIndex = 84;
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // _Source
            // 
            this._Source.Location = new System.Drawing.Point(146, 228);
            this._Source.MenuManager = this.ribbon;
            this._Source.Name = "_Source";
            this._Source.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._Source.Properties.Items.AddRange(new object[] {
            "From Cash",
            "From Members Own Account",
            "From Other Members Account"});
            this._Source.Size = new System.Drawing.Size(270, 20);
            this._Source.StyleController = this.layoutControl1;
            this._Source.TabIndex = 83;
            this._Source.SelectedIndexChanged += new System.EventHandler(this._Source_SelectedIndexChanged);
            // 
            // _DestinationAccount
            // 
            this._DestinationAccount.Location = new System.Drawing.Point(566, 252);
            this._DestinationAccount.MenuManager = this.ribbon;
            this._DestinationAccount.Name = "_DestinationAccount";
            this._DestinationAccount.Properties.ReadOnly = true;
            this._DestinationAccount.Size = new System.Drawing.Size(251, 20);
            this._DestinationAccount.StyleController = this.layoutControl1;
            this._DestinationAccount.TabIndex = 82;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value must be specified";
            this.dxValidationProviderMakeSaving.SetValidationRule(this._DestinationAccount, conditionValidationRule3);
            // 
            // _DestinationAccountBalance
            // 
            this._DestinationAccountBalance.Location = new System.Drawing.Point(566, 276);
            this._DestinationAccountBalance.MenuManager = this.ribbon;
            this._DestinationAccountBalance.Name = "_DestinationAccountBalance";
            this._DestinationAccountBalance.Properties.Mask.BeepOnError = true;
            this._DestinationAccountBalance.Properties.Mask.EditMask = "n2";
            this._DestinationAccountBalance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._DestinationAccountBalance.Properties.Mask.UseMaskAsDisplayFormat = true;
            this._DestinationAccountBalance.Properties.ReadOnly = true;
            this._DestinationAccountBalance.Size = new System.Drawing.Size(251, 20);
            this._DestinationAccountBalance.StyleController = this.layoutControl1;
            this._DestinationAccountBalance.TabIndex = 81;
            // 
            // _Amount
            // 
            this._Amount.Location = new System.Drawing.Point(146, 300);
            this._Amount.MenuManager = this.ribbon;
            this._Amount.Name = "_Amount";
            this._Amount.Properties.Mask.BeepOnError = true;
            this._Amount.Properties.Mask.EditMask = "n2";
            this._Amount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._Amount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this._Amount.Size = new System.Drawing.Size(270, 20);
            this._Amount.StyleController = this.layoutControl1;
            this._Amount.TabIndex = 79;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "This value must be specified";
            this.dxValidationProviderMakeSaving.SetValidationRule(this._Amount, conditionValidationRule4);
            // 
            // _Name
            // 
            this._Name.Location = new System.Drawing.Point(146, 90);
            this._Name.Name = "_Name";
            this._Name.Properties.ReadOnly = true;
            this._Name.Size = new System.Drawing.Size(671, 20);
            this._Name.StyleController = this.layoutControl1;
            this._Name.TabIndex = 49;
            // 
            // _MembershipNumber
            // 
            this._MembershipNumber.Location = new System.Drawing.Point(146, 66);
            this._MembershipNumber.Name = "_MembershipNumber";
            this._MembershipNumber.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d\\d\\d\\d";
            this._MembershipNumber.Properties.Mask.ShowPlaceHolders = false;
            this._MembershipNumber.Properties.ReadOnly = true;
            this._MembershipNumber.Size = new System.Drawing.Size(671, 20);
            this._MembershipNumber.StyleController = this.layoutControl1;
            this._MembershipNumber.TabIndex = 7;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "This value cannot be blank";
            this.dxValidationProviderMakeSaving.SetValidationRule(this._MembershipNumber, conditionValidationRule5);
            // 
            // _NationalIdNumber
            // 
            this._NationalIdNumber.Location = new System.Drawing.Point(146, 114);
            this._NationalIdNumber.Name = "_NationalIdNumber";
            this._NationalIdNumber.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d\\d\\d\\d";
            this._NationalIdNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this._NationalIdNumber.Properties.Mask.ShowPlaceHolders = false;
            this._NationalIdNumber.Properties.ReadOnly = true;
            this._NationalIdNumber.Size = new System.Drawing.Size(671, 20);
            this._NationalIdNumber.StyleController = this.layoutControl1;
            this._NationalIdNumber.TabIndex = 64;
            // 
            // _DateJoined
            // 
            this._DateJoined.EditValue = null;
            this._DateJoined.Location = new System.Drawing.Point(146, 138);
            this._DateJoined.Name = "_DateJoined";
            this._DateJoined.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._DateJoined.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._DateJoined.Properties.DisplayFormat.FormatString = "yyyy-MM-d";
            this._DateJoined.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._DateJoined.Properties.EditFormat.FormatString = "yyyy-MM-d";
            this._DateJoined.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._DateJoined.Properties.Mask.EditMask = "yyyy-MM-d";
            this._DateJoined.Properties.Mask.UseMaskAsDisplayFormat = true;
            this._DateJoined.Properties.ReadOnly = true;
            this._DateJoined.Size = new System.Drawing.Size(671, 20);
            this._DateJoined.StyleController = this.layoutControl1;
            this._DateJoined.TabIndex = 16;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule6.ErrorText = "You must select a date the member is joining";
            this.dxValidationProviderMakeSaving.SetValidationRule(this._DateJoined, conditionValidationRule6);
            // 
            // _MembershipStatus
            // 
            this._MembershipStatus.Location = new System.Drawing.Point(146, 162);
            this._MembershipStatus.Name = "_MembershipStatus";
            this._MembershipStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._MembershipStatus.Properties.DropDownRows = 3;
            this._MembershipStatus.Properties.Items.AddRange(new object[] {
            "",
            "Active",
            "Inactive"});
            this._MembershipStatus.Properties.ReadOnly = true;
            this._MembershipStatus.Size = new System.Drawing.Size(282, 20);
            this._MembershipStatus.StyleController = this.layoutControl1;
            this._MembershipStatus.TabIndex = 62;
            // 
            // _Search
            // 
            this._Search.EditValue = "";
            this._Search.Location = new System.Drawing.Point(554, 12);
            this._Search.Name = "_Search";
            this._Search.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._Search.Properties.DataSource = this.membersBindingSource1;
            this._Search.Properties.DisplayMember = "Name";
            this._Search.Properties.NullText = "";
            this._Search.Properties.PopupView = this.gridView1;
            this._Search.Properties.ValueMember = "MembershipNumber";
            this._Search.Size = new System.Drawing.Size(275, 20);
            this._Search.StyleController = this.layoutControl1;
            this._Search.TabIndex = 78;
            this._Search.EditValueChanged += new System.EventHandler(this._Search_EditValueChanged);
            // 
            // membersBindingSource1
            // 
            this.membersBindingSource1.DataMember = "members";
            this.membersBindingSource1.DataSource = this.sqlDataSource3;
            // 
            // sqlDataSource3
            // 
            this.sqlDataSource3.ConnectionName = "SaccoBookConnection";
            this.sqlDataSource3.Name = "sqlDataSource3";
            columnExpression7.ColumnName = "MembershipNumber";
            table4.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"571\" />";
            table4.Name = "saccobook.members";
            columnExpression7.Table = table4;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "Name";
            columnExpression8.Table = table4;
            column8.Expression = columnExpression8;
            selectQuery3.Columns.Add(column7);
            selectQuery3.Columns.Add(column8);
            selectQuery3.FilterString = "[saccobook.members.MembershipStatus] = \'Active\'";
            selectQuery3.GroupFilterString = "";
            selectQuery3.Name = "members";
            selectQuery3.Tables.Add(table4);
            this.sqlDataSource3.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery3});
            this.sqlDataSource3.ResultSchemaSerializable = resources.GetString("sqlDataSource3.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup10,
            this.emptySpaceItem2,
            this.layoutControlItem1,
            this.layoutControlGroup1,
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(841, 569);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup10
            // 
            this.layoutControlGroup10.CustomizationFormText = "Basic Information:";
            this.layoutControlGroup10.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem25,
            this.emptySpaceItem1,
            this.layoutControlItem28,
            this.layoutControlItem12,
            this.layoutControlItem26,
            this.layoutControlItem20});
            this.layoutControlGroup10.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup10.Name = "layoutControlGroup10";
            this.layoutControlGroup10.Size = new System.Drawing.Size(821, 162);
            this.layoutControlGroup10.Text = "Basic Details:";
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.Control = this._Name;
            this.layoutControlItem20.CustomizationFormText = "Full Name:";
            this.layoutControlItem20.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(797, 24);
            this.layoutControlItem20.Text = "Full Name:";
            this.layoutControlItem20.TextSize = new System.Drawing.Size(119, 13);
            // 
            // layoutControlItem25
            // 
            this.layoutControlItem25.Control = this._MembershipNumber;
            this.layoutControlItem25.CustomizationFormText = "Membership No: ";
            this.layoutControlItem25.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem25.Name = "layoutControlItem25";
            this.layoutControlItem25.Size = new System.Drawing.Size(797, 24);
            this.layoutControlItem25.Text = "Membership No: ";
            this.layoutControlItem25.TextSize = new System.Drawing.Size(119, 13);
            // 
            // layoutControlItem26
            // 
            this.layoutControlItem26.Control = this._NationalIdNumber;
            this.layoutControlItem26.CustomizationFormText = "Id Number:";
            this.layoutControlItem26.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem26.Name = "layoutControlItem26";
            this.layoutControlItem26.Size = new System.Drawing.Size(797, 24);
            this.layoutControlItem26.Text = "Id Number:";
            this.layoutControlItem26.TextSize = new System.Drawing.Size(119, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(408, 96);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(389, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem28
            // 
            this.layoutControlItem28.Control = this._DateJoined;
            this.layoutControlItem28.CustomizationFormText = "Date Joined:";
            this.layoutControlItem28.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem28.Name = "layoutControlItem28";
            this.layoutControlItem28.Size = new System.Drawing.Size(797, 24);
            this.layoutControlItem28.Text = "Date Joined:";
            this.layoutControlItem28.TextSize = new System.Drawing.Size(119, 13);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this._MembershipStatus;
            this.layoutControlItem12.CustomizationFormText = "Membership Status:";
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(408, 24);
            this.layoutControlItem12.Text = "Membership Status:";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(119, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(420, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._Search;
            this.layoutControlItem1.CustomizationFormText = "Search:";
            this.layoutControlItem1.Location = new System.Drawing.Point(420, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(401, 24);
            this.layoutControlItem1.Text = "Search:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(119, 13);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 186);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(420, 138);
            this.layoutControlGroup1.Text = "Source Account:";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this._Source;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(396, 24);
            this.layoutControlItem7.Text = "Source:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(119, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._Amount;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(396, 24);
            this.layoutControlItem2.Text = "Amount in UGX:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(119, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._SourceAccountNumber;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(396, 24);
            this.layoutControlItem3.Text = "Source Account Number:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(119, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this._Member;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(396, 24);
            this.layoutControlItem8.Text = "Member:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(119, 13);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem9});
            this.layoutControlGroup2.Location = new System.Drawing.Point(420, 186);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(401, 138);
            this.layoutControlGroup2.Text = "Destination Account:";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._DestinationAccountBalance;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(377, 48);
            this.layoutControlItem5.Text = "Account Balance:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(119, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this._DestinationAccount;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(377, 24);
            this.layoutControlItem6.Text = "Account Number:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(119, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this._DestinationAccountType;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(377, 24);
            this.layoutControlItem9.Text = "Destination Account:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(119, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem13,
            this.layoutControlItem15,
            this.layoutControlItem16});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 324);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(821, 225);
            this.layoutControlGroup3.Text = "Transaction Details";
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this._Description;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(797, 87);
            this.layoutControlItem10.Text = "Description:";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(119, 13);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this._TransactionDate;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(797, 24);
            this.layoutControlItem11.Text = "Transaction Date:";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(119, 13);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this._DocumentNumber;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(797, 24);
            this.layoutControlItem13.Text = "Document Number:";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(119, 13);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this._ReferenceNumber;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(797, 24);
            this.layoutControlItem15.Text = "Reference Number:";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(119, 13);
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this._Status;
            this.layoutControlItem16.Location = new System.Drawing.Point(0, 159);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(797, 24);
            this.layoutControlItem16.Text = "Approval status:";
            this.layoutControlItem16.TextSize = new System.Drawing.Size(119, 13);
            // 
            // dxValidationProviderMakeSaving
            // 
            this.dxValidationProviderMakeSaving.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            // 
            // alertControl1
            // 
            this.alertControl1.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopRight;
            // 
            // MakeSaving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 743);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MakeSaving";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Make Saving";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._Status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ReferenceNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DocumentNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._TransactionDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._TransactionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DestinationAccountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersavingsaccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Member.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._SourceAccountNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Source.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DestinationAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DestinationAccountBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Amount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._MembershipNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._NationalIdNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DateJoined.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DateJoined.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._MembershipStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMakeSaving)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.ComboBoxEdit _Source;
        private DevExpress.XtraEditors.TextEdit _DestinationAccount;
        private DevExpress.XtraEditors.TextEdit _DestinationAccountBalance;
        private DevExpress.XtraEditors.TextEdit _Amount;
        private DevExpress.XtraEditors.TextEdit _Name;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderMakeSaving;
        private DevExpress.XtraEditors.TextEdit _MembershipNumber;
        private DevExpress.XtraEditors.TextEdit _NationalIdNumber;
        private DevExpress.XtraEditors.DateEdit _DateJoined;
        private DevExpress.XtraEditors.ComboBoxEdit _MembershipStatus;
        private DevExpress.XtraEditors.SearchLookUpEdit _Search;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem25;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem26;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem28;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SearchLookUpEdit _SourceAccountNumber;
        private System.Windows.Forms.BindingSource membersavingsaccountsBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SearchLookUpEdit _Member;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private System.Windows.Forms.BindingSource membersBindingSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource3;
        private DevExpress.XtraEditors.SearchLookUpEdit _DestinationAccountType;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.DateEdit _TransactionDate;
        private DevExpress.XtraEditors.MemoEdit _Description;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraEditors.TextEdit _DocumentNumber;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraEditors.TextEdit _ReferenceNumber;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraBars.BarButtonItem btn_save;
        private DevExpress.XtraBars.BarButtonItem btn_sendapprovalrequest;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_addattachment;
        private DevExpress.XtraBars.BarButtonItem btn_viewattachments;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraEditors.TextEdit _Status;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
    }
}