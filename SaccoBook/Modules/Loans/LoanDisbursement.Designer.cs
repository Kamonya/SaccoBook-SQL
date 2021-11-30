namespace SaccoBook.Modules.Loans
{
    partial class LoanDisbursement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanDisbursement));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule7 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_save = new DevExpress.XtraBars.BarButtonItem();
            this.btn_addguarantor = new DevExpress.XtraBars.BarButtonItem();
            this.btn_addattachments = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sendapprovalrequest = new DevExpress.XtraBars.BarButtonItem();
            this.btn_viewattachments = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._Status = new DevExpress.XtraEditors.TextEdit();
            this._DocumentNumber = new DevExpress.XtraEditors.TextEdit();
            this._Description = new DevExpress.XtraEditors.MemoEdit();
            this._LoanAmount = new DevExpress.XtraEditors.TextEdit();
            this._LoanRepaymentDeadlineDate = new DevExpress.XtraEditors.DateEdit();
            this._LoanAwardDate = new DevExpress.XtraEditors.DateEdit();
            this._RepaymentPeriodInMonths = new DevExpress.XtraEditors.TextEdit();
            this._MinimumDepositContribution = new DevExpress.XtraEditors.TextEdit();
            this._MaxRepaymentPeriodInMonths = new DevExpress.XtraEditors.TextEdit();
            this._MaximumLoanAmount = new DevExpress.XtraEditors.TextEdit();
            this._LoanType = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.loanprocucttypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._InterestCalculationType = new DevExpress.XtraEditors.TextEdit();
            this._InterestRate = new DevExpress.XtraEditors.TextEdit();
            this._Search = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._Name = new DevExpress.XtraEditors.TextEdit();
            this._MembershipNumber = new DevExpress.XtraEditors.TextEdit();
            this._NationalIdNumber = new DevExpress.XtraEditors.TextEdit();
            this._DateJoined = new DevExpress.XtraEditors.DateEdit();
            this._MembershipStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup10 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem25 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem26 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem28 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProviderLoanDisbursement = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DocumentNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._LoanAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._LoanRepaymentDeadlineDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._LoanRepaymentDeadlineDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._LoanAwardDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._LoanAwardDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._RepaymentPeriodInMonths.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._MinimumDepositContribution.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._MaxRepaymentPeriodInMonths.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._MaximumLoanAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._LoanType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanprocucttypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._InterestCalculationType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._InterestRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._MembershipNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._NationalIdNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DateJoined.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DateJoined.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._MembershipStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderLoanDisbursement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btn_save,
            this.btn_addguarantor,
            this.btn_addattachments,
            this.barButtonItem4,
            this.btn_sendapprovalrequest,
            this.btn_viewattachments});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.Size = new System.Drawing.Size(843, 143);
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
            // btn_addguarantor
            // 
            this.btn_addguarantor.Caption = "Add Guarantors";
            this.btn_addguarantor.Id = 2;
            this.btn_addguarantor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_addguarantor.ImageOptions.Image")));
            this.btn_addguarantor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_addguarantor.ImageOptions.LargeImage")));
            this.btn_addguarantor.Name = "btn_addguarantor";
            this.btn_addguarantor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_addguarantor_ItemClick);
            // 
            // btn_addattachments
            // 
            this.btn_addattachments.Caption = "Add Attachment";
            this.btn_addattachments.Id = 3;
            this.btn_addattachments.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_addattachments.ImageOptions.Image")));
            this.btn_addattachments.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_addattachments.ImageOptions.LargeImage")));
            this.btn_addattachments.Name = "btn_addattachments";
            this.btn_addattachments.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_addattachments_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Loan Repayment Schedule";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btn_sendapprovalrequest
            // 
            this.btn_sendapprovalrequest.Caption = "Send for Approval";
            this.btn_sendapprovalrequest.Id = 5;
            this.btn_sendapprovalrequest.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_sendapprovalrequest.ImageOptions.SvgImage")));
            this.btn_sendapprovalrequest.Name = "btn_sendapprovalrequest";
            this.btn_sendapprovalrequest.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_sendapprovalrequest_ItemClick);
            // 
            // btn_viewattachments
            // 
            this.btn_viewattachments.Caption = "View Attachments";
            this.btn_viewattachments.Id = 6;
            this.btn_viewattachments.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_viewattachments.ImageOptions.Image")));
            this.btn_viewattachments.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_viewattachments.ImageOptions.LargeImage")));
            this.btn_viewattachments.Name = "btn_viewattachments";
            this.btn_viewattachments.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_viewattachments_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
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
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_sendapprovalrequest);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Approvals";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Manage";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_addguarantor);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Guarantors";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_addattachments);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_viewattachments, true);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Attachments";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Reports";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Loan Repayment";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 679);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(843, 31);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEdit2);
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Controls.Add(this.dateEdit1);
            this.layoutControl1.Controls.Add(this._Status);
            this.layoutControl1.Controls.Add(this._DocumentNumber);
            this.layoutControl1.Controls.Add(this._Description);
            this.layoutControl1.Controls.Add(this._LoanAmount);
            this.layoutControl1.Controls.Add(this._LoanRepaymentDeadlineDate);
            this.layoutControl1.Controls.Add(this._LoanAwardDate);
            this.layoutControl1.Controls.Add(this._RepaymentPeriodInMonths);
            this.layoutControl1.Controls.Add(this._MinimumDepositContribution);
            this.layoutControl1.Controls.Add(this._MaxRepaymentPeriodInMonths);
            this.layoutControl1.Controls.Add(this._MaximumLoanAmount);
            this.layoutControl1.Controls.Add(this._LoanType);
            this.layoutControl1.Controls.Add(this._InterestCalculationType);
            this.layoutControl1.Controls.Add(this._InterestRate);
            this.layoutControl1.Controls.Add(this._Search);
            this.layoutControl1.Controls.Add(this._Name);
            this.layoutControl1.Controls.Add(this._MembershipNumber);
            this.layoutControl1.Controls.Add(this._NationalIdNumber);
            this.layoutControl1.Controls.Add(this._DateJoined);
            this.layoutControl1.Controls.Add(this._MembershipStatus);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 143);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(843, 536);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _Status
            // 
            this._Status.Location = new System.Drawing.Point(578, 480);
            this._Status.MenuManager = this.ribbon;
            this._Status.Name = "_Status";
            this._Status.Properties.ReadOnly = true;
            this._Status.Size = new System.Drawing.Size(229, 20);
            this._Status.StyleController = this.layoutControl1;
            this._Status.TabIndex = 91;
            // 
            // _DocumentNumber
            // 
            this._DocumentNumber.Location = new System.Drawing.Point(578, 258);
            this._DocumentNumber.MenuManager = this.ribbon;
            this._DocumentNumber.Name = "_DocumentNumber";
            this._DocumentNumber.Properties.ReadOnly = true;
            this._DocumentNumber.Size = new System.Drawing.Size(229, 20);
            this._DocumentNumber.StyleController = this.layoutControl1;
            this._DocumentNumber.TabIndex = 90;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value must be specified";
            this.dxValidationProviderLoanDisbursement.SetValidationRule(this._DocumentNumber, conditionValidationRule1);
            // 
            // _Description
            // 
            this._Description.Location = new System.Drawing.Point(578, 378);
            this._Description.MenuManager = this.ribbon;
            this._Description.Name = "_Description";
            this._Description.Size = new System.Drawing.Size(229, 26);
            this._Description.StyleController = this.layoutControl1;
            this._Description.TabIndex = 89;
            // 
            // _LoanAmount
            // 
            this._LoanAmount.Location = new System.Drawing.Point(578, 354);
            this._LoanAmount.MenuManager = this.ribbon;
            this._LoanAmount.Name = "_LoanAmount";
            this._LoanAmount.Properties.Mask.EditMask = "n2";
            this._LoanAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._LoanAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this._LoanAmount.Size = new System.Drawing.Size(229, 20);
            this._LoanAmount.StyleController = this.layoutControl1;
            this._LoanAmount.TabIndex = 88;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxValidationProviderLoanDisbursement.SetValidationRule(this._LoanAmount, conditionValidationRule2);
            // 
            // _LoanRepaymentDeadlineDate
            // 
            this._LoanRepaymentDeadlineDate.EditValue = null;
            this._LoanRepaymentDeadlineDate.Location = new System.Drawing.Point(578, 330);
            this._LoanRepaymentDeadlineDate.MenuManager = this.ribbon;
            this._LoanRepaymentDeadlineDate.Name = "_LoanRepaymentDeadlineDate";
            this._LoanRepaymentDeadlineDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._LoanRepaymentDeadlineDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._LoanRepaymentDeadlineDate.Properties.Mask.BeepOnError = true;
            this._LoanRepaymentDeadlineDate.Properties.Mask.EditMask = "yyyy-MM-dd";
            this._LoanRepaymentDeadlineDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this._LoanRepaymentDeadlineDate.Size = new System.Drawing.Size(229, 20);
            this._LoanRepaymentDeadlineDate.StyleController = this.layoutControl1;
            this._LoanRepaymentDeadlineDate.TabIndex = 87;
            // 
            // _LoanAwardDate
            // 
            this._LoanAwardDate.EditValue = null;
            this._LoanAwardDate.Location = new System.Drawing.Point(578, 282);
            this._LoanAwardDate.MenuManager = this.ribbon;
            this._LoanAwardDate.Name = "_LoanAwardDate";
            this._LoanAwardDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._LoanAwardDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._LoanAwardDate.Properties.DisplayFormat.FormatString = "yyyy-MM-d";
            this._LoanAwardDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._LoanAwardDate.Properties.Mask.EditMask = "yyyy-MM-dd";
            this._LoanAwardDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this._LoanAwardDate.Size = new System.Drawing.Size(229, 20);
            this._LoanAwardDate.StyleController = this.layoutControl1;
            this._LoanAwardDate.TabIndex = 86;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.dxValidationProviderLoanDisbursement.SetValidationRule(this._LoanAwardDate, conditionValidationRule3);
            // 
            // _RepaymentPeriodInMonths
            // 
            this._RepaymentPeriodInMonths.Location = new System.Drawing.Point(578, 306);
            this._RepaymentPeriodInMonths.MenuManager = this.ribbon;
            this._RepaymentPeriodInMonths.Name = "_RepaymentPeriodInMonths";
            this._RepaymentPeriodInMonths.Properties.Mask.EditMask = "n0";
            this._RepaymentPeriodInMonths.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._RepaymentPeriodInMonths.Size = new System.Drawing.Size(229, 20);
            this._RepaymentPeriodInMonths.StyleController = this.layoutControl1;
            this._RepaymentPeriodInMonths.TabIndex = 85;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "This value is not valid";
            this.dxValidationProviderLoanDisbursement.SetValidationRule(this._RepaymentPeriodInMonths, conditionValidationRule4);
            this._RepaymentPeriodInMonths.EditValueChanged += new System.EventHandler(this._RepaymentPeriodInMonths_EditValueChanged);
            // 
            // _MinimumDepositContribution
            // 
            this._MinimumDepositContribution.Location = new System.Drawing.Point(201, 378);
            this._MinimumDepositContribution.MenuManager = this.ribbon;
            this._MinimumDepositContribution.Name = "_MinimumDepositContribution";
            this._MinimumDepositContribution.Properties.ReadOnly = true;
            this._MinimumDepositContribution.Size = new System.Drawing.Size(184, 20);
            this._MinimumDepositContribution.StyleController = this.layoutControl1;
            this._MinimumDepositContribution.TabIndex = 84;
            // 
            // _MaxRepaymentPeriodInMonths
            // 
            this._MaxRepaymentPeriodInMonths.Location = new System.Drawing.Point(201, 354);
            this._MaxRepaymentPeriodInMonths.MenuManager = this.ribbon;
            this._MaxRepaymentPeriodInMonths.Name = "_MaxRepaymentPeriodInMonths";
            this._MaxRepaymentPeriodInMonths.Properties.ReadOnly = true;
            this._MaxRepaymentPeriodInMonths.Size = new System.Drawing.Size(184, 20);
            this._MaxRepaymentPeriodInMonths.StyleController = this.layoutControl1;
            this._MaxRepaymentPeriodInMonths.TabIndex = 83;
            // 
            // _MaximumLoanAmount
            // 
            this._MaximumLoanAmount.Location = new System.Drawing.Point(201, 330);
            this._MaximumLoanAmount.MenuManager = this.ribbon;
            this._MaximumLoanAmount.Name = "_MaximumLoanAmount";
            this._MaximumLoanAmount.Properties.Mask.EditMask = "n2";
            this._MaximumLoanAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._MaximumLoanAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this._MaximumLoanAmount.Properties.ReadOnly = true;
            this._MaximumLoanAmount.Size = new System.Drawing.Size(184, 20);
            this._MaximumLoanAmount.StyleController = this.layoutControl1;
            this._MaximumLoanAmount.TabIndex = 82;
            // 
            // _LoanType
            // 
            this._LoanType.EditValue = "";
            this._LoanType.Location = new System.Drawing.Point(201, 258);
            this._LoanType.MenuManager = this.ribbon;
            this._LoanType.Name = "_LoanType";
            this._LoanType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._LoanType.Properties.DataSource = this.loanprocucttypesBindingSource;
            this._LoanType.Properties.DisplayMember = "Name";
            this._LoanType.Properties.PopupView = this.gridView1;
            this._LoanType.Properties.ValueMember = "Code";
            this._LoanType.Size = new System.Drawing.Size(184, 20);
            this._LoanType.StyleController = this.layoutControl1;
            this._LoanType.TabIndex = 81;
            this._LoanType.EditValueChanged += new System.EventHandler(this._LoanType_EditValueChanged);
            // 
            // loanprocucttypesBindingSource
            // 
            this.loanprocucttypesBindingSource.DataMember = "loanprocucttypes";
            this.loanprocucttypesBindingSource.DataSource = this.sqlDataSource2;
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "SaccoBookConnection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            columnExpression1.ColumnName = "Code";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"267\" />";
            table1.Name = "saccobook.loanprocucttypes";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "Name";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "InterestRate";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "InterestCalculationType";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "MaximumLoanAmount";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "MaxRepaymentPeriodInMonths";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "MinimumDepositContribution";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Name = "loanprocucttypes";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // _InterestCalculationType
            // 
            this._InterestCalculationType.Location = new System.Drawing.Point(201, 306);
            this._InterestCalculationType.MenuManager = this.ribbon;
            this._InterestCalculationType.Name = "_InterestCalculationType";
            this._InterestCalculationType.Properties.ReadOnly = true;
            this._InterestCalculationType.Size = new System.Drawing.Size(184, 20);
            this._InterestCalculationType.StyleController = this.layoutControl1;
            this._InterestCalculationType.TabIndex = 80;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "This value is not valid";
            this.dxValidationProviderLoanDisbursement.SetValidationRule(this._InterestCalculationType, conditionValidationRule5);
            // 
            // _InterestRate
            // 
            this._InterestRate.Location = new System.Drawing.Point(201, 282);
            this._InterestRate.MenuManager = this.ribbon;
            this._InterestRate.Name = "_InterestRate";
            this._InterestRate.Properties.ReadOnly = true;
            this._InterestRate.Size = new System.Drawing.Size(184, 20);
            this._InterestRate.StyleController = this.layoutControl1;
            this._InterestRate.TabIndex = 79;
            // 
            // _Search
            // 
            this._Search.EditValue = "";
            this._Search.Location = new System.Drawing.Point(598, 12);
            this._Search.MenuManager = this.ribbon;
            this._Search.Name = "_Search";
            this._Search.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._Search.Properties.DataSource = this.membersBindingSource;
            this._Search.Properties.DisplayMember = "Name";
            this._Search.Properties.PopupView = this.searchLookUpEdit1View;
            this._Search.Properties.ValueMember = "MembershipNumber";
            this._Search.Size = new System.Drawing.Size(233, 20);
            this._Search.StyleController = this.layoutControl1;
            this._Search.TabIndex = 78;
            this._Search.EditValueChanged += new System.EventHandler(this._Search_EditValueChanged);
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "members";
            this.membersBindingSource.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "SaccoBookConnection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression8.ColumnName = "MembershipNumber";
            table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"571\" />";
            table2.Name = "saccobook.members";
            columnExpression8.Table = table2;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "Name";
            columnExpression9.Table = table2;
            column9.Expression = columnExpression9;
            selectQuery2.Columns.Add(column8);
            selectQuery2.Columns.Add(column9);
            selectQuery2.Name = "members";
            selectQuery2.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // _Name
            // 
            this._Name.Location = new System.Drawing.Point(189, 90);
            this._Name.Name = "_Name";
            this._Name.Properties.ReadOnly = true;
            this._Name.Size = new System.Drawing.Size(630, 20);
            this._Name.StyleController = this.layoutControl1;
            this._Name.TabIndex = 49;
            // 
            // _MembershipNumber
            // 
            this._MembershipNumber.Location = new System.Drawing.Point(189, 66);
            this._MembershipNumber.Name = "_MembershipNumber";
            this._MembershipNumber.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d\\d\\d\\d";
            this._MembershipNumber.Properties.Mask.ShowPlaceHolders = false;
            this._MembershipNumber.Properties.ReadOnly = true;
            this._MembershipNumber.Size = new System.Drawing.Size(630, 20);
            this._MembershipNumber.StyleController = this.layoutControl1;
            this._MembershipNumber.TabIndex = 7;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule6.ErrorText = "This value cannot be blank";
            this.dxValidationProviderLoanDisbursement.SetValidationRule(this._MembershipNumber, conditionValidationRule6);
            // 
            // _NationalIdNumber
            // 
            this._NationalIdNumber.Location = new System.Drawing.Point(189, 114);
            this._NationalIdNumber.Name = "_NationalIdNumber";
            this._NationalIdNumber.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d\\d\\d\\d";
            this._NationalIdNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this._NationalIdNumber.Properties.Mask.ShowPlaceHolders = false;
            this._NationalIdNumber.Properties.ReadOnly = true;
            this._NationalIdNumber.Size = new System.Drawing.Size(630, 20);
            this._NationalIdNumber.StyleController = this.layoutControl1;
            this._NationalIdNumber.TabIndex = 64;
            // 
            // _DateJoined
            // 
            this._DateJoined.EditValue = null;
            this._DateJoined.Location = new System.Drawing.Point(189, 162);
            this._DateJoined.Name = "_DateJoined";
            this._DateJoined.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._DateJoined.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._DateJoined.Properties.DisplayFormat.FormatString = "D";
            this._DateJoined.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._DateJoined.Properties.EditFormat.FormatString = "yyyy-MM-d";
            this._DateJoined.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._DateJoined.Properties.Mask.EditMask = "yyyy-MM-d";
            this._DateJoined.Properties.Mask.UseMaskAsDisplayFormat = true;
            this._DateJoined.Properties.ReadOnly = true;
            this._DateJoined.Size = new System.Drawing.Size(630, 20);
            this._DateJoined.StyleController = this.layoutControl1;
            this._DateJoined.TabIndex = 16;
            conditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule7.ErrorText = "You must select a date the member is joining";
            this.dxValidationProviderLoanDisbursement.SetValidationRule(this._DateJoined, conditionValidationRule7);
            // 
            // _MembershipStatus
            // 
            this._MembershipStatus.Location = new System.Drawing.Point(189, 138);
            this._MembershipStatus.Name = "_MembershipStatus";
            this._MembershipStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._MembershipStatus.Properties.DropDownRows = 3;
            this._MembershipStatus.Properties.Items.AddRange(new object[] {
            "",
            "Active",
            "Inactive"});
            this._MembershipStatus.Properties.ReadOnly = true;
            this._MembershipStatus.Size = new System.Drawing.Size(630, 20);
            this._MembershipStatus.StyleController = this.layoutControl1;
            this._MembershipStatus.TabIndex = 62;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup10,
            this.emptySpaceItem2,
            this.layoutControlItem1,
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(843, 536);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup10
            // 
            this.layoutControlGroup10.CustomizationFormText = "Basic Information:";
            this.layoutControlGroup10.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem25,
            this.layoutControlItem26,
            this.layoutControlItem20,
            this.layoutControlItem12,
            this.layoutControlItem28});
            this.layoutControlGroup10.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup10.Name = "layoutControlGroup10";
            this.layoutControlGroup10.Size = new System.Drawing.Size(823, 162);
            this.layoutControlGroup10.Text = "Basic Details:";
            // 
            // layoutControlItem25
            // 
            this.layoutControlItem25.Control = this._MembershipNumber;
            this.layoutControlItem25.CustomizationFormText = "Membership No: ";
            this.layoutControlItem25.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem25.Name = "layoutControlItem25";
            this.layoutControlItem25.Size = new System.Drawing.Size(799, 24);
            this.layoutControlItem25.Text = "Membership No: ";
            this.layoutControlItem25.TextSize = new System.Drawing.Size(162, 13);
            // 
            // layoutControlItem26
            // 
            this.layoutControlItem26.Control = this._NationalIdNumber;
            this.layoutControlItem26.CustomizationFormText = "Id Number:";
            this.layoutControlItem26.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem26.Name = "layoutControlItem26";
            this.layoutControlItem26.Size = new System.Drawing.Size(799, 24);
            this.layoutControlItem26.Text = "Id Number:";
            this.layoutControlItem26.TextSize = new System.Drawing.Size(162, 13);
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.Control = this._Name;
            this.layoutControlItem20.CustomizationFormText = "Full Name:";
            this.layoutControlItem20.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(799, 24);
            this.layoutControlItem20.Text = "Full Name:";
            this.layoutControlItem20.TextSize = new System.Drawing.Size(162, 13);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this._MembershipStatus;
            this.layoutControlItem12.CustomizationFormText = "Membership Status:";
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(799, 24);
            this.layoutControlItem12.Text = "Membership Status:";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(162, 13);
            // 
            // layoutControlItem28
            // 
            this.layoutControlItem28.Control = this._DateJoined;
            this.layoutControlItem28.CustomizationFormText = "Date Joined:";
            this.layoutControlItem28.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem28.Name = "layoutControlItem28";
            this.layoutControlItem28.Size = new System.Drawing.Size(799, 24);
            this.layoutControlItem28.Text = "Date Joined:";
            this.layoutControlItem28.TextSize = new System.Drawing.Size(162, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(421, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._Search;
            this.layoutControlItem1.Location = new System.Drawing.Point(421, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(402, 24);
            this.layoutControlItem1.Text = "Search:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(162, 13);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 186);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(823, 330);
            this.layoutControlGroup1.Text = "Loan Details:";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(377, 288);
            this.layoutControlGroup2.Text = "Loan Type:";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._LoanType;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(353, 24);
            this.layoutControlItem5.Text = "Loan Type:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(162, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._InterestRate;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(353, 24);
            this.layoutControlItem2.Text = "Interest Rate:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(162, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._InterestCalculationType;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(353, 24);
            this.layoutControlItem3.Text = "Interest Calculation Type:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(162, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this._MaximumLoanAmount;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(353, 24);
            this.layoutControlItem6.Text = "Maximum Loan Amount:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(162, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this._MaxRepaymentPeriodInMonths;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(353, 24);
            this.layoutControlItem7.Text = "Max Repayment Period In Months";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(162, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this._MinimumDepositContribution;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(353, 24);
            this.layoutControlItem8.Text = "Minimum Deposit Contribution:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(162, 13);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 144);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(353, 102);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem16,
            this.layoutControlItem10,
            this.layoutControlItem9,
            this.layoutControlItem11,
            this.layoutControlItem13,
            this.layoutControlItem15,
            this.layoutControlItem17,
            this.layoutControlItem4,
            this.layoutControlItem14,
            this.layoutControlItem18});
            this.layoutControlGroup3.Location = new System.Drawing.Point(377, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(422, 288);
            this.layoutControlGroup3.Text = "Disbursement Details";
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this._DocumentNumber;
            this.layoutControlItem16.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(398, 24);
            this.layoutControlItem16.Text = "Document Number:";
            this.layoutControlItem16.TextSize = new System.Drawing.Size(162, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this._LoanAwardDate;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(398, 24);
            this.layoutControlItem10.Text = "Date Awarded:";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(162, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this._RepaymentPeriodInMonths;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(398, 24);
            this.layoutControlItem9.Text = "Number of months:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(162, 13);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this._LoanRepaymentDeadlineDate;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(398, 24);
            this.layoutControlItem11.Text = "Repayment due date:";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(162, 13);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this._LoanAmount;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(398, 24);
            this.layoutControlItem13.Text = "Amount Requested:";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(162, 13);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this._Description;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(398, 30);
            this.layoutControlItem15.Text = "Description:";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(162, 13);
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this._Status;
            this.layoutControlItem17.Location = new System.Drawing.Point(0, 222);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(398, 24);
            this.layoutControlItem17.Text = "Approval status:";
            this.layoutControlItem17.TextSize = new System.Drawing.Size(162, 13);
            // 
            // dxValidationProviderLoanDisbursement
            // 
            this.dxValidationProviderLoanDisbursement.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(578, 456);
            this.dateEdit1.MenuManager = this.ribbon;
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(229, 20);
            this.dateEdit1.StyleController = this.layoutControl1;
            this.dateEdit1.TabIndex = 92;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dateEdit1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 198);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(398, 24);
            this.layoutControlItem4.Text = "Disbursement Date";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(162, 13);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(578, 408);
            this.textEdit1.MenuManager = this.ribbon;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(229, 20);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 93;
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.textEdit1;
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 150);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(398, 24);
            this.layoutControlItem14.Text = "Amount Approved:";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(162, 13);
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(578, 432);
            this.textEdit2.MenuManager = this.ribbon;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(229, 20);
            this.textEdit2.StyleController = this.layoutControl1;
            this.textEdit2.TabIndex = 94;
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.textEdit2;
            this.layoutControlItem18.Location = new System.Drawing.Point(0, 174);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(398, 24);
            this.layoutControlItem18.Text = "Amount To Disburse:";
            this.layoutControlItem18.TextSize = new System.Drawing.Size(162, 13);
            // 
            // LoanDisbursement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 710);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoanDisbursement";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Loan Disbursement";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._Status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DocumentNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._LoanAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._LoanRepaymentDeadlineDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._LoanRepaymentDeadlineDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._LoanAwardDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._LoanAwardDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._RepaymentPeriodInMonths.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._MinimumDepositContribution.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._MaxRepaymentPeriodInMonths.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._MaximumLoanAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._LoanType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanprocucttypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._InterestCalculationType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._InterestRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._MembershipNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._NationalIdNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DateJoined.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DateJoined.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._MembershipStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderLoanDisbursement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit _Name;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderLoanDisbursement;
        private DevExpress.XtraEditors.TextEdit _MembershipNumber;
        private DevExpress.XtraEditors.TextEdit _NationalIdNumber;
        private DevExpress.XtraEditors.DateEdit _DateJoined;
        private DevExpress.XtraEditors.ComboBoxEdit _MembershipStatus;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem25;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem26;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem28;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraEditors.SearchLookUpEdit _Search;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem btn_save;
        private DevExpress.XtraBars.BarButtonItem btn_addguarantor;
        private DevExpress.XtraBars.BarButtonItem btn_addattachments;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraEditors.TextEdit _InterestRate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.TextEdit _InterestCalculationType;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit _DocumentNumber;
        private DevExpress.XtraEditors.MemoEdit _Description;
        private DevExpress.XtraEditors.TextEdit _LoanAmount;
        private DevExpress.XtraEditors.DateEdit _LoanRepaymentDeadlineDate;
        private DevExpress.XtraEditors.DateEdit _LoanAwardDate;
        private DevExpress.XtraEditors.TextEdit _RepaymentPeriodInMonths;
        private DevExpress.XtraEditors.TextEdit _MinimumDepositContribution;
        private DevExpress.XtraEditors.TextEdit _MaxRepaymentPeriodInMonths;
        private DevExpress.XtraEditors.TextEdit _MaximumLoanAmount;
        private DevExpress.XtraEditors.SearchLookUpEdit _LoanType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private System.Windows.Forms.BindingSource loanprocucttypesBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraBars.BarButtonItem btn_sendapprovalrequest;
        private DevExpress.XtraBars.BarButtonItem btn_viewattachments;
        private DevExpress.XtraEditors.TextEdit _Status;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
    }
}