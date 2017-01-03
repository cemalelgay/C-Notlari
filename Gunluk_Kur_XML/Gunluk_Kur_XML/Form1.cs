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

namespace Gunluk_Kur_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlDocument xmlDoc;
        DateTime tarih;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {          
            //string USD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            //string EUR = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            //string GBP = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;

            if (comboBox1.SelectedItem.ToString() == "USD")
            {
                string USD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
                dataGridView1.Rows.Add("Dolar", tarih.ToString("dd/MM/yyyy"), USD);
            }
            else if (comboBox1.SelectedItem.ToString() == "GBP")
            {
                string EUR = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
                dataGridView1.Rows.Add("Paund", tarih.ToString("dd/MM/yyyy"), EUR);
            }
            else 
            {
                string GBP = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
                dataGridView1.Rows.Add("Euro", tarih.ToString("dd/MM/yyyy"), GBP);
            }

            // label1.Text = "Dolar Kuru: " + tarih.ToString("dd/MM/yyyy") + " - " + USD + " ₺";

            //dataGridView1.Rows.Add("Dolar", tarih.ToString("dd/MM/yyyy"), USD);
            //dataGridView1.Rows.Add("Euro", tarih.ToString("dd/MM/yyyy"), EUR);
            //dataGridView1.Rows.Add("Sterlin", tarih.ToString("dd/MM/yyyy"), GBP);

        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
            tarih = Convert.ToDateTime(xmlDoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int gun = dateTimePicker1.Value.Day;
            int ay = dateTimePicker1.Value.Month;
            int yil = dateTimePicker1.Value.Year;
            string strgun, stray;

            if (gun <= 9)
            {
                string strgun = "0" + gun;
            }
            else
            {
                strgun = gun.ToString();
            }
            if (ay <= 9)
            {
                stray = "0" + ay;
            }
            else
            {
                stray = ay.ToString();
            }
            xmlDoc.Load("http://www.tcmb.gov.tr/kurlar" + yil + stray + "/" + gun + stray + yil + ".xml");
            tarih = Convert.ToDateTime(xmlDoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value;
        }
    }
}
