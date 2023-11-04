using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ParentalControlSystem
{
    public partial class frmMain : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thông báo: nút home được nhấn", "Parental Control System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                bool network = Properties.Settings.Default.Network;
                if (network)
                {
                    ParentalController.AddFirewallRules();
                    this.btnOff.Enabled = false;
                    this.btnOn.Enabled = true;
                }
                else
                {
                    ParentalController.RemoveFirewallRules();
                    this.btnOff.Enabled = true;
                    this.btnOn.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi xảy ra: " + ex.Message,"Parental Control System",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            //Hiển thị form /control để thiết lập
            ucThietlap ucsetting = new ucThietlap();
            ucsetting.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(ucsetting);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //bool internetPolicy = Properties.Settings.Default.Internet;
            bool appPolicy = Properties.Settings.Default.Application;
            //bool computerPolicy = Properties.Settings.Default.Computer;

            //this.label1.Text = internetPolicy.ToString();
            //this.label2.Text = appPolicy.ToString();
            //ParentalController.BlockInternet(internetPolicy);

            if (appPolicy)
            {
                ParentalController.BlockApps("msedge");
            }


        }

        private void ribbon1_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    ReleaseCapture();
            //    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            //}
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        private void ribbonButton8_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("exit");
            DialogResult yesNo = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình?", "Parental Control System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( yesNo == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Home");
        }

        private void ribbonButton5_Click(object sender, EventArgs e)
        {
            ucKeywords ucKeywords = new ucKeywords();
            ucKeywords.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Clear();
            this.splitContainer1.Panel2.Controls.Add(ucKeywords);
        }

        private void ribbonButton6_Click(object sender, EventArgs e)
        {
            ucApps ucapps = new ucApps();
            ucapps.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Clear();
            this.splitContainer1.Panel2.Controls.Add(ucapps);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            //Hiển thị form /control để thiết lập
            ucSettings ucsetting = new ucSettings();
            ucsetting.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(ucsetting);
        }

        private void btnAbout2_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            ParentalController.AddFirewallRules();
            Properties.Settings.Default.Network = true;
            Properties.Settings.Default.Save();
            this.btnOff.Enabled = false;
            this.btnOn.Enabled = true;
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            ParentalController.RemoveFirewallRules();
            Properties.Settings.Default.Network = false;
            Properties.Settings.Default.Save();
            //Add policies
            this.btnOff.Enabled = true;
            this.btnOn.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParentalController.AddFirewallRules();
            MessageBox.Show("Added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParentalController.RemoveFirewallRules();
            MessageBox.Show("Removed");
        }
    }
}
