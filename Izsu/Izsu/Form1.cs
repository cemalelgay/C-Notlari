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
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Abone> AboneListesi = new List<Abone>();
        double tutar;
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Abone abone = new Abone();
            abone.AdSoyad = TxtAboneAdi.Text;
            abone.oncekindex = int.Parse(TxtOncekindex.Text);
            abone.sonrakindex = int.Parse(TxtSonrakiindex.Text);
            abone.tutar = Rdnbtnev.Checked == false ? (abone.sonrakindex - abone.oncekindex) * 0.3 : (abone.sonrakindex - abone.oncekindex * 0.5);

            AboneListesi.Add(abone);
            LstOdemeListesi.Items.Add(abone.AdSoyad);
            TxtAboneAdi.Text = "";
            TxtOncekindex.Text = "";
            TxtSonrakiindex.Text = "";

            Rdnbtnev.Checked = false;
            Rdnbtbnsirket.Checked = false;
        }

        private void LstOdemeListesi_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int c = LstOdemeListesi.SelectedIndex;
                DialogResult result = MessageBox.Show(AboneListesi[c].tutar.ToString() + "TL Ücretini Ödemek İstiyormusunuz?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    LstOdendiListesi.Items.Add(LstOdemeListesi.SelectedIndex);
                    LstOdemeListesi.Items.Remove(c);
                    AboneListesi.RemoveAt(c);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
