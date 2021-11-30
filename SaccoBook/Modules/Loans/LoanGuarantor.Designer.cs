namespace SaccoBook.Modules.Loans
{
    partial class LoanGuarantor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanGuarantor));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_save = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._AmountGuaranteed = new DevExpress.XtraEditors.TextEdit();
            this._Address = new DevExpress.XtraEditors.MemoEdit();
            this._Phone = new DevExpress.XtraEditors.TextEdit();
            this._Email = new DevExpress.XtraEditors.TextEdit();
            this._DateOfBirth = new DevExpress.XtraEditors.DateEdit();
            this._Name = new DevExpress.XtraEditors.TextEdit();
            this._IdNumber = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._AmountGuaranteed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DateOfBirth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DateOfBirth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._IdNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(442, 143);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_save);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Save";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(442, 31);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._AmountGuaranteed);
            this.layoutControl1.Controls.Add(this._Address);
            this.layoutControl1.Controls.Add(this._Phone);
            this.layoutControl1.Controls.Add(this._Email);
            this.layoutControl1.Controls.Add(this._DateOfBirth);
            this.layoutControl1.Controls.Add(this._Name);
            this.layoutControl1.Controls.Add(this._IdNumber);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 143);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(442, 275);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _AmountGuaranteed
            // 
            this._AmountGuaranteed.Location = new System.Drawing.Point(128, 231);
            this._AmountGuaranteed.MenuManager = this.ribbon;
            this._AmountGuaranteed.Name = "_AmountGuaranteed";
            this._AmountGuaranteed.Properties.Mask.BeepOnError = true;
            this._AmountGuaranteed.Properties.Mask.EditMask = "n2";
            this._AmountGuaranteed.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._AmountGuaranteed.Properties.Mask.PlaceHolder = '0';
            this._AmountGuaranteed.Properties.Mask.UseMaskAsDisplayFormat = true;
            this._AmountGuaranteed.Size = new System.Drawing.Size(290, 20);
            this._AmountGuaranteed.StyleController = this.layoutControl1;
            this._AmountGuaranteed.TabIndex = 14;
            // 
            // _Address
            // 
            this._Address.Location = new System.Drawing.Point(128, 162);
            this._Address.Name = "_Address";
            this._Address.Size = new System.Drawing.Size(290, 65);
            this._Address.StyleController = this.layoutControl1;
            this._Address.TabIndex = 12;
            // 
            // _Phone
            // 
            this._Phone.Location = new System.Drawing.Point(128, 138);
            this._Phone.Name = "_Phone";
            this._Phone.Size = new System.Drawing.Size(290, 20);
            this._Phone.StyleController = this.layoutControl1;
            this._Phone.TabIndex = 8;
            // 
            // _Email
            // 
            this._Email.Location = new System.Drawing.Point(128, 114);
            this._Email.Name = "_Email";
            this._Email.Size = new System.Drawing.Size(290, 20);
            this._Email.StyleController = this.layoutControl1;
            this._Email.TabIndex = 7;
            // 
            // _DateOfBirth
            // 
            this._DateOfBirth.EditValue = null;
            this._DateOfBirth.Location = new System.Drawing.Point(128, 90);
            this._DateOfBirth.Name = "_DateOfBirth";
            this._DateOfBirth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._DateOfBirth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._DateOfBirth.Size = new System.Drawing.Size(290, 20);
            this._DateOfBirth.StyleController = this.layoutControl1;
            this._DateOfBirth.TabIndex = 13;
            // 
            // _Name
            // 
            this._Name.Location = new System.Drawing.Point(128, 66);
            this._Name.Name = "_Name";
            this._Name.Size = new System.Drawing.Size(290, 20);
            this._Name.StyleController = this.layoutControl1;
            this._Name.TabIndex = 6;
            // 
            // _IdNumber
            // 
            this._IdNumber.Location = new System.Drawing.Point(128, 42);
            this._IdNumber.Name = "_IdNumber";
            this._IdNumber.Size = new System.Drawing.Size(290, 20);
            this._IdNumber.StyleController = this.layoutControl1;
            this._IdNumber.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(442, 275);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Signatory Information";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem10,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(422, 255);
            this.layoutControlGroup2.Text = "Signatory Information";
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this._Address;
            this.layoutControlItem9.CustomizationFormText = "Address";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(398, 69);
            this.layoutControlItem9.Text = "Address";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(101, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._Phone;
            this.layoutControlItem5.CustomizationFormText = "Phone Number:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(398, 24);
            this.layoutControlItem5.Text = "Phone Number:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(101, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this._Email;
            this.layoutControlItem4.CustomizationFormText = "Email:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(398, 24);
            this.layoutControlItem4.Text = "Email:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(101, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this._DateOfBirth;
            this.layoutControlItem10.CustomizationFormText = "Date Of Birth:";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(398, 24);
            this.layoutControlItem10.Text = "Date Of Birth:";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(101, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._Name;
            this.layoutControlItem3.CustomizationFormText = "Names:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(398, 24);
            this.layoutControlItem3.Text = "Names:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(101, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._IdNumber;
            this.layoutControlItem1.CustomizationFormText = "Id Number:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(398, 24);
            this.layoutControlItem1.Text = "Id Number:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(101, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._AmountGuaranteed;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 189);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(398, 24);
            this.layoutControlItem2.Text = "Amount Guaranteed:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(101, 13);
            // 
            // LoanGuarantor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 449);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "LoanGuarantor";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Loan Guarantor";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._AmountGuaranteed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DateOfBirth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DateOfBirth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._IdNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btn_save;
        private DevExpress.XtraEditors.MemoEdit _Address;
        private DevExpress.XtraEditors.TextEdit _Phone;
        private DevExpress.XtraEditors.TextEdit _Email;
        private DevExpress.XtraEditors.DateEdit _DateOfBirth;
        private DevExpress.XtraEditors.TextEdit _Name;
        private DevExpress.XtraEditors.TextEdit _IdNumber;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit _AmountGuaranteed;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}