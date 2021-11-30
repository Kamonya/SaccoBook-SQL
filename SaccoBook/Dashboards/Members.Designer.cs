namespace SaccoBook.Dashboards
{
    partial class Members
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Members));
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Card card1 = new DevExpress.DashboardCommon.Card();
            DevExpress.DashboardCommon.CardStretchedLayoutTemplate cardStretchedLayoutTemplate1 = new DevExpress.DashboardCommon.CardStretchedLayoutTemplate();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure3 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure4 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Card card2 = new DevExpress.DashboardCommon.Card();
            DevExpress.DashboardCommon.CardStretchedLayoutTemplate cardStretchedLayoutTemplate2 = new DevExpress.DashboardCommon.CardStretchedLayoutTemplate();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure5 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup3 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem4 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem5 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.rangeFilterDashboardItem1 = new DevExpress.DashboardCommon.RangeFilterDashboardItem();
            this.dashboardSqlDataSource1 = new DevExpress.DashboardCommon.DashboardSqlDataSource();
            this.cardDashboardItem1 = new DevExpress.DashboardCommon.CardDashboardItem();
            this.pieDashboardItem1 = new DevExpress.DashboardCommon.PieDashboardItem();
            this.cardDashboardItem2 = new DevExpress.DashboardCommon.CardDashboardItem();
            this.pieDashboardItem2 = new DevExpress.DashboardCommon.PieDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.rangeFilterDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardSqlDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDashboardItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieDashboardItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // rangeFilterDashboardItem1
            // 
            dimension1.DataMember = "DateJoined";
            this.rangeFilterDashboardItem1.Argument = dimension1;
            this.rangeFilterDashboardItem1.ComponentName = "rangeFilterDashboardItem1";
            measure1.DataMember = "MembershipNumber";
            measure1.SummaryType = DevExpress.DashboardCommon.SummaryType.Count;
            this.rangeFilterDashboardItem1.DataItemRepository.Clear();
            this.rangeFilterDashboardItem1.DataItemRepository.Add(measure1, "DataItem0");
            this.rangeFilterDashboardItem1.DataItemRepository.Add(dimension1, "DataItem1");
            this.rangeFilterDashboardItem1.DataMember = "members";
            this.rangeFilterDashboardItem1.DataSource = this.dashboardSqlDataSource1;
            this.rangeFilterDashboardItem1.InteractivityOptions.IgnoreMasterFilters = true;
            this.rangeFilterDashboardItem1.Name = "Range Filter 1";
            simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line;
            simpleSeries1.AddDataItem("Value", measure1);
            this.rangeFilterDashboardItem1.Series.AddRange(new DevExpress.DashboardCommon.SimpleSeries[] {
            simpleSeries1});
            this.rangeFilterDashboardItem1.ShowCaption = false;
            // 
            // dashboardSqlDataSource1
            // 
            this.dashboardSqlDataSource1.ComponentName = "dashboardSqlDataSource1";
            this.dashboardSqlDataSource1.ConnectionName = "SaccoBookConnection";
            this.dashboardSqlDataSource1.Name = "Members Data Source";
            columnExpression1.ColumnName = "MembershipNumber";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"571\" />";
            table1.Name = "saccobook.members";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "Gender";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "MembershipStatus";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "DateJoined";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Name = "members";
            selectQuery1.Tables.Add(table1);
            this.dashboardSqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.dashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource1.ResultSchemaSerializable");
            // 
            // cardDashboardItem1
            // 
            measure2.DataMember = "MembershipNumber";
            measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.Count;
            cardStretchedLayoutTemplate1.BottomValue1.DimensionIndex = 0;
            cardStretchedLayoutTemplate1.BottomValue1.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.PercentVariation;
            cardStretchedLayoutTemplate1.BottomValue1.Visible = true;
            cardStretchedLayoutTemplate1.BottomValue2.DimensionIndex = 0;
            cardStretchedLayoutTemplate1.BottomValue2.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.AbsoluteVariation;
            cardStretchedLayoutTemplate1.BottomValue2.Visible = true;
            cardStretchedLayoutTemplate1.DeltaIndicator.Visible = true;
            cardStretchedLayoutTemplate1.MainValue.DimensionIndex = 0;
            cardStretchedLayoutTemplate1.MainValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Title;
            cardStretchedLayoutTemplate1.MainValue.Visible = true;
            cardStretchedLayoutTemplate1.Sparkline.Visible = true;
            cardStretchedLayoutTemplate1.SubValue.DimensionIndex = 0;
            cardStretchedLayoutTemplate1.SubValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Subtitle;
            cardStretchedLayoutTemplate1.SubValue.Visible = true;
            cardStretchedLayoutTemplate1.TopValue.DimensionIndex = 0;
            cardStretchedLayoutTemplate1.TopValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.ActualValue;
            cardStretchedLayoutTemplate1.TopValue.Visible = true;
            card1.LayoutTemplate = cardStretchedLayoutTemplate1;
            card1.AddDataItem("ActualValue", measure2);
            this.cardDashboardItem1.Cards.AddRange(new DevExpress.DashboardCommon.Card[] {
            card1});
            this.cardDashboardItem1.ComponentName = "cardDashboardItem1";
            dimension2.DataMember = "MembershipStatus";
            this.cardDashboardItem1.DataItemRepository.Clear();
            this.cardDashboardItem1.DataItemRepository.Add(measure2, "DataItem0");
            this.cardDashboardItem1.DataItemRepository.Add(dimension2, "DataItem1");
            this.cardDashboardItem1.DataMember = "members";
            this.cardDashboardItem1.DataSource = this.dashboardSqlDataSource1;
            this.cardDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.cardDashboardItem1.Name = "Membership Status";
            this.cardDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension2});
            this.cardDashboardItem1.ShowCaption = true;
            // 
            // pieDashboardItem1
            // 
            dimension3.DataMember = "MembershipStatus";
            this.pieDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3});
            this.pieDashboardItem1.ComponentName = "pieDashboardItem1";
            measure3.DataMember = "MembershipNumber";
            measure3.Name = "Membership Status Distribution";
            measure3.SummaryType = DevExpress.DashboardCommon.SummaryType.Count;
            this.pieDashboardItem1.DataItemRepository.Clear();
            this.pieDashboardItem1.DataItemRepository.Add(measure3, "DataItem0");
            this.pieDashboardItem1.DataItemRepository.Add(dimension3, "DataItem1");
            this.pieDashboardItem1.DataMember = "members";
            this.pieDashboardItem1.DataSource = this.dashboardSqlDataSource1;
            this.pieDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.pieDashboardItem1.Name = "Members Status Distribution";
            this.pieDashboardItem1.ShowCaption = true;
            this.pieDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure3});
            // 
            // cardDashboardItem2
            // 
            measure4.DataMember = "MembershipNumber";
            measure4.SummaryType = DevExpress.DashboardCommon.SummaryType.Count;
            cardStretchedLayoutTemplate2.BottomValue1.DimensionIndex = 0;
            cardStretchedLayoutTemplate2.BottomValue1.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.PercentVariation;
            cardStretchedLayoutTemplate2.BottomValue1.Visible = true;
            cardStretchedLayoutTemplate2.BottomValue2.DimensionIndex = 0;
            cardStretchedLayoutTemplate2.BottomValue2.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.AbsoluteVariation;
            cardStretchedLayoutTemplate2.BottomValue2.Visible = true;
            cardStretchedLayoutTemplate2.DeltaIndicator.Visible = true;
            cardStretchedLayoutTemplate2.MainValue.DimensionIndex = 0;
            cardStretchedLayoutTemplate2.MainValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Title;
            cardStretchedLayoutTemplate2.MainValue.Visible = true;
            cardStretchedLayoutTemplate2.Sparkline.Visible = true;
            cardStretchedLayoutTemplate2.SubValue.DimensionIndex = 0;
            cardStretchedLayoutTemplate2.SubValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Subtitle;
            cardStretchedLayoutTemplate2.SubValue.Visible = true;
            cardStretchedLayoutTemplate2.TopValue.DimensionIndex = 0;
            cardStretchedLayoutTemplate2.TopValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.ActualValue;
            cardStretchedLayoutTemplate2.TopValue.Visible = true;
            card2.LayoutTemplate = cardStretchedLayoutTemplate2;
            card2.AddDataItem("ActualValue", measure4);
            this.cardDashboardItem2.Cards.AddRange(new DevExpress.DashboardCommon.Card[] {
            card2});
            this.cardDashboardItem2.ComponentName = "cardDashboardItem2";
            dimension4.DataMember = "Gender";
            this.cardDashboardItem2.DataItemRepository.Clear();
            this.cardDashboardItem2.DataItemRepository.Add(measure4, "DataItem0");
            this.cardDashboardItem2.DataItemRepository.Add(dimension4, "DataItem1");
            this.cardDashboardItem2.DataMember = "members";
            this.cardDashboardItem2.DataSource = this.dashboardSqlDataSource1;
            this.cardDashboardItem2.InteractivityOptions.IgnoreMasterFilters = false;
            this.cardDashboardItem2.Name = "Membership By Gender";
            this.cardDashboardItem2.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension4});
            this.cardDashboardItem2.ShowCaption = true;
            // 
            // pieDashboardItem2
            // 
            dimension5.DataMember = "Gender";
            this.pieDashboardItem2.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension5});
            this.pieDashboardItem2.ComponentName = "pieDashboardItem2";
            measure5.DataMember = "MembershipNumber";
            measure5.Name = "Gender Distribution";
            measure5.SummaryType = DevExpress.DashboardCommon.SummaryType.Count;
            this.pieDashboardItem2.DataItemRepository.Clear();
            this.pieDashboardItem2.DataItemRepository.Add(measure5, "DataItem0");
            this.pieDashboardItem2.DataItemRepository.Add(dimension5, "DataItem1");
            this.pieDashboardItem2.DataMember = "members";
            this.pieDashboardItem2.DataSource = this.dashboardSqlDataSource1;
            this.pieDashboardItem2.InteractivityOptions.IgnoreMasterFilters = false;
            this.pieDashboardItem2.Name = "Members Gender Distribution";
            this.pieDashboardItem2.ShowCaption = true;
            this.pieDashboardItem2.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure5});
            // 
            // Members
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardSqlDataSource1});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.rangeFilterDashboardItem1,
            this.cardDashboardItem1,
            this.cardDashboardItem2,
            this.pieDashboardItem1,
            this.pieDashboardItem2});
            dashboardLayoutItem1.DashboardItem = this.rangeFilterDashboardItem1;
            dashboardLayoutItem1.Weight = 33.14176245210728D;
            dashboardLayoutItem2.DashboardItem = this.cardDashboardItem1;
            dashboardLayoutItem2.Weight = 42.155688622754489D;
            dashboardLayoutItem3.DashboardItem = this.pieDashboardItem1;
            dashboardLayoutItem3.Weight = 57.844311377245511D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem2,
            dashboardLayoutItem3});
            dashboardLayoutGroup2.DashboardItem = null;
            dashboardLayoutGroup2.Weight = 33.333333333333336D;
            dashboardLayoutItem4.DashboardItem = this.cardDashboardItem2;
            dashboardLayoutItem4.Weight = 42.155688622754489D;
            dashboardLayoutItem5.DashboardItem = this.pieDashboardItem2;
            dashboardLayoutItem5.Weight = 57.844311377245511D;
            dashboardLayoutGroup3.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem4,
            dashboardLayoutItem5});
            dashboardLayoutGroup3.DashboardItem = null;
            dashboardLayoutGroup3.Weight = 33.524904214559385D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutGroup2,
            dashboardLayoutGroup3});
            dashboardLayoutGroup1.DashboardItem = null;
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup1.Weight = 100D;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeFilterDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardSqlDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDashboardItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieDashboardItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.RangeFilterDashboardItem rangeFilterDashboardItem1;
        private DevExpress.DashboardCommon.DashboardSqlDataSource dashboardSqlDataSource1;
        private DevExpress.DashboardCommon.CardDashboardItem cardDashboardItem1;
        private DevExpress.DashboardCommon.CardDashboardItem cardDashboardItem2;
        private DevExpress.DashboardCommon.PieDashboardItem pieDashboardItem1;
        private DevExpress.DashboardCommon.PieDashboardItem pieDashboardItem2;
    }
}
