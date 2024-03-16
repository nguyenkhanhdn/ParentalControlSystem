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
    public partial class frmResetTime : Form
    {
        public frmResetTime()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ("pass@word" == this.textBox1.Text.Trim())
            {
                Properties.Settings.Default.mm = Convert.ToInt32(comboBox2.Text);
                Properties.Settings.Default.Save();
                MessageBox.Show("Thiết lập đã được lưu.", "Parental Control System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                frmMain main = new frmMain();
                main.Show();
            }
            else
            {
                MessageBox.Show("Không đúng mật khẩu, bạn không có quyền thiết lập.", "Parental Control System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
