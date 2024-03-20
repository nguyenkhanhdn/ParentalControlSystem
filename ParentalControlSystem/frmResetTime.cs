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
        private int count = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            count++;

            if ("pass@word" == this.textBox1.Text.Trim())
            {
                Properties.Settings.Default.mm = Convert.ToInt32(comboBox2.Text);
                Properties.Settings.Default.Save();
                MessageBox.Show("Thiết lập đã được lưu.", "Parental Control System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.None;

                MessageBox.Show("Không đúng mật khẩu, bạn không có quyền thiết lập.", "Parental Control System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (count == 3)
            {
                //Sai 3 lần, tắt chương trình.
                ParentalController.DoExitWin(ParentalController.EWX_FORCE);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã hết thời gian sử dụng, máy tính tự động thoát.", "Parental Control System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ParentalController.DoExitWin(ParentalController.EWX_FORCE);
        }
    }
}
