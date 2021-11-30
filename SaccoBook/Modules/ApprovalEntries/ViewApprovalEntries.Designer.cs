namespace SaccoBook.Modules.ApprovalEntries
{
    partial class ViewApprovalEntries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewApprovalEntries));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_approve = new DevExpress.XtraBars.BarButtonItem();
            this.btn_reject = new DevExpress.XtraBars.BarButtonItem();
            this.btn_delegate = new DevExpress.XtraBars.BarButtonItem();
            this.btn_view = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.GridControlApprovalEntries = new DevExpress.XtraGrid.GridControl();
            this.GridViewApprovalEntries = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlApprovalEntries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewApprovalEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btn_approve,
            this.btn_reject,
            this.btn_delegate,
            this.btn_view});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(854, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_approve
            // 
            this.btn_approve.Caption = "Approve";
            this.btn_approve.Id = 1;
            this.btn_approve.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_approve.ImageOptions.Image")));
            this.btn_approve.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_approve.ImageOptions.LargeImage")));
            this.btn_approve.Name = "btn_approve";
            this.btn_approve.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_approve_ItemClick);
            // 
            // btn_reject
            // 
            this.btn_reject.Caption = "Reject";
            this.btn_reject.Id = 2;
            this.btn_reject.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_reject.ImageOptions.Image")));
            this.btn_reject.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_reject.ImageOptions.LargeImage")));
            this.btn_reject.Name = "btn_reject";
            this.btn_reject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_reject_ItemClick);
            // 
            // btn_delegate
            // 
            this.btn_delegate.Caption = "Delegate";
            this.btn_delegate.Id = 3;
            this.btn_delegate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delegate.ImageOptions.Image")));
            this.btn_delegate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_delegate.ImageOptions.LargeImage")));
            this.btn_delegate.Name = "btn_delegate";
            this.btn_delegate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_delegate_ItemClick);
            // 
            // btn_view
            // 
            this.btn_view.Caption = "View Record";
            this.btn_view.Id = 4;
            this.btn_view.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_view.ImageOptions.LargeImage")));
            this.btn_view.Name = "btn_view";
            this.btn_view.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_view_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_view);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "View";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_approve);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_reject, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_delegate);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Actions";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 466);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(854, 31);
            // 
            // GridControlApprovalEntries
            // 
            this.GridControlApprovalEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlApprovalEntries.Location = new System.Drawing.Point(0, 143);
            this.GridControlApprovalEntries.MainView = this.GridViewApprovalEntries;
            this.GridControlApprovalEntries.MenuManager = this.ribbon;
            this.GridControlApprovalEntries.Name = "GridControlApprovalEntries";
            this.GridControlApprovalEntries.Size = new System.Drawing.Size(854, 323);
            this.GridControlApprovalEntries.TabIndex = 2;
            this.GridControlApprovalEntries.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewApprovalEntries});
            // 
            // GridViewApprovalEntries
            // 
            this.GridViewApprovalEntries.GridControl = this.GridControlApprovalEntries;
            this.GridViewApprovalEntries.Name = "GridViewApprovalEntries";
            this.GridViewApprovalEntries.OptionsBehavior.Editable = false;
            this.GridViewApprovalEntries.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewApprovalEntries_RowClick);
            this.GridViewApprovalEntries.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewApprovalEntries_FocusedRowChanged);
            // 
            // ViewApprovalEntries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 497);
            this.Controls.Add(this.GridControlApprovalEntries);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewApprovalEntries";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "View Approval Entries";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlApprovalEntries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewApprovalEntries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl GridControlApprovalEntries;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewApprovalEntries;
        private DevExpress.XtraBars.BarButtonItem btn_approve;
        private DevExpress.XtraBars.BarButtonItem btn_reject;
        private DevExpress.XtraBars.BarButtonItem btn_delegate;
        private DevExpress.XtraBars.BarButtonItem btn_view;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}