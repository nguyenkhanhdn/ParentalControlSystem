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
    public partial class ucKeywords : UserControl
    {
        public ucKeywords()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ucKeywords_Load(object sender, EventArgs e)
        {
            LoadXML();
        }
        private void LoadXML()
        {
            this.listBox1.Items.Clear();

            XmlDocument doc = new XmlDocument();
            doc.Load("..\\..\\apps.xml");
            XmlNode root = doc.DocumentElement;
            foreach (XmlNode n in root.ChildNodes)
            {
                this.listBox1.Items.Add(n.InnerText);
            }
        }
    }
}
