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
            Properties.Settings.Default.mm = Convert.ToInt32(comboBox2.Text);
            Properties.Settings.Default.Save();
            MessageBox.Show("Thiết lập đã được lưu.", "Parental Control System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Dispose();
            frmMain main = new frmMain();
            main.Show();
        }

        private void ucSettings_Load(object sender, EventArgs e)
        {            
            try
            {
                this.comboBox2.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Parental Control System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
