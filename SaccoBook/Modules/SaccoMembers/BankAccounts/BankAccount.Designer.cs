namespace SaccoBook.Modules.SaccoMembers.BankAccounts
{
    partial class BankAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankAccount));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_save = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._AccountNumber = new DevExpress.XtraEditors.TextEdit();
            this._Branch = new DevExpress.XtraEditors.TextEdit();
            this._BankName = new DevExpress.XtraEditors.TextEdit();
            this._Name = new DevExpress.XtraEditors.TextEdit();
            this._MembershipNumber = new DevExpress.XtraEditors.TextEdit();
            this._NationalIdNumber = new DevExpress.XtraEditors.TextEdit();
            this._DateJoined = new DevExpress.XtraEditors.DateEdit();
            this._MembershipStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup10 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem25 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem26 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem28 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProviderBankAccount = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._AccountNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Branch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._MembershipNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._NationalIdNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DateJoined.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DateJoined.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._MembershipStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderBankAccount)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(640, 143);
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 491);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(640, 31);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._AccountNumber);
            this.layoutControl1.Controls.Add(this._Branch);
            this.layoutControl1.Controls.Add(this._BankName);
            this.layoutControl1.Controls.Add(this._Name);
            this.layoutControl1.Controls.Add(this._MembershipNumber);
            this.layoutControl1.Controls.Add(this._NationalIdNumber);
            this.layoutControl1.Controls.Add(this._DateJoined);
            this.layoutControl1.Controls.Add(this._MembershipStatus);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 143);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(640, 348);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _AccountNumber
            // 
            this._AccountNumber.Location = new System.Drawing.Point(122, 252);
            this._AccountNumber.MenuManager = this.ribbon;
            this._AccountNumber.Name = "_AccountNumber";
            this._AccountNumber.Size = new System.Drawing.Size(494, 20);
            this._AccountNumber.StyleController = this.layoutControl1;
            this._AccountNumber.TabIndex = 80;
            // 
            // _Branch
            // 
            this._Branch.Location = new System.Drawing.Point(122, 228);
            this._Branch.MenuManager = this.ribbon;
            this._Branch.Name = "_Branch";
            this._Branch.Size = new System.Drawing.Size(494, 20);
            this._Branch.StyleController = this.layoutControl1;
            this._Branch.TabIndex = 79;
            // 
            // _BankName
            // 
            this._BankName.Location = new System.Drawing.Point(122, 204);
            this._BankName.MenuManager = this.ribbon;
            this._BankName.Name = "_BankName";
            this._BankName.Size = new System.Drawing.Size(494, 20);
            this._BankName.StyleController = this.layoutControl1;
            this._BankName.TabIndex = 78;
            // 
            // _Name
            // 
            this._Name.Location = new System.Drawing.Point(122, 66);
            this._Name.Name = "_Name";
            this._Name.Properties.ReadOnly = true;
            this._Name.Size = new System.Drawing.Size(494, 20);
            this._Name.StyleController = this.layoutControl1;
            this._Name.TabIndex = 49;
            // 
            // _MembershipNumber
            // 
            this._MembershipNumber.Location = new System.Drawing.Point(122, 42);
            this._MembershipNumber.Name = "_MembershipNumber";
            this._MembershipNumber.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d\\d\\d\\d";
            this._MembershipNumber.Properties.Mask.ShowPlaceHolders = false;
            this._MembershipNumber.Properties.ReadOnly = true;
            this._MembershipNumber.Size = new System.Drawing.Size(494, 20);
            this._MembershipNumber.StyleController = this.layoutControl1;
            this._MembershipNumber.TabIndex = 7;
            // 
            // _NationalIdNumber
            // 
            this._NationalIdNumber.Location = new System.Drawing.Point(122, 90);
            this._NationalIdNumber.Name = "_NationalIdNumber";
            this._NationalIdNumber.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d\\d\\d\\d";
            this._NationalIdNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this._NationalIdNumber.Properties.Mask.ShowPlaceHolders = false;
            this._NationalIdNumber.Properties.ReadOnly = true;
            this._NationalIdNumber.Size = new System.Drawing.Size(494, 20);
            this._NationalIdNumber.StyleController = this.layoutControl1;
            this._NationalIdNumber.TabIndex = 64;
            // 
            // _DateJoined
            // 
            this._DateJoined.EditValue = null;
            this._DateJoined.Location = new System.Drawing.Point(122, 114);
            this._DateJoined.Name = "_DateJoined";
            this._DateJoined.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._DateJoined.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._DateJoined.Properties.DisplayFormat.FormatString = "yyyy-MM-d";
            this._DateJoined.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._DateJoined.Properties.EditFormat.FormatString = "yyyy-MM-d";
            this._DateJoined.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this._DateJoined.Properties.Mask.EditMask = "yyyy-MM-d";
            this._DateJoined.Properties.Mask.UseMaskAsDisplayFormat = true;
            this._DateJoined.Properties.ReadOnly = true;
            this._DateJoined.Size = new System.Drawing.Size(494, 20);
            this._DateJoined.StyleController = this.layoutControl1;
            this._DateJoined.TabIndex = 16;
            // 
            // _MembershipStatus
            // 
            this._MembershipStatus.Location = new System.Drawing.Point(122, 138);
            this._MembershipStatus.Name = "_MembershipStatus";
            this._MembershipStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._MembershipStatus.Properties.DropDownRows = 3;
            this._MembershipStatus.Properties.Items.AddRange(new object[] {
            "",
            "Active",
            "Inactive"});
            this._MembershipStatus.Properties.ReadOnly = true;
            this._MembershipStatus.Size = new System.Drawing.Size(494, 20);
            this._MembershipStatus.StyleController = this.layoutControl1;
            this._MembershipStatus.TabIndex = 62;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup10,
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(640, 348);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup10
            // 
            this.layoutControlGroup10.CustomizationFormText = "Basic Information:";
            this.layoutControlGroup10.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem25,
            this.layoutControlItem26,
            this.layoutControlItem28,
            this.layoutControlItem12,
            this.layoutControlItem20});
            this.layoutControlGroup10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup10.Name = "layoutControlGroup10";
            this.layoutControlGroup10.Size = new System.Drawing.Size(620, 162);
            this.layoutControlGroup10.Text = "Basic Details:";
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.Control = this._Name;
            this.layoutControlItem20.CustomizationFormText = "Full Name:";
            this.layoutControlItem20.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(596, 24);
            this.layoutControlItem20.Text = "Full Name:";
            this.layoutControlItem20.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem25
            // 
            this.layoutControlItem25.Control = this._MembershipNumber;
            this.layoutControlItem25.CustomizationFormText = "Membership No: ";
            this.layoutControlItem25.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem25.Name = "layoutControlItem25";
            this.layoutControlItem25.Size = new System.Drawing.Size(596, 24);
            this.layoutControlItem25.Text = "Membership No: ";
            this.layoutControlItem25.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem26
            // 
            this.layoutControlItem26.Control = this._NationalIdNumber;
            this.layoutControlItem26.CustomizationFormText = "Id Number:";
            this.layoutControlItem26.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem26.Name = "layoutControlItem26";
            this.layoutControlItem26.Size = new System.Drawing.Size(596, 24);
            this.layoutControlItem26.Text = "Id Number:";
            this.layoutControlItem26.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem28
            // 
            this.layoutControlItem28.Control = this._DateJoined;
            this.layoutControlItem28.CustomizationFormText = "Date Joined:";
            this.layoutControlItem28.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem28.Name = "layoutControlItem28";
            this.layoutControlItem28.Size = new System.Drawing.Size(596, 24);
            this.layoutControlItem28.Text = "Date Joined:";
            this.layoutControlItem28.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this._MembershipStatus;
            this.layoutControlItem12.CustomizationFormText = "Membership Status:";
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(596, 24);
            this.layoutControlItem12.Text = "Membership Status:";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 162);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(620, 166);
            this.layoutControlGroup1.Text = "Bank Information";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._AccountNumber;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(596, 76);
            this.layoutControlItem3.Text = "Account Number:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._BankName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(596, 24);
            this.layoutControlItem1.Text = "Bank:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._Branch;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(596, 24);
            this.layoutControlItem2.Text = "Branch:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(95, 13);
            // 
            // BankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 522);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BankAccount";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "BankAccount";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._AccountNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Branch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._MembershipNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._NationalIdNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DateJoined.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DateJoined.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._MembershipStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderBankAccount)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btn_save;
        private DevExpress.XtraEditors.TextEdit _AccountNumber;
        private DevExpress.XtraEditors.TextEdit _Branch;
        private DevExpress.XtraEditors.TextEdit _BankName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderBankAccount;
    }
}