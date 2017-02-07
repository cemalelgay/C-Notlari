using Kentkart_OOP.DBCon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kentkart_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Kart yolcu)
        {
            InitializeComponent();
            foreach (var item in kaliciListe)
            {
                ListBoxYolcular.Items.Add(item);
            }
            ListBoxYolcular.Items.Add(yolcu);
            kaliciListe.Add(yolcu);
            tam.bakiye = yolcu.bakiye;
        }

        static List<Kart> kaliciListe = new List<Kart>();

        ÖgrenciKart ogrenci = new ÖgrenciKart();
        ÖgretmenKart ogretmen = new ÖgretmenKart();
        Kart tam = new Kart();
        int kartid = 1;
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (RadioBtnOgrenci.Checked == true)
            {
                ogrenci.bakiye = Convert.ToDouble(TxtBakiye.Text);
                ogrenci.kartID = kartid;
                kartid++;
                ogrenci.okulAdi = TxtOkuladi.Text;
                ogrenci.kartTuru = YolcuTipi.Ogrenci;
                ListBoxYolcular.Items.Add(ogrenci);
                kaliciListe.Add(ogrenci);
            }
            else if (RadioBtnOgretmen.Checked == true)
            {
                ogretmen.bakiye = Convert.ToDouble(TxtBakiye.Text);
                ogretmen.kartID = kartid;
                kartid++;
                ogretmen.kartTuru = YolcuTipi.Ogretmen;
                ListBoxYolcular.Items.Add(ogretmen);
                kaliciListe.Add(ogretmen);
            }
            else
            {
                tam.bakiye = Convert.ToDouble(TxtBakiye.Text);
                tam.kartID = kartid;
                kartid++;
                tam.kartTuru = YolcuTipi.Tam;
                ListBoxYolcular.Items.Add(tam);
                kaliciListe.Add(tam);
            }

            Temizle();
        }

        private void RadioBtnOgrenci_CheckedChanged(object sender, EventArgs e)
        {
            GBoxOkulAdi.Enabled = RadioBtnOgrenci.Checked == true ? true : false; //radioOgrenci checked
        }

        private void ListBoxYolcular_DoubleClick(object sender, EventArgs e)
        {
            Kart yolcu = (Kart)ListBoxYolcular.SelectedItem;

            if (yolcu.kartTuru == YolcuTipi.Ogrenci && (yolcu.bakiye - 1 >= 0)) //yolcu.kartTuru == YolcuTipi.Ogrenci && yolcu.bakiye >=1)
            {
                ListBoxYolcular.Items.RemoveAt(ListBoxYolcular.SelectedIndex);
                ogrenci = (ÖgrenciKart)yolcu;
                ogrenci.Okut();
                ListBoxYolcular.Items.Add(ogrenci);
            }
            else if (yolcu.kartTuru == YolcuTipi.Ogretmen && (yolcu.bakiye - 2 >= 0)) //yolcu.kartTuru == YolcuTipi.Ogretmen && yolcu.bakiye >=2)
            {
                ListBoxYolcular.Items.Remove(ListBoxYolcular.SelectedIndex);
                ogretmen = (ÖgretmenKart)yolcu;
                ogretmen.Okut();
                ListBoxYolcular.Items.Add(ogretmen);
            }
            else if (yolcu.kartTuru == YolcuTipi.Tam && (yolcu.bakiye - 3 >= 0)) //yolcu.kartTuru == YolcuTipi.Tam && yolcu.bakiye >=3)
            {
                ListBoxYolcular.Items.RemoveAt(ListBoxYolcular.SelectedIndex);
                tam = (Kart)yolcu;
                tam.Okut();
                ListBoxYolcular.Items.Add(tam);
            }
            else
            {
                MessageBox.Show("Bakiye Yetersiz!");
                DialogResult result = MessageBox.Show("Bakiye Yüklemek İster Misin? ", "Bildirim Ekranı", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Form2 frm2 = new Form2(yolcu);
                    frm2.Show();
                    this.Hide();
                }
            }
        }
        private void Temizle()
        {
            TxtBakiye.Clear();
            TxtOkuladi.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (KentKartDB context = new KentKartDB())
            {
                var result = context.Kart.ToList();
                if (result.Count==0)
                {
                    context.Kart.Add(new Kart { kartTuru = YolcuTipi.Ogrenci  });
                    context.Kart.Add(new Kart { kartTuru = YolcuTipi.Ogretmen });
                    context.Kart.Add(new Kart { kartTuru = YolcuTipi.Tam });
                }
            }           
        }
    }
}
