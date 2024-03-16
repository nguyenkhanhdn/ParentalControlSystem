using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ParentalControlSystem
{
    public partial class ucApps : UserControl
    {
        string xmlFile= "..\\..\\apps.xml";
        public ucApps()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMain main = new frmMain();
            main.Show();
        }

        private void ucKeywords_Load(object sender, EventArgs e)
        {
            LoadXML();
        }
        private void LoadXML()
        {
            this.listBox1.Items.Clear();

            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFile);
            XmlNode root = doc.DocumentElement;
            foreach (XmlNode n in root.ChildNodes)
            {
                this.listBox1.Items.Add(n.InnerText);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Bạn cần chọn ứng dụng cần xóa", "Parental Control System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFile);
            XmlNode root = doc.DocumentElement;
            foreach (XmlNode n in root.ChildNodes)
            {
                if (n.InnerText.Trim() == listBox1.SelectedItem.ToString())
                {
                    root.RemoveChild(n);
                    break;
                }
            }
            doc.Save(xmlFile);
            LoadXML();
            //MessageBox.Show("Removed");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFile);
            XmlNode root = doc.DocumentElement;

            XmlElement el = doc.CreateElement("", "App", "");
            el.InnerText = this.textBox1.Text;
            
            root.InsertAfter(el, root.LastChild);
            doc.Save(xmlFile);

            LoadXML();
            this.textBox1.Text = "";
            this.textBox1.Focus();
        }
    }
}
