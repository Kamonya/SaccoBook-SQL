namespace SaccoBook.Modules.Settings.Savings
{
    partial class SavingsAccountType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavingsAccountType));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_save = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._WithdrawalCharge = new DevExpress.XtraEditors.TextEdit();
            this._MaximumAmountWithdrawableInADay = new DevExpress.XtraEditors.TextEdit();
            this._MinimumMonthlyContributions = new DevExpress.XtraEditors.TextEdit();
            this._MinimumOpeningBalance = new DevExpress.XtraEditors.TextEdit();
            this._Name = new DevExpress.XtraEditors.TextEdit();
            this._Code = new DevExpress.XtraEditors.TextEdit();
            this._Description = new DevExpress.XtraEditors.MemoEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProviderSavingsAccountType = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._WithdrawalCharge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._MaximumAmountWithdrawableInADay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._MinimumMonthlyContributions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._MinimumOpeningBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderSavingsAccountType)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(520, 143);
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 445);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(520, 31);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._WithdrawalCharge);
            this.layoutControl1.Controls.Add(this._MaximumAmountWithdrawableInADay);
            this.layoutControl1.Controls.Add(this._MinimumMonthlyContributions);
            this.layoutControl1.Controls.Add(this._MinimumOpeningBalance);
            this.layoutControl1.Controls.Add(this._Name);
            this.layoutControl1.Controls.Add(this._Code);
            this.layoutControl1.Controls.Add(this._Description);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 143);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(520, 302);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _WithdrawalCharge
            // 
            this._WithdrawalCharge.Location = new System.Drawing.Point(229, 208);
            this._WithdrawalCharge.MenuManager = this.ribbon;
            this._WithdrawalCharge.Name = "_WithdrawalCharge";
            this._WithdrawalCharge.Properties.Mask.EditMask = "n2";
            this._WithdrawalCharge.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._WithdrawalCharge.Properties.Mask.UseMaskAsDisplayFormat = true;
            this._WithdrawalCharge.Size = new System.Drawing.Size(267, 20);
            this._WithdrawalCharge.StyleController = this.layoutControl1;
            this._WithdrawalCharge.TabIndex = 10;
            // 
            // _MaximumAmountWithdrawableInADay
            // 
            this._MaximumAmountWithdrawableInADay.Location = new System.Drawing.Point(229, 184);
            this._MaximumAmountWithdrawableInADay.MenuManager = this.ribbon;
            this._MaximumAmountWithdrawableInADay.Name = "_MaximumAmountWithdrawableInADay";
            this._MaximumAmountWithdrawableInADay.Properties.Mask.EditMask = "n2";
            this._MaximumAmountWithdrawableInADay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._MaximumAmountWithdrawableInADay.Properties.Mask.UseMaskAsDisplayFormat = true;
            this._MaximumAmountWithdrawableInADay.Size = new System.Drawing.Size(267, 20);
            this._MaximumAmountWithdrawableInADay.StyleController = this.layoutControl1;
            this._MaximumAmountWithdrawableInADay.TabIndex = 9;
            // 
            // _MinimumMonthlyContributions
            // 
            this._MinimumMonthlyContributions.Location = new System.Drawing.Point(229, 160);
            this._MinimumMonthlyContributions.MenuManager = this.ribbon;
            this._MinimumMonthlyContributions.Name = "_MinimumMonthlyContributions";
            this._MinimumMonthlyContributions.Properties.Mask.EditMask = "n2";
            this._MinimumMonthlyContributions.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._MinimumMonthlyContributions.Properties.Mask.UseMaskAsDisplayFormat = true;
            this._MinimumMonthlyContributions.Size = new System.Drawing.Size(267, 20);
            this._MinimumMonthlyContributions.StyleController = this.layoutControl1;
            this._MinimumMonthlyContributions.TabIndex = 8;
            // 
            // _MinimumOpeningBalance
            // 
            this._MinimumOpeningBalance.Location = new System.Drawing.Point(229, 136);
            this._MinimumOpeningBalance.MenuManager = this.ribbon;
            this._MinimumOpeningBalance.Name = "_MinimumOpeningBalance";
            this._MinimumOpeningBalance.Properties.Mask.EditMask = "n2";
            this._MinimumOpeningBalance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this._MinimumOpeningBalance.Properties.Mask.UseMaskAsDisplayFormat = true;
            this._MinimumOpeningBalance.Size = new System.Drawing.Size(267, 20);
            this._MinimumOpeningBalance.StyleController = this.layoutControl1;
            this._MinimumOpeningBalance.TabIndex = 7;
            // 
            // _Name
            // 
            this._Name.Location = new System.Drawing.Point(229, 66);
            this._Name.MenuManager = this.ribbon;
            this._Name.Name = "_Name";
            this._Name.Size = new System.Drawing.Size(267, 20);
            this._Name.StyleController = this.layoutControl1;
            this._Name.TabIndex = 5;
            // 
            // _Code
            // 
            this._Code.Location = new System.Drawing.Point(229, 42);
            this._Code.MenuManager = this.ribbon;
            this._Code.Name = "_Code";
            this._Code.Properties.ReadOnly = true;
            this._Code.Size = new System.Drawing.Size(267, 20);
            this._Code.StyleController = this.layoutControl1;
            this._Code.TabIndex = 4;
            this._Code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._Code_KeyPress);
            // 
            // _Description
            // 
            this._Description.Location = new System.Drawing.Point(229, 90);
            this._Description.MenuManager = this.ribbon;
            this._Description.Name = "_Description";
            this._Description.Size = new System.Drawing.Size(267, 42);
            this._Description.StyleController = this.layoutControl1;
            this._Description.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(520, 302);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 232);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(500, 50);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(500, 232);
            this.layoutControlGroup1.Text = "Savings Account";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this._WithdrawalCharge;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 166);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(476, 24);
            this.layoutControlItem7.Text = "Withdrawal Charge:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(202, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this._MaximumAmountWithdrawableInADay;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 142);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(476, 24);
            this.layoutControlItem6.Text = "Maximum Amount Withdrawable In A Day:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(202, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._MinimumMonthlyContributions;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 118);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(476, 24);
            this.layoutControlItem5.Text = "Minimum Monthly Contributions:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(202, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this._MinimumOpeningBalance;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 94);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(476, 24);
            this.layoutControlItem4.Text = "Minimum Opening Balance:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(202, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._Description;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(476, 46);
            this.layoutControlItem3.Text = "Description:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(202, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._Name;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(476, 24);
            this.layoutControlItem2.Text = "Name:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(202, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._Code;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(476, 24);
            this.layoutControlItem1.Text = "Code:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(202, 13);
            // 
            // SavingsAccountType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 476);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SavingsAccountType";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Savings Account Type";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._WithdrawalCharge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._MaximumAmountWithdrawableInADay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._MinimumMonthlyContributions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._MinimumOpeningBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderSavingsAccountType)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit _WithdrawalCharge;
        private DevExpress.XtraEditors.TextEdit _MaximumAmountWithdrawableInADay;
        private DevExpress.XtraEditors.TextEdit _MinimumMonthlyContributions;
        private DevExpress.XtraEditors.TextEdit _MinimumOpeningBalance;
        private DevExpress.XtraEditors.TextEdit _Name;
        private DevExpress.XtraEditors.TextEdit _Code;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderSavingsAccountType;
        private DevExpress.XtraBars.BarButtonItem btn_save;
        private DevExpress.XtraEditors.MemoEdit _Description;
    }
}