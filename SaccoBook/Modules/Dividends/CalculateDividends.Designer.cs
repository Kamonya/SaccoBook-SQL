namespace SaccoBook.Modules.Dividends
{
    partial class CalculateDividends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateDividends));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._NetPayable = new DevExpress.XtraEditors.TextEdit();
            this._ExciseDuty = new DevExpress.XtraEditors.TextEdit();
            this._ProcessingFee = new DevExpress.XtraEditors.TextEdit();
            this._DividendCapitalisation = new DevExpress.XtraEditors.TextEdit();
            this._WHT = new DevExpress.XtraEditors.TextEdit();
            this._GrossDividends = new DevExpress.XtraEditors.TextEdit();
            this._TotalInterestsPayable = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._NetPayable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ExciseDuty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ProcessingFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DividendCapitalisation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._WHT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GrossDividends.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._TotalInterestsPayable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(701, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Generate Report";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Report";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 536);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(701, 31);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._NetPayable);
            this.layoutControl1.Controls.Add(this._ExciseDuty);
            this.layoutControl1.Controls.Add(this._ProcessingFee);
            this.layoutControl1.Controls.Add(this._DividendCapitalisation);
            this.layoutControl1.Controls.Add(this._WHT);
            this.layoutControl1.Controls.Add(this._GrossDividends);
            this.layoutControl1.Controls.Add(this._TotalInterestsPayable);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 143);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(701, 393);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _NetPayable
            // 
            this._NetPayable.Location = new System.Drawing.Point(560, 361);
            this._NetPayable.MenuManager = this.ribbon;
            this._NetPayable.Name = "_NetPayable";
            this._NetPayable.Properties.Appearance.Options.UseTextOptions = true;
            this._NetPayable.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._NetPayable.Size = new System.Drawing.Size(129, 20);
            this._NetPayable.StyleController = this.layoutControl1;
            this._NetPayable.TabIndex = 12;
            // 
            // _ExciseDuty
            // 
            this._ExciseDuty.Location = new System.Drawing.Point(560, 337);
            this._ExciseDuty.MenuManager = this.ribbon;
            this._ExciseDuty.Name = "_ExciseDuty";
            this._ExciseDuty.Properties.Appearance.Options.UseTextOptions = true;
            this._ExciseDuty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._ExciseDuty.Properties.DisplayFormat.FormatString = "n2";
            this._ExciseDuty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this._ExciseDuty.Properties.Mask.EditMask = "n2";
            this._ExciseDuty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._ExciseDuty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this._ExciseDuty.Size = new System.Drawing.Size(129, 20);
            this._ExciseDuty.StyleController = this.layoutControl1;
            this._ExciseDuty.TabIndex = 11;
            // 
            // _ProcessingFee
            // 
            this._ProcessingFee.Location = new System.Drawing.Point(560, 313);
            this._ProcessingFee.MenuManager = this.ribbon;
            this._ProcessingFee.Name = "_ProcessingFee";
            this._ProcessingFee.Properties.Appearance.Options.UseTextOptions = true;
            this._ProcessingFee.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._ProcessingFee.Properties.Mask.EditMask = "n2";
            this._ProcessingFee.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._ProcessingFee.Properties.Mask.UseMaskAsDisplayFormat = true;
            this._ProcessingFee.Size = new System.Drawing.Size(129, 20);
            this._ProcessingFee.StyleController = this.layoutControl1;
            this._ProcessingFee.TabIndex = 10;
            // 
            // _DividendCapitalisation
            // 
            this._DividendCapitalisation.Location = new System.Drawing.Point(560, 289);
            this._DividendCapitalisation.MenuManager = this.ribbon;
            this._DividendCapitalisation.Name = "_DividendCapitalisation";
            this._DividendCapitalisation.Properties.Appearance.Options.UseTextOptions = true;
            this._DividendCapitalisation.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._DividendCapitalisation.Properties.Mask.EditMask = "n2";
            this._DividendCapitalisation.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._DividendCapitalisation.Properties.Mask.UseMaskAsDisplayFormat = true;
            this._DividendCapitalisation.Size = new System.Drawing.Size(129, 20);
            this._DividendCapitalisation.StyleController = this.layoutControl1;
            this._DividendCapitalisation.TabIndex = 9;
            // 
            // _WHT
            // 
            this._WHT.Location = new System.Drawing.Point(560, 265);
            this._WHT.MenuManager = this.ribbon;
            this._WHT.Name = "_WHT";
            this._WHT.Properties.Appearance.Options.UseTextOptions = true;
            this._WHT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._WHT.Properties.Mask.EditMask = "n2";
            this._WHT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._WHT.Properties.Mask.UseMaskAsDisplayFormat = true;
            this._WHT.Size = new System.Drawing.Size(129, 20);
            this._WHT.StyleController = this.layoutControl1;
            this._WHT.TabIndex = 8;
            // 
            // _GrossDividends
            // 
            this._GrossDividends.Location = new System.Drawing.Point(560, 241);
            this._GrossDividends.MenuManager = this.ribbon;
            this._GrossDividends.Name = "_GrossDividends";
            this._GrossDividends.Properties.Appearance.Options.UseTextOptions = true;
            this._GrossDividends.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._GrossDividends.Properties.Mask.EditMask = "n2";
            this._GrossDividends.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._GrossDividends.Properties.Mask.UseMaskAsDisplayFormat = true;
            this._GrossDividends.Size = new System.Drawing.Size(129, 20);
            this._GrossDividends.StyleController = this.layoutControl1;
            this._GrossDividends.TabIndex = 7;
            // 
            // _TotalInterestsPayable
            // 
            this._TotalInterestsPayable.Location = new System.Drawing.Point(560, 217);
            this._TotalInterestsPayable.MenuManager = this.ribbon;
            this._TotalInterestsPayable.Name = "_TotalInterestsPayable";
            this._TotalInterestsPayable.Properties.Appearance.Options.UseTextOptions = true;
            this._TotalInterestsPayable.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this._TotalInterestsPayable.Properties.Mask.EditMask = "n2";
            this._TotalInterestsPayable.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._TotalInterestsPayable.Properties.Mask.UseMaskAsDisplayFormat = true;
            this._TotalInterestsPayable.Size = new System.Drawing.Size(129, 20);
            this._TotalInterestsPayable.StyleController = this.layoutControl1;
            this._TotalInterestsPayable.TabIndex = 6;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(677, 201);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem1,
            this.layoutControlItem9});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(701, 393);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(681, 205);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._TotalInterestsPayable;
            this.layoutControlItem3.Location = new System.Drawing.Point(382, 205);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(299, 24);
            this.layoutControlItem3.Text = "Total Interest payable at 10.5 %:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(163, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this._GrossDividends;
            this.layoutControlItem4.Location = new System.Drawing.Point(382, 229);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(299, 24);
            this.layoutControlItem4.Text = "Gross dividends/Rebates:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(163, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this._WHT;
            this.layoutControlItem5.Location = new System.Drawing.Point(382, 253);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(299, 24);
            this.layoutControlItem5.Text = "Withholding Tax(5%):";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(163, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this._DividendCapitalisation;
            this.layoutControlItem6.Location = new System.Drawing.Point(382, 277);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(299, 24);
            this.layoutControlItem6.Text = "Dividend Capitalization:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(163, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem7.Control = this._ProcessingFee;
            this.layoutControlItem7.Location = new System.Drawing.Point(382, 301);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(299, 24);
            this.layoutControlItem7.Text = "Processing Fee:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(163, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
            this.layoutControlItem8.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem8.Control = this._ExciseDuty;
            this.layoutControlItem8.Location = new System.Drawing.Point(382, 325);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(299, 24);
            this.layoutControlItem8.Text = "Excise Duty:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(163, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 205);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(382, 168);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.layoutControlItem9.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem9.Control = this._NetPayable;
            this.layoutControlItem9.Location = new System.Drawing.Point(382, 349);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(299, 24);
            this.layoutControlItem9.Text = "Net payable (FOSA A/C):";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(163, 13);
            // 
            // CalculateDividends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 567);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculateDividends";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Calculate Dividends";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._NetPayable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ExciseDuty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ProcessingFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DividendCapitalisation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._WHT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GrossDividends.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._TotalInterestsPayable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit _NetPayable;
        private DevExpress.XtraEditors.TextEdit _ExciseDuty;
        private DevExpress.XtraEditors.TextEdit _ProcessingFee;
        private DevExpress.XtraEditors.TextEdit _DividendCapitalisation;
        private DevExpress.XtraEditors.TextEdit _WHT;
        private DevExpress.XtraEditors.TextEdit _GrossDividends;
        private DevExpress.XtraEditors.TextEdit _TotalInterestsPayable;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}