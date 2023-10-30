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
            //string hh = DateTime.Now.Hour.ToString();
            //string mm = DateTime.Now.Minute.ToString();
            //string ss = DateTime.Now.Second.ToString();

            //string clock = hh + ":" + mm + ":" + ss;
            //this.Text = "Parental Control System" + " - " + clock;
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
    }
}
