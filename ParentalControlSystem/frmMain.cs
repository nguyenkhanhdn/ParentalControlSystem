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
using System.Diagnostics;
using System.Management;

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
                bool apps = Properties.Settings.Default.Application;
                bool keywords = Properties.Settings.Default.Keywords;
                bool time = Properties.Settings.Default.Time;
                this.chkApps.Checked = apps;
                this.chkKeywords.Checked = keywords;
                this.chkTime.Checked = time;

                if (chkTime.Checked)
                {
                    timer2.Enabled = true;
                }

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
        private void timer1_Tick(object sender, EventArgs e)
        {
            string xmlFile = "..\\..\\apps.xml";
            string xmlKeywords = "..\\..\\keywords.xml";
            if (chkApps.Checked)
            {
                List<string> applications = ParentalController.GetApplications(xmlFile);
                foreach(string app in applications)
                {
                    if (IsOpen(app))
                    { 
                        ParentalController.BlockApps(app); 
                    }                    
                }
            }
            if (chkKeywords.Checked)
            {                
                try
                {
                    List<string> keywords = ParentalController.GetApplications(xmlKeywords);
                    List<string> processes = WindowsByClassFinder.GetProcesses();

                    foreach(string kw in keywords)
                    {
                        foreach(string p in processes)
                        {
                            if (p.Contains(kw))
                            {
                                WindowsByClassFinder.CloseBrowsers();
                            }
                        }
                    }
                }
                catch (Exception ex){}
            }
            bool time = Properties.Settings.Default.Time;
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

            if (chkTime.Checked)
            {
                timer2.Enabled = true;
            }
        }
        private List<string> GetProcesses()
        {
            Process[] processCollection = Process.GetProcesses();
            List<string> processes = new List<string>();            
            foreach (Process p in processCollection)
            {
                processes.Add(p.ProcessName);
            }            
            return processes;
        }
        public IEnumerable<string> ChromeWindowTitles()
        {
            foreach (var title in WindowsByClassFinder.WindowTitlesForClass("Chrome_WidgetWin_0"))
                if (!string.IsNullOrWhiteSpace(title))
                    yield return title;

            foreach (var title in WindowsByClassFinder.WindowTitlesForClass("Chrome_WidgetWin_1"))
                if (!string.IsNullOrWhiteSpace(title))
                    yield return title;

            foreach (var title in WindowsByClassFinder.WindowTitlesForClass("MozillaWindowClass"))
                if (!string.IsNullOrWhiteSpace(title))
                    yield return title;

            foreach (var title in WindowsByClassFinder.WindowTitlesForClass("IEFrame"))
                if (!string.IsNullOrWhiteSpace(title))
                    yield return title;
        }
        private bool IsOpen(string process)
        {
            bool isExist = false;
            List<string> openApps = GetProcesses();
            foreach(string app in openApps)
            {
                if (process.Contains(app))
                {
                    isExist = true;
                    break;
                }
            }
            return isExist;
        }

        private static int ss = 0;
        private static int mm = 0;
        private static int hh = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            ss += 1;
            if (ss == 60)
            {
                mm += 1;
                ss = 0;
            }
            if (mm == 60)
            {
                hh += 1;
                mm = 0;
            }
            if (hh == 2)
            {
                timer2.Enabled = false;
                ParentalController.DoExitWin(ParentalController.EWX_SHUTDOWN);
            }
            this.lblSecond.Text = string.Format("Giây: {0,0:D2}", ss);
            this.lblMinute.Text = string.Format("Phút: {0,0:D2}", mm);
            this.lblHour.Text = string.Format("Giờ : {0,0:D2}", hh);
            this.label1.Text = string.Format("{0, 0:D2}:{1,1:D2}:{2,2:D2}", hh,mm,ss);
        }
    }
}
