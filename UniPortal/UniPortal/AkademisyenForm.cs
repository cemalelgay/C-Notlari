using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniPortal
{
    public partial class AkademisyenForm : Form
    {
        public AkademisyenForm()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            OgretimGorevlisi ogrv = new OgretimGorevlisi();
            ogrv.ad = TxtAd.Text;
            ogrv.soyad = TxtSoyad.Text;
            ogrv.telefon = TxtTel.Text;
            ogrv.gorevi = TxtGorevi.Text;
            ogrv.bolumu = TxtBolum.Text;

            DataGridAkademisyen.Rows.Add(ogrv.ad, ogrv.soyad, ogrv.telefon, ogrv.gorevi, ogrv.bolumu);
            MessageBox.Show(ogrv.BilgiGoster());
        }
    }
}
