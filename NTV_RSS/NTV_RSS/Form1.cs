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
namespace NTV_RSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGetir_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlDoc = new XmlTextReader("http://www.ntv.com.tr/gundem.rss");

            while (xmlDoc.Read())
            {
                if (xmlDoc.NodeType == XmlNodeType.Element && xmlDoc.Name == "title")
                {
                    listBox1.Items.Add(xmlDoc.ReadString());
                }
            }
            listBox1.Items.RemoveAt(0);
        }
    }
}
