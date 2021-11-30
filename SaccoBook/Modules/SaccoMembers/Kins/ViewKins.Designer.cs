namespace SaccoBook.Modules.SaccoMembers.Kins
{
    partial class ViewKins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewKins));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_addkin = new DevExpress.XtraBars.BarButtonItem();
            this.btn_edit = new DevExpress.XtraBars.BarButtonItem();
            this.btn_delete = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.KinsGridControl = new DevExpress.XtraGrid.GridControl();
            this.KinsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_refresh = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KinsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KinsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btn_addkin,
            this.btn_edit,
            this.btn_delete,
            this.btn_refresh});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1026, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_addkin
            // 
            this.btn_addkin.Caption = "Add Kin";
            this.btn_addkin.Id = 1;
            this.btn_addkin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_addkin.ImageOptions.Image")));
            this.btn_addkin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_addkin.ImageOptions.LargeImage")));
            this.btn_addkin.Name = "btn_addkin";
            this.btn_addkin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_addkin_ItemClick);
            // 
            // btn_edit
            // 
            this.btn_edit.Caption = "Edit";
            this.btn_edit.Id = 2;
            this.btn_edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.ImageOptions.Image")));
            this.btn_edit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_edit.ImageOptions.LargeImage")));
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_edit_ItemClick);
            // 
            // btn_delete
            // 
            this.btn_delete.Caption = "Delete";
            this.btn_delete.Id = 3;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.LargeImage")));
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_delete_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_addkin);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "New";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_edit);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Edit";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_delete);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Delete";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 585);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1026, 31);
            // 
            // KinsGridControl
            // 
            this.KinsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KinsGridControl.Location = new System.Drawing.Point(0, 143);
            this.KinsGridControl.MainView = this.KinsGridView;
            this.KinsGridControl.MenuManager = this.ribbon;
            this.KinsGridControl.Name = "KinsGridControl";
            this.KinsGridControl.Size = new System.Drawing.Size(1026, 442);
            this.KinsGridControl.TabIndex = 2;
            this.KinsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.KinsGridView});
            // 
            // KinsGridView
            // 
            this.KinsGridView.GridControl = this.KinsGridControl;
            this.KinsGridView.Name = "KinsGridView";
            this.KinsGridView.OptionsBehavior.Editable = false;
            this.KinsGridView.OptionsFind.AlwaysVisible = true;
            this.KinsGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.KinsGridView_RowClick);
            this.KinsGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.KinsGridView_FocusedRowChanged);
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup4.ImageOptions.Image")));
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_refresh);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Refresh";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Caption = "Refresh";
            this.btn_refresh.Id = 4;
            this.btn_refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btn_refresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_refresh_ItemClick);
            // 
            // ViewKins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 616);
            this.Controls.Add(this.KinsGridControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewKins";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "ViewKins";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KinsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KinsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl KinsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView KinsGridView;
        private DevExpress.XtraBars.BarButtonItem btn_addkin;
        private DevExpress.XtraBars.BarButtonItem btn_edit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_delete;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btn_refresh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}