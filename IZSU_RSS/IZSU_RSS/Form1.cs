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
namespace IZSU_RSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument xmlDoc = new XmlDocument();

        private void BtnGetir_Click(object sender, EventArgs e)
        {
            xmlDoc.Load("http://www.izsu.gov.tr/Pages/rss.aspx?rssId=3");

            XmlNodeList titleList = xmlDoc.SelectNodes("//channel/item/title");
            XmlNodeList descriptionList = xmlDoc.SelectNodes("//channel/item/description");
            XmlNodeList dateList = xmlDoc.SelectNodes("//channel/item/pubDate");
            Baraj.tarih = Convert.ToDateTime(dateList[0].InnerText);

            label1.Text = "Tarih : " + Baraj.tarih.ToString("dd/MM/yyyy");

            for (int i = 0; i < titleList.Count; i++)
            {
                Baraj b = new Baraj(titleList[i].InnerText, descriptionList[i].InnerText);

                listBox1.Items.Add(b);
            }
        }

        private void BtnSuKes_Click(object sender, EventArgs e)
        {
            xmlDoc.Load("http://www.izsu.gov.tr/Pages/rss.aspx?rssId=2");
            XmlNodeList titlesList = xmlDoc.SelectNodes("//channel/item/title");
            XmlNodeList descriptionList = xmlDoc.SelectNodes("//channel/item/description");

            for (int i = 0; i < titlesList.Count; i++)
            {
                Kesinti k = new Kesinti(titlesList[i].InnerText, descriptionList[i].InnerText);

                listBox2.Items.Add(k);
            }
        }

        private void BtnHaber_Click(object sender, EventArgs e)
        {
            xmlDoc.Load("http://www.izsu.gov.tr/Pages/rss.aspx?rssId=1");
            XmlNodeList titlesList = xmlDoc.SelectNodes("//channel/item/title");
            XmlNodeList descriptionList = xmlDoc.SelectNodes("//channel/item/description");

            for (int i = 0; i < titlesList.Count; i++)
            {
                Haber h = new Haber(titlesList[i].InnerText, descriptionList[i].InnerText);

                listBox3.Items.Add(h);
            }
        }

        private void listBox3_DoubleClick(object sender, EventArgs e)
        {
            Haber hbr = (Haber)listBox3.SelectedItem;

            webBrowser1.Url = new Uri("https://www.izsu.gov.tr" + hbr.link);
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            Kesinti ks = (Kesinti)listBox2.SelectedItem;

            webBrowser1.DocumentText = ks.bilgi;
        }
    }
}
