using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParentalControlSystem
{
    public partial class ucSettings : UserControl
    {
        public ucSettings()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Internet = chkInternet.Checked;
                Properties.Settings.Default.Application = chkApplication.Checked;
                Properties.Settings.Default.Computer= chkLimitedComputerUse.Checked;
                Properties.Settings.Default.Save();
                MessageBox.Show("Thiết lập đã được lưu", "Parental Control System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,"Parental Control System",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ucSettings_Load(object sender, EventArgs e)
        {            
            try
            {
                chkInternet.Checked = Properties.Settings.Default.Internet;
                chkApplication.Checked = Properties.Settings.Default.Application;
                chkLimitedComputerUse.Checked = Properties.Settings.Default.Computer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Parental Control System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
