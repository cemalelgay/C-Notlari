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

namespace CemalElgay_KafeSiparisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument xmlDoc;
        DateTime tarih;
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Combobox Yemek - İçeçek
            Masa _ad = new Masa();
            
            ComboBoxYemek.Items.Add("Kuru Fasulye");
            ComboBoxYemek.Items.Add("Tavuklu Pilav");
            ComboBoxYemek.Items.Add("Simit Tost");
            ComboBoxYemek.Items.Add("Lazanya");

            ComboBoxIcecek.Items.Add("Su");
            ComboBoxIcecek.Items.Add("Kola");
            ComboBoxIcecek.Items.Add("Limonata");
            ComboBoxIcecek.Items.Add("Çay");
            ComboBoxIcecek.Items.Add("Kahve");

            #endregion

            #region Masa Button   
            int sayac = 1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button btn = new Button();
                    btn.Width = 40;
                    btn.Height = 40;
                    btn.Left = btn.Width * j + 1;
                    btn.Top = btn.Width * i + 20;
                    btn.Text = sayac.ToString();
                    groupBox1.Controls.Add(btn);

                    sayac++;
                }
            }
            #endregion

            #region Kurlar

            //string USD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;

            xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
            tarih = Convert.ToDateTime(xmlDoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);



            #endregion
        }

        private void BtnSiparis_Click(object sender, EventArgs e)
        {

        }

        private void RadioBtnEuro_CheckedChanged(object sender, EventArgs e)
        {
            string EUR = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            label3.Text = "Euro: " + EUR + "₺";
        }

        private void BtnOdeme_Click(object sender, EventArgs e)
        {
            label3.Text = RadioBtnEuro.Text;
            label4.Text = RadioBtnDolar.Text;
            label5.Text = RadioBtnPound.Text;
        }

        private void RadioBtnDolar_CheckedChanged(object sender, EventArgs e)
        {
            string USD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            label4.Text = "Dolar: " + USD + "₺";
        }

        private void RadioBtnPound_CheckedChanged(object sender, EventArgs e)
        {
            string GBP = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
            label5.Text = "Pound: " + GBP + "₺";
        }
    }
}
