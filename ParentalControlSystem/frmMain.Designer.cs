
namespace ParentalControlSystem
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.btnSettings = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.chkUseComputer = new System.Windows.Forms.RibbonCheckBox();
            this.chkForbidInternet = new System.Windows.Forms.RibbonCheckBox();
            this.chkBorbidApps = new System.Windows.Forms.RibbonCheckBox();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribInformation = new System.Windows.Forms.RibbonPanel();
            this.btnAbout = new System.Windows.Forms.RibbonButton();
            this.btnApplication = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.btnHelp = new System.Windows.Forms.RibbonButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab3 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.btnHome = new System.Windows.Forms.RibbonButton();
            this.btnOn = new System.Windows.Forms.RibbonButton();
            this.btnOff = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel6 = new System.Windows.Forms.RibbonPanel();
            this.Settings = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel7 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel8 = new System.Windows.Forms.RibbonPanel();
            this.btnExit = new System.Windows.Forms.RibbonButton();
            this.ribbonTab4 = new System.Windows.Forms.RibbonTab();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkBlockInternet = new System.Windows.Forms.RibbonCheckBox();
            this.chkBlockApps = new System.Windows.Forms.RibbonCheckBox();
            this.chkLimittedCompUse = new System.Windows.Forms.RibbonCheckBox();
            this.ribbonPanel9 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel10 = new System.Windows.Forms.RibbonPanel();
            this.btnHelp2 = new System.Windows.Forms.RibbonButton();
            this.btnAbout2 = new System.Windows.Forms.RibbonButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Panels.Add(this.ribbonPanel3);
            this.ribbonTab1.Text = "Trang chủ";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.btnSettings);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "Settings";
            // 
            // btnSettings
            // 
            this.btnSettings.Image = global::ParentalControlSystem.Properties.Resources._379393_settings_icon;
            this.btnSettings.LargeImage = global::ParentalControlSystem.Properties.Resources._379393_settings_icon;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.SmallImage = global::ParentalControlSystem.Properties.Resources._8168605_settings_system_tools_preferences_icon;
            this.btnSettings.Text = "Thiết lập";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.chkUseComputer);
            this.ribbonPanel3.Items.Add(this.chkForbidInternet);
            this.ribbonPanel3.Items.Add(this.chkBorbidApps);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Text = "Quick settings";
            // 
            // chkUseComputer
            // 
            this.chkUseComputer.Name = "chkUseComputer";
            this.chkUseComputer.Text = "Sử dụng máy tính theo giờ";
            this.chkUseComputer.CheckBoxCheckChanged += new System.EventHandler(this.chkUseComputer_CheckBoxCheckChanged);
            // 
            // chkForbidInternet
            // 
            this.chkForbidInternet.Name = "chkForbidInternet";
            this.chkForbidInternet.Text = "Cấm truy cập internet";
            this.chkForbidInternet.CheckBoxCheckChanged += new System.EventHandler(this.chkForbidInternet_CheckBoxCheckChanged);
            // 
            // chkBorbidApps
            // 
            this.chkBorbidApps.Name = "chkBorbidApps";
            this.chkBorbidApps.Text = "Tắt ứng dụng";
            this.chkBorbidApps.CheckBoxCheckChanged += new System.EventHandler(this.chkBorbidApps_CheckBoxCheckChanged);
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Panels.Add(this.ribInformation);
            this.ribbonTab2.Panels.Add(this.ribbonPanel4);
            this.ribbonTab2.Text = "Giới thiệu";
            // 
            // ribInformation
            // 
            this.ribInformation.Items.Add(this.btnAbout);
            this.ribInformation.Items.Add(this.btnApplication);
            this.ribInformation.Name = "ribInformation";
            this.ribInformation.Text = "Information";
            // 
            // btnAbout
            // 
            this.btnAbout.Image = global::ParentalControlSystem.Properties.Resources._2305639_company_crowd_group_people_team_icon;
            this.btnAbout.LargeImage = global::ParentalControlSystem.Properties.Resources._2305639_company_crowd_group_people_team_icon;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.SmallImage")));
            this.btnAbout.Text = "Nhóm phát triển";
            // 
            // btnApplication
            // 
            this.btnApplication.Image = global::ParentalControlSystem.Properties.Resources._299086_info_sign_icon;
            this.btnApplication.LargeImage = global::ParentalControlSystem.Properties.Resources._299086_info_sign_icon;
            this.btnApplication.Name = "btnApplication";
            this.btnApplication.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnApplication.SmallImage")));
            this.btnApplication.Text = "Phần mềm";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.btnHelp);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Text = "Trợ giúp";
            // 
            // btnHelp
            // 
            this.btnHelp.Image = global::ParentalControlSystem.Properties.Resources.help;
            this.btnHelp.LargeImage = global::ParentalControlSystem.Properties.Resources.help;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.SmallImage")));
            this.btnHelp.Text = "Trợ giúp";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = global::ParentalControlSystem.Properties.Resources._299110_check_sign_icon;
            this.ribbonButton2.LargeImage = global::ParentalControlSystem.Properties.Resources._299110_check_sign_icon;
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "On";
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = global::ParentalControlSystem.Properties.Resources._299051_ban_sign_icon;
            this.ribbonButton3.LargeImage = global::ParentalControlSystem.Properties.Resources._299051_ban_sign_icon;
            this.ribbonButton3.Name = "ribbonButton3";
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Text = "Off";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "Exit";
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = global::ParentalControlSystem.Properties.Resources.shield;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbon1.Size = new System.Drawing.Size(1002, 167);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab3);
            this.ribbon1.Tabs.Add(this.ribbonTab4);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ribbon1_MouseDown);
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Panels.Add(this.ribbonPanel5);
            this.ribbonTab3.Panels.Add(this.ribbonPanel6);
            this.ribbonTab3.Panels.Add(this.ribbonPanel7);
            this.ribbonTab3.Panels.Add(this.ribbonPanel8);
            this.ribbonTab3.Text = "Trang chủ";
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.btnHome);
            this.ribbonPanel5.Items.Add(this.btnOn);
            this.ribbonPanel5.Items.Add(this.btnOff);
            this.ribbonPanel5.Name = "ribbonPanel5";
            this.ribbonPanel5.Text = "Home";
            // 
            // btnHome
            // 
            this.btnHome.Image = global::ParentalControlSystem.Properties.Resources.home;
            this.btnHome.LargeImage = global::ParentalControlSystem.Properties.Resources.home;
            this.btnHome.Name = "btnHome";
            this.btnHome.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnHome.SmallImage")));
            this.btnHome.Text = "Home";
            // 
            // btnOn
            // 
            this.btnOn.Image = global::ParentalControlSystem.Properties.Resources._299110_check_sign_icon;
            this.btnOn.LargeImage = global::ParentalControlSystem.Properties.Resources._299110_check_sign_icon;
            this.btnOn.Name = "btnOn";
            this.btnOn.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnOn.SmallImage")));
            this.btnOn.Text = "On";
            // 
            // btnOff
            // 
            this.btnOff.Image = global::ParentalControlSystem.Properties.Resources._299051_ban_sign_icon;
            this.btnOff.LargeImage = global::ParentalControlSystem.Properties.Resources._299051_ban_sign_icon;
            this.btnOff.Name = "btnOff";
            this.btnOff.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnOff.SmallImage")));
            this.btnOff.Text = "Off";
            // 
            // ribbonPanel6
            // 
            this.ribbonPanel6.Items.Add(this.Settings);
            this.ribbonPanel6.Name = "ribbonPanel6";
            this.ribbonPanel6.Text = "Settings";
            // 
            // Settings
            // 
            this.Settings.Image = global::ParentalControlSystem.Properties.Resources._379393_settings_icon;
            this.Settings.LargeImage = global::ParentalControlSystem.Properties.Resources._379393_settings_icon;
            this.Settings.Name = "Settings";
            this.Settings.SmallImage = ((System.Drawing.Image)(resources.GetObject("Settings.SmallImage")));
            this.Settings.Text = "Thiết lập";
            // 
            // ribbonPanel7
            // 
            this.ribbonPanel7.Items.Add(this.chkBlockInternet);
            this.ribbonPanel7.Items.Add(this.chkBlockApps);
            this.ribbonPanel7.Items.Add(this.chkLimittedCompUse);
            this.ribbonPanel7.Name = "ribbonPanel7";
            this.ribbonPanel7.Text = "Quick settings";
            // 
            // ribbonPanel8
            // 
            this.ribbonPanel8.Items.Add(this.btnExit);
            this.ribbonPanel8.Name = "ribbonPanel8";
            this.ribbonPanel8.Text = "System";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::ParentalControlSystem.Properties.Resources.exit_icon_48;
            this.btnExit.LargeImage = global::ParentalControlSystem.Properties.Resources.exit_icon_48;
            this.btnExit.Name = "btnExit";
            this.btnExit.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnExit.SmallImage")));
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.Name = "ribbonTab4";
            this.ribbonTab4.Panels.Add(this.ribbonPanel9);
            this.ribbonTab4.Panels.Add(this.ribbonPanel10);
            this.ribbonTab4.Text = "Giới thiệu";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 167);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(1002, 545);
            this.splitContainer1.SplitterDistance = 334;
            this.splitContainer1.TabIndex = 1;
            // 
            // chkBlockInternet
            // 
            this.chkBlockInternet.Name = "chkBlockInternet";
            this.chkBlockInternet.Text = "Ngắt kết nối Internet";
            // 
            // chkBlockApps
            // 
            this.chkBlockApps.Name = "chkBlockApps";
            this.chkBlockApps.Text = "Cấm sử dụng phần mềm";
            // 
            // chkLimittedCompUse
            // 
            this.chkLimittedCompUse.Name = "chkLimittedCompUse";
            this.chkLimittedCompUse.Text = "Sử dụng máy tính có giới hạn";
            // 
            // ribbonPanel9
            // 
            this.ribbonPanel9.Items.Add(this.btnAbout2);
            this.ribbonPanel9.Name = "ribbonPanel9";
            this.ribbonPanel9.Text = "Thông tin";
            // 
            // ribbonPanel10
            // 
            this.ribbonPanel10.Items.Add(this.btnHelp2);
            this.ribbonPanel10.Name = "ribbonPanel10";
            this.ribbonPanel10.Text = "Trợ giúp";
            // 
            // btnHelp2
            // 
            this.btnHelp2.Image = global::ParentalControlSystem.Properties.Resources.help;
            this.btnHelp2.LargeImage = global::ParentalControlSystem.Properties.Resources.help;
            this.btnHelp2.Name = "btnHelp2";
            this.btnHelp2.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnHelp2.SmallImage")));
            this.btnHelp2.Text = "Help";
            // 
            // btnAbout2
            // 
            this.btnAbout2.Image = global::ParentalControlSystem.Properties.Resources._299086_info_sign_icon;
            this.btnAbout2.LargeImage = global::ParentalControlSystem.Properties.Resources._299086_info_sign_icon;
            this.btnAbout2.Name = "btnAbout2";
            this.btnAbout2.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAbout2.SmallImage")));
            this.btnAbout2.Text = "About";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ribbon1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.RibbonPanel ribInformation;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton btnAbout;
        private System.Windows.Forms.RibbonButton btnApplication;
        private System.Windows.Forms.RibbonButton btnHelp;
        private System.Windows.Forms.RibbonOrbMenuItem mnuExit;
        private System.Windows.Forms.RibbonButton btnSettings;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonCheckBox chkUseComputer;
        private System.Windows.Forms.RibbonCheckBox chkForbidInternet;
        private System.Windows.Forms.RibbonCheckBox chkBorbidApps;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab3;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonPanel ribbonPanel6;
        private System.Windows.Forms.RibbonTab ribbonTab4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RibbonButton btnHome;
        private System.Windows.Forms.RibbonButton btnOn;
        private System.Windows.Forms.RibbonButton btnOff;
        private System.Windows.Forms.RibbonButton Settings;
        private System.Windows.Forms.RibbonPanel ribbonPanel7;
        private System.Windows.Forms.RibbonPanel ribbonPanel8;
        private System.Windows.Forms.RibbonButton btnExit;
        private System.Windows.Forms.RibbonCheckBox chkBlockInternet;
        private System.Windows.Forms.RibbonCheckBox chkBlockApps;
        private System.Windows.Forms.RibbonCheckBox chkLimittedCompUse;
        private System.Windows.Forms.RibbonPanel ribbonPanel9;
        private System.Windows.Forms.RibbonPanel ribbonPanel10;
        private System.Windows.Forms.RibbonButton btnHelp2;
        private System.Windows.Forms.RibbonButton btnAbout2;
    }
}

