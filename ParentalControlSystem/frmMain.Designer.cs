
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
            this.pnlHours = new System.Windows.Forms.RibbonPanel();
            this.btnHours = new System.Windows.Forms.RibbonButton();
            this.btnEnableHours = new System.Windows.Forms.RibbonButton();
            this.btnDisableHours = new System.Windows.Forms.RibbonButton();
            this.pnlSystem = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton8 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel10 = new System.Windows.Forms.RibbonPanel();
            this.btnHelp2 = new System.Windows.Forms.RibbonButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab3 = new System.Windows.Forms.RibbonTab();
            this.pnlNetworks = new System.Windows.Forms.RibbonPanel();
            this.btnHome = new System.Windows.Forms.RibbonButton();
            this.btnOn = new System.Windows.Forms.RibbonButton();
            this.btnOff = new System.Windows.Forms.RibbonButton();
            this.pnlSoftwares = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton9 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton7 = new System.Windows.Forms.RibbonButton();
            this.pnlKeywords = new System.Windows.Forms.RibbonPanel();
            this.btnKeywords = new System.Windows.Forms.RibbonButton();
            this.btnAllowKWds = new System.Windows.Forms.RibbonButton();
            this.btnBlockKWds = new System.Windows.Forms.RibbonButton();
            this.ribbonTab4 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel9 = new System.Windows.Forms.RibbonPanel();
            this.btnAbout2 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // 
            // chkForbidInternet
            // 
            this.chkForbidInternet.Name = "chkForbidInternet";
            // 
            // chkBorbidApps
            // 
            this.chkBorbidApps.Name = "chkBorbidApps";
            this.chkBorbidApps.Text = "Tắt ứng dụng";
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
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlHours
            // 
            this.pnlHours.Items.Add(this.btnHours);
            this.pnlHours.Items.Add(this.btnEnableHours);
            this.pnlHours.Items.Add(this.btnDisableHours);
            this.pnlHours.Name = "pnlHours";
            this.pnlHours.Text = "Hẹn giờ";
            // 
            // btnHours
            // 
            this.btnHours.Image = global::ParentalControlSystem.Properties.Resources.time;
            this.btnHours.LargeImage = global::ParentalControlSystem.Properties.Resources.time;
            this.btnHours.Name = "btnHours";
            this.btnHours.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnHours.SmallImage")));
            this.btnHours.Text = "Thời gian";
            // 
            // btnEnableHours
            // 
            this.btnEnableHours.Image = global::ParentalControlSystem.Properties.Resources.On;
            this.btnEnableHours.LargeImage = global::ParentalControlSystem.Properties.Resources.On;
            this.btnEnableHours.Name = "btnEnableHours";
            this.btnEnableHours.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnEnableHours.SmallImage")));
            this.btnEnableHours.Text = "Bật hẹn giờ";
            this.btnEnableHours.Click += new System.EventHandler(this.Settings_Click);
            // 
            // btnDisableHours
            // 
            this.btnDisableHours.Image = global::ParentalControlSystem.Properties.Resources.off;
            this.btnDisableHours.LargeImage = global::ParentalControlSystem.Properties.Resources.off;
            this.btnDisableHours.Name = "btnDisableHours";
            this.btnDisableHours.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnDisableHours.SmallImage")));
            this.btnDisableHours.Text = "Tắt hẹn giờ";
            this.btnDisableHours.Click += new System.EventHandler(this.ribbonButton6_Click);
            // 
            // pnlSystem
            // 
            this.pnlSystem.Items.Add(this.ribbonButton8);
            this.pnlSystem.Name = "pnlSystem";
            this.pnlSystem.Text = "System";
            // 
            // ribbonButton8
            // 
            this.ribbonButton8.Image = global::ParentalControlSystem.Properties.Resources.exit_icon_48;
            this.ribbonButton8.LargeImage = global::ParentalControlSystem.Properties.Resources.exit_icon_48;
            this.ribbonButton8.Name = "ribbonButton8";
            this.ribbonButton8.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.SmallImage")));
            this.ribbonButton8.Text = "Exit";
            this.ribbonButton8.Click += new System.EventHandler(this.ribbonButton8_Click);
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 167);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.splitContainer1.Size = new System.Drawing.Size(1002, 545);
            this.splitContainer1.SplitterDistance = 321;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ParentalControlSystem.Properties.Resources.parentalcontrolsys;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 545);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.ribbonTab3.Panels.Add(this.pnlNetworks);
            this.ribbonTab3.Panels.Add(this.pnlSoftwares);
            this.ribbonTab3.Panels.Add(this.pnlKeywords);
            this.ribbonTab3.Panels.Add(this.pnlHours);
            this.ribbonTab3.Panels.Add(this.pnlSystem);
            this.ribbonTab3.Text = "Trang chủ";
            // 
            // pnlNetworks
            // 
            this.pnlNetworks.Items.Add(this.btnHome);
            this.pnlNetworks.Items.Add(this.btnOn);
            this.pnlNetworks.Items.Add(this.btnOff);
            this.pnlNetworks.Name = "pnlNetworks";
            this.pnlNetworks.Text = "Kết nối mạng";
            // 
            // btnHome
            // 
            this.btnHome.Image = global::ParentalControlSystem.Properties.Resources.home;
            this.btnHome.LargeImage = global::ParentalControlSystem.Properties.Resources.home;
            this.btnHome.Name = "btnHome";
            this.btnHome.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnHome.SmallImage")));
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // btnOn
            // 
            this.btnOn.Image = global::ParentalControlSystem.Properties.Resources._299110_check_sign_icon;
            this.btnOn.LargeImage = global::ParentalControlSystem.Properties.Resources._299110_check_sign_icon;
            this.btnOn.Name = "btnOn";
            this.btnOn.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnOn.SmallImage")));
            this.btnOn.Text = "Internet On";
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.Image = global::ParentalControlSystem.Properties.Resources._299051_ban_sign_icon;
            this.btnOff.LargeImage = global::ParentalControlSystem.Properties.Resources._299051_ban_sign_icon;
            this.btnOff.Name = "btnOff";
            this.btnOff.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnOff.SmallImage")));
            this.btnOff.Text = "Internet Off";
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // pnlSoftwares
            // 
            this.pnlSoftwares.Items.Add(this.ribbonButton9);
            this.pnlSoftwares.Items.Add(this.ribbonButton7);
            this.pnlSoftwares.Name = "pnlSoftwares";
            this.pnlSoftwares.Text = "Phền mềm";
            // 
            // ribbonButton9
            // 
            this.ribbonButton9.Image = global::ParentalControlSystem.Properties.Resources._299110_check_sign_icon;
            this.ribbonButton9.LargeImage = global::ParentalControlSystem.Properties.Resources._299110_check_sign_icon;
            this.ribbonButton9.Name = "ribbonButton9";
            this.ribbonButton9.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton9.SmallImage")));
            this.ribbonButton9.Text = "Cho phép";
            // 
            // ribbonButton7
            // 
            this.ribbonButton7.Image = global::ParentalControlSystem.Properties.Resources._299051_ban_sign_icon;
            this.ribbonButton7.LargeImage = global::ParentalControlSystem.Properties.Resources._299051_ban_sign_icon;
            this.ribbonButton7.Name = "ribbonButton7";
            this.ribbonButton7.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.SmallImage")));
            this.ribbonButton7.Text = "Cấm";
            // 
            // pnlKeywords
            // 
            this.pnlKeywords.Items.Add(this.btnKeywords);
            this.pnlKeywords.Items.Add(this.btnAllowKWds);
            this.pnlKeywords.Items.Add(this.btnBlockKWds);
            this.pnlKeywords.Name = "pnlKeywords";
            this.pnlKeywords.Text = "Từ khóa";
            // 
            // btnKeywords
            // 
            this.btnKeywords.Image = global::ParentalControlSystem.Properties.Resources._299084_book_address_icon;
            this.btnKeywords.LargeImage = global::ParentalControlSystem.Properties.Resources._299084_book_address_icon;
            this.btnKeywords.Name = "btnKeywords";
            this.btnKeywords.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnKeywords.SmallImage")));
            this.btnKeywords.Text = "Danh sách";
            // 
            // btnAllowKWds
            // 
            this.btnAllowKWds.Image = global::ParentalControlSystem.Properties.Resources._299110_check_sign_icon;
            this.btnAllowKWds.LargeImage = global::ParentalControlSystem.Properties.Resources._299110_check_sign_icon;
            this.btnAllowKWds.Name = "btnAllowKWds";
            this.btnAllowKWds.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAllowKWds.SmallImage")));
            this.btnAllowKWds.Text = "Cho phép";
            // 
            // btnBlockKWds
            // 
            this.btnBlockKWds.Image = global::ParentalControlSystem.Properties.Resources._299051_ban_sign_icon;
            this.btnBlockKWds.LargeImage = global::ParentalControlSystem.Properties.Resources._299051_ban_sign_icon;
            this.btnBlockKWds.Name = "btnBlockKWds";
            this.btnBlockKWds.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnBlockKWds.SmallImage")));
            this.btnBlockKWds.Text = "Cấm";
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.Name = "ribbonTab4";
            this.ribbonTab4.Panels.Add(this.ribbonPanel9);
            this.ribbonTab4.Panels.Add(this.ribbonPanel10);
            this.ribbonTab4.Text = "Giới thiệu";
            // 
            // ribbonPanel9
            // 
            this.ribbonPanel9.Items.Add(this.btnAbout2);
            this.ribbonPanel9.Name = "ribbonPanel9";
            this.ribbonPanel9.Text = "Thông tin";
            // 
            // btnAbout2
            // 
            this.btnAbout2.Image = global::ParentalControlSystem.Properties.Resources._299086_info_sign_icon;
            this.btnAbout2.LargeImage = global::ParentalControlSystem.Properties.Resources._299086_info_sign_icon;
            this.btnAbout2.Name = "btnAbout2";
            this.btnAbout2.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAbout2.SmallImage")));
            this.btnAbout2.Text = "About";
            this.btnAbout2.Click += new System.EventHandler(this.btnAbout2_Click);
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.RibbonPanel pnlNetworks;
        private System.Windows.Forms.RibbonPanel pnlHours;
        private System.Windows.Forms.RibbonTab ribbonTab4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RibbonButton btnHome;
        private System.Windows.Forms.RibbonButton btnOn;
        private System.Windows.Forms.RibbonButton btnOff;
        private System.Windows.Forms.RibbonButton btnEnableHours;
        private System.Windows.Forms.RibbonPanel ribbonPanel7;
        private System.Windows.Forms.RibbonPanel pnlSystem;
        private System.Windows.Forms.RibbonPanel ribbonPanel9;
        private System.Windows.Forms.RibbonPanel ribbonPanel10;
        private System.Windows.Forms.RibbonButton btnHelp2;
        private System.Windows.Forms.RibbonButton btnAbout2;
        private System.Windows.Forms.RibbonButton ribbonButton8;
        private System.Windows.Forms.RibbonButton btnHours;
        private System.Windows.Forms.RibbonButton btnDisableHours;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RibbonPanel pnlSoftwares;
        private System.Windows.Forms.RibbonButton ribbonButton7;
        private System.Windows.Forms.RibbonButton ribbonButton9;
        private System.Windows.Forms.RibbonPanel pnlKeywords;
        private System.Windows.Forms.RibbonButton btnKeywords;
        private System.Windows.Forms.RibbonButton btnAllowKWds;
        private System.Windows.Forms.RibbonButton btnBlockKWds;
    }
}

