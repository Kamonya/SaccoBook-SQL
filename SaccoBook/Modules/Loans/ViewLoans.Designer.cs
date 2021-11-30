namespace SaccoBook.Modules.Loans
{
    partial class ViewLoans
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Sorting sorting1 = new DevExpress.DataAccess.Sql.Sorting();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLoans));
            this.gridControlViewLoans = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridViewViewLoans = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDocumentNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMembershipNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoanType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoanAwardDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoanAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRepaymentPeriodInMonths = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoanRepaymentDeadlineDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_sendapprovalrequest = new DevExpress.XtraBars.BarButtonItem();
            this.btn_view = new DevExpress.XtraBars.BarButtonItem();
            this.btn_edit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlViewLoans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewViewLoans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlViewLoans
            // 
            this.gridControlViewLoans.DataMember = "saccobook_memberloans";
            this.gridControlViewLoans.DataSource = this.sqlDataSource1;
            this.gridControlViewLoans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlViewLoans.Location = new System.Drawing.Point(0, 143);
            this.gridControlViewLoans.MainView = this.gridViewViewLoans;
            this.gridControlViewLoans.Name = "gridControlViewLoans";
            this.gridControlViewLoans.Size = new System.Drawing.Size(732, 228);
            this.gridControlViewLoans.TabIndex = 0;
            this.gridControlViewLoans.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewViewLoans});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "SaccoBookConnection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "DocumentNumber";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"343\" />";
            table1.Name = "saccobook.memberloans";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "MembershipNumber";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "Name";
            table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"571\" />";
            table2.Name = "saccobook.members";
            columnExpression3.Table = table2;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "LoanType";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "LoanAwardDate";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "LoanAmount";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "RepaymentPeriodInMonths";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "LoanRepaymentDeadlineDate";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "Balance";
            columnExpression9.Table = table1;
            column9.Expression = columnExpression9;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.Columns.Add(column9);
            selectQuery1.FilterString = "[saccobook.memberloans.Balance] > 0.0 And [saccobook.memberloans.LoanRepaymentDea" +
    "dlineDate] < [saccobook.memberloans.LoanRepaymentDeadlineDate]";
            selectQuery1.GroupFilterString = "";
            selectQuery1.Name = "saccobook_memberloans";
            relationColumnInfo1.NestedKeyColumn = "MembershipNumber";
            relationColumnInfo1.ParentKeyColumn = "MembershipNumber";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            selectQuery1.Relations.Add(join1);
            sorting1.Direction = System.ComponentModel.ListSortDirection.Descending;
            columnExpression10.ColumnName = "DocumentNumber";
            columnExpression10.Table = table1;
            sorting1.Expression = columnExpression10;
            selectQuery1.Sorting.Add(sorting1);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridViewViewLoans
            // 
            this.gridViewViewLoans.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDocumentNumber,
            this.colMembershipNumber,
            this.colName,
            this.colLoanType,
            this.colLoanAwardDate,
            this.colLoanAmount,
            this.colRepaymentPeriodInMonths,
            this.colLoanRepaymentDeadlineDate,
            this.colBalance});
            this.gridViewViewLoans.GridControl = this.gridControlViewLoans;
            this.gridViewViewLoans.Name = "gridViewViewLoans";
            this.gridViewViewLoans.OptionsBehavior.Editable = false;
            this.gridViewViewLoans.OptionsFind.AlwaysVisible = true;
            this.gridViewViewLoans.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewViewLoans_RowClick);
            this.gridViewViewLoans.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewViewLoans_FocusedRowChanged);
            // 
            // colDocumentNumber
            // 
            this.colDocumentNumber.FieldName = "DocumentNumber";
            this.colDocumentNumber.Name = "colDocumentNumber";
            this.colDocumentNumber.Visible = true;
            this.colDocumentNumber.VisibleIndex = 0;
            // 
            // colMembershipNumber
            // 
            this.colMembershipNumber.FieldName = "MembershipNumber";
            this.colMembershipNumber.Name = "colMembershipNumber";
            this.colMembershipNumber.Visible = true;
            this.colMembershipNumber.VisibleIndex = 1;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            // 
            // colLoanType
            // 
            this.colLoanType.FieldName = "LoanType";
            this.colLoanType.Name = "colLoanType";
            this.colLoanType.Visible = true;
            this.colLoanType.VisibleIndex = 3;
            // 
            // colLoanAwardDate
            // 
            this.colLoanAwardDate.FieldName = "LoanAwardDate";
            this.colLoanAwardDate.Name = "colLoanAwardDate";
            this.colLoanAwardDate.Visible = true;
            this.colLoanAwardDate.VisibleIndex = 4;
            // 
            // colLoanAmount
            // 
            this.colLoanAmount.FieldName = "LoanAmount";
            this.colLoanAmount.Name = "colLoanAmount";
            this.colLoanAmount.Visible = true;
            this.colLoanAmount.VisibleIndex = 5;
            // 
            // colRepaymentPeriodInMonths
            // 
            this.colRepaymentPeriodInMonths.FieldName = "RepaymentPeriodInMonths";
            this.colRepaymentPeriodInMonths.Name = "colRepaymentPeriodInMonths";
            this.colRepaymentPeriodInMonths.Visible = true;
            this.colRepaymentPeriodInMonths.VisibleIndex = 6;
            // 
            // colLoanRepaymentDeadlineDate
            // 
            this.colLoanRepaymentDeadlineDate.FieldName = "LoanRepaymentDeadlineDate";
            this.colLoanRepaymentDeadlineDate.Name = "colLoanRepaymentDeadlineDate";
            this.colLoanRepaymentDeadlineDate.Visible = true;
            this.colLoanRepaymentDeadlineDate.VisibleIndex = 7;
            // 
            // colBalance
            // 
            this.colBalance.FieldName = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.Visible = true;
            this.colBalance.VisibleIndex = 8;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btn_sendapprovalrequest,
            this.btn_view,
            this.btn_edit,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(732, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btn_sendapprovalrequest
            // 
            this.btn_sendapprovalrequest.Caption = "Send for Approval";
            this.btn_sendapprovalrequest.Id = 1;
            this.btn_sendapprovalrequest.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_sendapprovalrequest.ImageOptions.SvgImage")));
            this.btn_sendapprovalrequest.Name = "btn_sendapprovalrequest";
            this.btn_sendapprovalrequest.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_sendapprovalrequest_ItemClick);
            // 
            // btn_view
            // 
            this.btn_view.Caption = "View Record";
            this.btn_view.Id = 2;
            this.btn_view.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_view.ImageOptions.Image")));
            this.btn_view.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_view.ImageOptions.LargeImage")));
            this.btn_view.Name = "btn_view";
            this.btn_view.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_view_ItemClick);
            // 
            // btn_edit
            // 
            this.btn_edit.Caption = "Edit";
            this.btn_edit.Id = 3;
            this.btn_edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.ImageOptions.Image")));
            this.btn_edit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_edit.ImageOptions.LargeImage")));
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_edit_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup2,
            this.ribbonPageGroup1,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_edit);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Edit";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_view);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "View";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_sendapprovalrequest);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Approval";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 371);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(732, 31);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Notifications";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Send Defaulter Notifications";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ViewLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 402);
            this.Controls.Add(this.gridControlViewLoans);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewLoans";
            this.Ribbon = this.ribbonControl1;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "View Loans";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControlViewLoans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewViewLoans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlViewLoans;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewViewLoans;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btn_sendapprovalrequest;
        private DevExpress.XtraBars.BarButtonItem btn_view;
        private DevExpress.XtraBars.BarButtonItem btn_edit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colMembershipNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colLoanType;
        private DevExpress.XtraGrid.Columns.GridColumn colLoanAwardDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLoanAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRepaymentPeriodInMonths;
        private DevExpress.XtraGrid.Columns.GridColumn colLoanRepaymentDeadlineDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBalance;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}