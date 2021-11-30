namespace SaccoBook.Modules.SaccoMembers.SavingsAccounts
{
    partial class ViewSavingsAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSavingsAccounts));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_newaccount = new DevExpress.XtraBars.BarButtonItem();
            this.btn_edit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.SavingsAccountsGridControl = new DevExpress.XtraGrid.GridControl();
            this.SavingsAccountsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_refresh = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SavingsAccountsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SavingsAccountsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btn_newaccount,
            this.btn_edit,
            this.btn_refresh});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1015, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_newaccount
            // 
            this.btn_newaccount.Caption = "New Account";
            this.btn_newaccount.Id = 1;
            this.btn_newaccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_newaccount.ImageOptions.Image")));
            this.btn_newaccount.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_newaccount.ImageOptions.LargeImage")));
            this.btn_newaccount.Name = "btn_newaccount";
            this.btn_newaccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_newaccount_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_newaccount);
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
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 485);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1015, 31);
            // 
            // SavingsAccountsGridControl
            // 
            this.SavingsAccountsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SavingsAccountsGridControl.Location = new System.Drawing.Point(0, 143);
            this.SavingsAccountsGridControl.MainView = this.SavingsAccountsGridView;
            this.SavingsAccountsGridControl.MenuManager = this.ribbon;
            this.SavingsAccountsGridControl.Name = "SavingsAccountsGridControl";
            this.SavingsAccountsGridControl.Size = new System.Drawing.Size(1015, 342);
            this.SavingsAccountsGridControl.TabIndex = 2;
            this.SavingsAccountsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SavingsAccountsGridView});
            // 
            // SavingsAccountsGridView
            // 
            this.SavingsAccountsGridView.GridControl = this.SavingsAccountsGridControl;
            this.SavingsAccountsGridView.Name = "SavingsAccountsGridView";
            this.SavingsAccountsGridView.OptionsBehavior.Editable = false;
            this.SavingsAccountsGridView.OptionsFind.AlwaysVisible = true;
            this.SavingsAccountsGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.SavingsAccountsGridView_RowClick);
            this.SavingsAccountsGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.SavingsAccountsGridView_FocusedRowChanged);
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_refresh);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Refresh";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Caption = "Refresh";
            this.btn_refresh.Id = 3;
            this.btn_refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btn_refresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_refresh_ItemClick);
            // 
            // ViewSavingsAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 516);
            this.Controls.Add(this.SavingsAccountsGridControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewSavingsAccounts";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "View Savings Accounts";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SavingsAccountsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SavingsAccountsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl SavingsAccountsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView SavingsAccountsGridView;
        private DevExpress.XtraBars.BarButtonItem btn_newaccount;
        private DevExpress.XtraBars.BarButtonItem btn_edit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_refresh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}