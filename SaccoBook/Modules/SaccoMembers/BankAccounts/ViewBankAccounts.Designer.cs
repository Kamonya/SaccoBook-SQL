namespace SaccoBook.Modules.SaccoMembers.BankAccounts
{
    partial class ViewBankAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBankAccounts));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_addbankaccount = new DevExpress.XtraBars.BarButtonItem();
            this.btn_edit = new DevExpress.XtraBars.BarButtonItem();
            this.btn_delete = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.BankAccountGridControl = new DevExpress.XtraGrid.GridControl();
            this.BankAccountGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_refresh = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankAccountGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankAccountGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btn_addbankaccount,
            this.btn_edit,
            this.btn_delete,
            this.btn_refresh});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(960, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_addbankaccount
            // 
            this.btn_addbankaccount.Caption = "Add Bank Acount";
            this.btn_addbankaccount.Id = 1;
            this.btn_addbankaccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_addbankaccount.ImageOptions.Image")));
            this.btn_addbankaccount.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_addbankaccount.ImageOptions.LargeImage")));
            this.btn_addbankaccount.Name = "btn_addbankaccount";
            this.btn_addbankaccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_addbankaccount_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_addbankaccount);
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
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_delete);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Delete";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 496);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(960, 31);
            // 
            // BankAccountGridControl
            // 
            this.BankAccountGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BankAccountGridControl.Location = new System.Drawing.Point(0, 143);
            this.BankAccountGridControl.MainView = this.BankAccountGridView;
            this.BankAccountGridControl.MenuManager = this.ribbon;
            this.BankAccountGridControl.Name = "BankAccountGridControl";
            this.BankAccountGridControl.Size = new System.Drawing.Size(960, 353);
            this.BankAccountGridControl.TabIndex = 2;
            this.BankAccountGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.BankAccountGridView});
            // 
            // BankAccountGridView
            // 
            this.BankAccountGridView.GridControl = this.BankAccountGridControl;
            this.BankAccountGridView.Name = "BankAccountGridView";
            this.BankAccountGridView.OptionsBehavior.Editable = false;
            this.BankAccountGridView.OptionsFind.AlwaysVisible = true;
            this.BankAccountGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.BankAccountGridView_RowClick);
            this.BankAccountGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.BankAccountGridView_FocusedRowChanged);
            // 
            // ribbonPageGroup4
            // 
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
            // ViewBankAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 527);
            this.Controls.Add(this.BankAccountGridControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewBankAccounts";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "ViewBankAccounts";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankAccountGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankAccountGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl BankAccountGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView BankAccountGridView;
        private DevExpress.XtraBars.BarButtonItem btn_addbankaccount;
        private DevExpress.XtraBars.BarButtonItem btn_edit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_delete;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btn_refresh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}