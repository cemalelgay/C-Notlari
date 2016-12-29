using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Izsu
{
    public partial class Form1 : Form
    { // Form 3 yapıcaz bilgiler + toplam borç + ödeme butonu + güncel borç //Form2 bilgiler son fatura + toplam ödenen
        public Form1()
        {
            InitializeComponent();
        }
              
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Abone _abone = new Abone();
            _abone.AboneNo = TxtAboneNo.Text;
            _abone.AdSoyad = TxtAboneAdi.Text;
            _abone.OncekiSayac = int.Parse(TxtOncekiSayac.Text);
            _abone.SonSayac = int.Parse(TxtSonSayac.Text);
           
            string aboneTuru = Rdnbtnev.Checked == true ? "Ev" : "Şirket";
            aboneTuru = Rdnbtbnsirket.Checked == true ? "Şirket" : "Ev";
            _abone.AboneTuru = aboneTuru;

            Rdnbtnev.Checked = false;
            Rdnbtbnsirket.Checked = false;

            ListBoxOdenecekler.Items.Add(_abone);

            
        }

        private void LstOdemeListesi_DoubleClick(object sender, EventArgs e)
        {
            Abone _abone = (Abone)ListBoxOdenecekler.SelectedItem;
            double odeme = _abone.OdemeHesapla(_abone.OncekiSayac, _abone.SonSayac, _abone.AboneTuru);

            DialogResult result = MessageBox.Show("Ödeme Tutarı : " + odeme + "\nÖdeme Yapmak İstiyor Musun?", "Ödeme Ekranı", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ListBoxOdenenler.Items.Add(_abone);
                ListBoxOdenecekler.Items.Add(_abone);
            }
        }

        private void ListBoxOdenenler_DoubleClick(object sender, EventArgs e)
        {
            Abone _abone = (Abone)ListBoxOdenenler.SelectedItem;
            Form2 frm = new Form2(_abone);
            frm.Show();
        }
    }
}
