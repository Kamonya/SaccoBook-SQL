namespace SaccoBook.Modules.Settings.DocumentApprovals
{
    partial class DocumentApprovalUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentApprovalUser));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_save = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._ApprovalSubstitute = new DevExpress.XtraEditors.ComboBoxEdit();
            this._ApprovalSubstituteEmail = new DevExpress.XtraEditors.TextEdit();
            this._ApproverEmail = new DevExpress.XtraEditors.TextEdit();
            this._Approver = new DevExpress.XtraEditors.ComboBoxEdit();
            this._ApprovalSequence = new DevExpress.XtraEditors.ComboBoxEdit();
            this._Document = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider_DocumentApprovalUser = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ApprovalSubstitute.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ApprovalSubstituteEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ApproverEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Approver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ApprovalSequence.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Document.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider_DocumentApprovalUser)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(633, 143);
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 317);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(633, 31);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._ApprovalSubstitute);
            this.layoutControl1.Controls.Add(this._ApprovalSubstituteEmail);
            this.layoutControl1.Controls.Add(this._ApproverEmail);
            this.layoutControl1.Controls.Add(this._Approver);
            this.layoutControl1.Controls.Add(this._ApprovalSequence);
            this.layoutControl1.Controls.Add(this._Document);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 143);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(633, 174);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _ApprovalSubstitute
            // 
            this._ApprovalSubstitute.Location = new System.Drawing.Point(114, 108);
            this._ApprovalSubstitute.MenuManager = this.ribbon;
            this._ApprovalSubstitute.Name = "_ApprovalSubstitute";
            this._ApprovalSubstitute.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._ApprovalSubstitute.Size = new System.Drawing.Size(507, 20);
            this._ApprovalSubstitute.StyleController = this.layoutControl1;
            this._ApprovalSubstitute.TabIndex = 9;
            // 
            // _ApprovalSubstituteEmail
            // 
            this._ApprovalSubstituteEmail.Location = new System.Drawing.Point(114, 132);
            this._ApprovalSubstituteEmail.MenuManager = this.ribbon;
            this._ApprovalSubstituteEmail.Name = "_ApprovalSubstituteEmail";
            this._ApprovalSubstituteEmail.Size = new System.Drawing.Size(507, 20);
            this._ApprovalSubstituteEmail.StyleController = this.layoutControl1;
            this._ApprovalSubstituteEmail.TabIndex = 8;
            // 
            // _ApproverEmail
            // 
            this._ApproverEmail.Location = new System.Drawing.Point(114, 84);
            this._ApproverEmail.MenuManager = this.ribbon;
            this._ApproverEmail.Name = "_ApproverEmail";
            this._ApproverEmail.Size = new System.Drawing.Size(507, 20);
            this._ApproverEmail.StyleController = this.layoutControl1;
            this._ApproverEmail.TabIndex = 7;
            // 
            // _Approver
            // 
            this._Approver.Location = new System.Drawing.Point(114, 60);
            this._Approver.MenuManager = this.ribbon;
            this._Approver.Name = "_Approver";
            this._Approver.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._Approver.Size = new System.Drawing.Size(507, 20);
            this._Approver.StyleController = this.layoutControl1;
            this._Approver.TabIndex = 6;
            // 
            // _ApprovalSequence
            // 
            this._ApprovalSequence.Location = new System.Drawing.Point(114, 36);
            this._ApprovalSequence.MenuManager = this.ribbon;
            this._ApprovalSequence.Name = "_ApprovalSequence";
            this._ApprovalSequence.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._ApprovalSequence.Size = new System.Drawing.Size(507, 20);
            this._ApprovalSequence.StyleController = this.layoutControl1;
            this._ApprovalSequence.TabIndex = 5;
            // 
            // _Document
            // 
            this._Document.Location = new System.Drawing.Point(114, 12);
            this._Document.MenuManager = this.ribbon;
            this._Document.Name = "_Document";
            this._Document.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._Document.Size = new System.Drawing.Size(507, 20);
            this._Document.StyleController = this.layoutControl1;
            this._Document.TabIndex = 4;
            this._Document.SelectedIndexChanged += new System.EventHandler(this._Document_SelectedIndexChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(633, 174);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 144);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(613, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._Document;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(613, 24);
            this.layoutControlItem1.Text = "Document:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(99, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._ApprovalSequence;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(613, 24);
            this.layoutControlItem2.Text = "Approval Sequence:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(99, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._Approver;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(613, 24);
            this.layoutControlItem3.Text = "Approver:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(99, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this._ApproverEmail;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(613, 24);
            this.layoutControlItem4.Text = "Email:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(99, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this._ApprovalSubstitute;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(613, 24);
            this.layoutControlItem6.Text = "Approval Substitute:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(99, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._ApprovalSubstituteEmail;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(613, 24);
            this.layoutControlItem5.Text = "Substitute Email:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(99, 13);
            // 
            // DocumentApprovalUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 348);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DocumentApprovalUser";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Document approval user";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._ApprovalSubstitute.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ApprovalSubstituteEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ApproverEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Approver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ApprovalSequence.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Document.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider_DocumentApprovalUser)).EndInit();
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
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraBars.BarButtonItem btn_save;
        private DevExpress.XtraEditors.ComboBoxEdit _ApprovalSubstitute;
        private DevExpress.XtraEditors.TextEdit _ApprovalSubstituteEmail;
        private DevExpress.XtraEditors.TextEdit _ApproverEmail;
        private DevExpress.XtraEditors.ComboBoxEdit _Approver;
        private DevExpress.XtraEditors.ComboBoxEdit _ApprovalSequence;
        private DevExpress.XtraEditors.ComboBoxEdit _Document;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider_DocumentApprovalUser;
    }
}