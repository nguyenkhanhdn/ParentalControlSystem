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

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                bool network = Properties.Settings.Default.Network;
                bool application = Properties.Settings.Default.Application;
                if (application)
                {
                }
                else
                {
                }

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
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            bool apps = Properties.Settings.Default.Application;
            bool keywords = Properties.Settings.Default.Keywords;
            bool time = Properties.Settings.Default.Time;

        }

        private void ribbon1_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    ReleaseCapture();
            //    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            //}
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
        private void btnTime_Click(object sender, EventArgs e)
        {

        }

        private void btnApps_Click(object sender, EventArgs e)
        {
            ucApps ucapps = new ucApps();
            ucapps.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Clear();
            this.splitContainer1.Panel2.Controls.Add(ucapps);
        }

        private void btnKeywords_Click(object sender, EventArgs e)
        {
            //Hiển thị form /control để thiết lập
            ucKeywords ucKeyword = new ucKeywords();
            ucKeyword.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(ucKeyword);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("exit");
            DialogResult yesNo = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình?", "Parental Control System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yesNo == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void chkKeywords_CheckBoxCheckChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Keywords = chkKeywords.Checked;
            Properties.Settings.Default.Save();
            this.label1.Text = Properties.Settings.Default.Keywords.ToString();
        }

        private void chkApps_CheckBoxCheckChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Application = chkApps.Checked;
            Properties.Settings.Default.Save();
            this.label1.Text = Properties.Settings.Default.Application.ToString();
        }

        private void chkTime_CheckBoxCheckChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Time = chkTime.Checked;
            Properties.Settings.Default.Save();

            this.label1.Text = Properties.Settings.Default.Time.ToString();
        }
    }
}
