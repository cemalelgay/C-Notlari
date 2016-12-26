using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araba_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Araba.yakitFiyat = 5;
            NumericYakitFiyati.Enabled = false;
            NumericYakitFiyati.Value = Convert.ToDecimal(Araba.yakitFiyat);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cap = Convert.ToInt32(NumericYakitKapasite.Value);
            double ortTuk = Convert.ToDouble(NumericOrtalamaTuketim100km.Value);
            Araba a = new Araba(cap, ortTuk);

            //a.yakitDepoKapasite = Convert.ToInt32(NumericYakitKapasite.Value);
            //a.ortalamaTuketim100km = Convert.ToDouble(NumericOrtalamaTuketim100km.Value);

            //static yaptık...!!!
            //a.yakitFiyat = Convert.ToDouble(NumericYakitFiyati.Value);


            MessageBox.Show("Kapasite \t\t:" + a.yakitDepoKapasite + "\nOrt. Tuketim\t:" + a.ortalamaTuketim100km +  "\nMax.Mesafe\t: " + a.toplamYol);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cap = Convert.ToInt32(NumericYakitKapasite.Value);
            double ortTuk = Convert.ToDouble(NumericOrtalamaTuketim100km.Value);
            Araba a = new Araba(cap, ortTuk);

            //static yaptık...!!!
            // a.yakitFiyat = Convert.ToDouble(NumericYakitFiyati.Value);

            double km = Convert.ToDouble(NumericMesafe.Value);
            LabelUcret.Text = km + " km " + a.ucretHesaplama(km) + " ₺ dir.";
            LabelUcret.Text = NumericMesafe.Value + " km " + a.ucretHesaplama(km).ToString() + "₺ dir.";
        }
    }
}
