namespace SaccoBook.Modules.Settings.Notifications
{
    partial class NotificationSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationSettings));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_save = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sendtestmail = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sendtestsms = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this._SMSNotificationsEnabled = new DevExpress.XtraEditors.CheckEdit();
            this._EmailNotificationsEnabled = new DevExpress.XtraEditors.CheckEdit();
            this._AfricasTalkingAPIKey = new DevExpress.XtraEditors.TextEdit();
            this._AfricasTalkingUsername = new DevExpress.XtraEditors.TextEdit();
            this._Password = new DevExpress.XtraEditors.TextEdit();
            this._UserId = new DevExpress.XtraEditors.TextEdit();
            this._SMTPServer = new DevExpress.XtraEditors.TextEdit();
            this._SMTPServerPort = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._SMSNotificationsEnabled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._EmailNotificationsEnabled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AfricasTalkingAPIKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AfricasTalkingUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._UserId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._SMTPServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._SMTPServerPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btn_save,
            this.btn_sendtestmail,
            this.btn_sendtestsms});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(707, 143);
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
            // btn_sendtestmail
            // 
            this.btn_sendtestmail.Caption = "Send Test Email";
            this.btn_sendtestmail.Id = 2;
            this.btn_sendtestmail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sendtestmail.ImageOptions.Image")));
            this.btn_sendtestmail.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_sendtestmail.ImageOptions.LargeImage")));
            this.btn_sendtestmail.Name = "btn_sendtestmail";
            this.btn_sendtestmail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_sendtestmail_ItemClick);
            // 
            // btn_sendtestsms
            // 
            this.btn_sendtestsms.Caption = "Send Test SMS";
            this.btn_sendtestsms.Id = 3;
            this.btn_sendtestsms.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sendtestsms.ImageOptions.Image")));
            this.btn_sendtestsms.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_sendtestsms.ImageOptions.LargeImage")));
            this.btn_sendtestsms.Name = "btn_sendtestsms";
            this.btn_sendtestsms.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_sendtestsms_ItemClick);
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
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_save);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Save";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_sendtestmail);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Email";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_sendtestsms);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "SMS";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 370);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(707, 31);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this._SMSNotificationsEnabled);
            this.layoutControl1.Controls.Add(this._EmailNotificationsEnabled);
            this.layoutControl1.Controls.Add(this._AfricasTalkingAPIKey);
            this.layoutControl1.Controls.Add(this._AfricasTalkingUsername);
            this.layoutControl1.Controls.Add(this._Password);
            this.layoutControl1.Controls.Add(this._UserId);
            this.layoutControl1.Controls.Add(this._SMTPServer);
            this.layoutControl1.Controls.Add(this._SMTPServerPort);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 143);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(707, 227);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // _SMSNotificationsEnabled
            // 
            this._SMSNotificationsEnabled.Location = new System.Drawing.Point(517, 90);
            this._SMSNotificationsEnabled.MenuManager = this.ribbon;
            this._SMSNotificationsEnabled.Name = "_SMSNotificationsEnabled";
            this._SMSNotificationsEnabled.Properties.Caption = "";
            this._SMSNotificationsEnabled.Size = new System.Drawing.Size(166, 19);
            this._SMSNotificationsEnabled.StyleController = this.layoutControl1;
            this._SMSNotificationsEnabled.TabIndex = 11;
            // 
            // _EmailNotificationsEnabled
            // 
            this._EmailNotificationsEnabled.Location = new System.Drawing.Point(152, 138);
            this._EmailNotificationsEnabled.MenuManager = this.ribbon;
            this._EmailNotificationsEnabled.Name = "_EmailNotificationsEnabled";
            this._EmailNotificationsEnabled.Properties.Caption = "";
            this._EmailNotificationsEnabled.Size = new System.Drawing.Size(209, 19);
            this._EmailNotificationsEnabled.StyleController = this.layoutControl1;
            this._EmailNotificationsEnabled.TabIndex = 10;
            // 
            // _AfricasTalkingAPIKey
            // 
            this._AfricasTalkingAPIKey.Location = new System.Drawing.Point(517, 66);
            this._AfricasTalkingAPIKey.MenuManager = this.ribbon;
            this._AfricasTalkingAPIKey.Name = "_AfricasTalkingAPIKey";
            this._AfricasTalkingAPIKey.Properties.UseSystemPasswordChar = true;
            this._AfricasTalkingAPIKey.Size = new System.Drawing.Size(166, 20);
            this._AfricasTalkingAPIKey.StyleController = this.layoutControl1;
            this._AfricasTalkingAPIKey.TabIndex = 9;
            // 
            // _AfricasTalkingUsername
            // 
            this._AfricasTalkingUsername.Location = new System.Drawing.Point(517, 42);
            this._AfricasTalkingUsername.MenuManager = this.ribbon;
            this._AfricasTalkingUsername.Name = "_AfricasTalkingUsername";
            this._AfricasTalkingUsername.Size = new System.Drawing.Size(166, 20);
            this._AfricasTalkingUsername.StyleController = this.layoutControl1;
            this._AfricasTalkingUsername.TabIndex = 8;
            // 
            // _Password
            // 
            this._Password.Location = new System.Drawing.Point(152, 114);
            this._Password.MenuManager = this.ribbon;
            this._Password.Name = "_Password";
            this._Password.Properties.UseSystemPasswordChar = true;
            this._Password.Size = new System.Drawing.Size(209, 20);
            this._Password.StyleController = this.layoutControl1;
            this._Password.TabIndex = 7;
            // 
            // _UserId
            // 
            this._UserId.Location = new System.Drawing.Point(152, 90);
            this._UserId.MenuManager = this.ribbon;
            this._UserId.Name = "_UserId";
            this._UserId.Size = new System.Drawing.Size(209, 20);
            this._UserId.StyleController = this.layoutControl1;
            this._UserId.TabIndex = 6;
            // 
            // _SMTPServer
            // 
            this._SMTPServer.Location = new System.Drawing.Point(152, 42);
            this._SMTPServer.MenuManager = this.ribbon;
            this._SMTPServer.Name = "_SMTPServer";
            this._SMTPServer.Size = new System.Drawing.Size(209, 20);
            this._SMTPServer.StyleController = this.layoutControl1;
            this._SMTPServer.TabIndex = 5;
            // 
            // _SMTPServerPort
            // 
            this._SMTPServerPort.Location = new System.Drawing.Point(152, 66);
            this._SMTPServerPort.MenuManager = this.ribbon;
            this._SMTPServerPort.Name = "_SMTPServerPort";
            this._SMTPServerPort.Size = new System.Drawing.Size(209, 20);
            this._SMTPServerPort.StyleController = this.layoutControl1;
            this._SMTPServerPort.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup2,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(707, 227);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(365, 161);
            this.layoutControlGroup1.Text = "SMTP Settings";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this._Password;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(341, 24);
            this.layoutControlItem4.Text = "Password:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(125, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this._UserId;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(341, 24);
            this.layoutControlItem3.Text = "User Id:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(125, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this._SMTPServerPort;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(341, 24);
            this.layoutControlItem1.Text = "SMTP Server Port:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(125, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this._SMTPServer;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(341, 24);
            this.layoutControlItem2.Text = "SMTP Server:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(125, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this._EmailNotificationsEnabled;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(341, 23);
            this.layoutControlItem7.Text = "Enable Email Notifications:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(125, 13);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.layoutControlItem8});
            this.layoutControlGroup2.Location = new System.Drawing.Point(365, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(322, 161);
            this.layoutControlGroup2.Text = "Africas Talking SMS Gateway";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this._AfricasTalkingAPIKey;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(298, 24);
            this.layoutControlItem6.Text = "API Key:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(125, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this._AfricasTalkingUsername;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(298, 24);
            this.layoutControlItem5.Text = "Username:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(125, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this._SMSNotificationsEnabled;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(298, 71);
            this.layoutControlItem8.Text = "Enable SMS Notifications:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(125, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 161);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(687, 46);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // NotificationSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 401);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NotificationSettings";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Notification Settings";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._SMSNotificationsEnabled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._EmailNotificationsEnabled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AfricasTalkingAPIKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AfricasTalkingUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._UserId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._SMTPServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._SMTPServerPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit _SMTPServerPort;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit _AfricasTalkingAPIKey;
        private DevExpress.XtraEditors.TextEdit _AfricasTalkingUsername;
        private DevExpress.XtraEditors.TextEdit _Password;
        private DevExpress.XtraEditors.TextEdit _UserId;
        private DevExpress.XtraEditors.TextEdit _SMTPServer;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.CheckEdit _SMSNotificationsEnabled;
        private DevExpress.XtraEditors.CheckEdit _EmailNotificationsEnabled;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraBars.BarButtonItem btn_sendtestmail;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_sendtestsms;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}