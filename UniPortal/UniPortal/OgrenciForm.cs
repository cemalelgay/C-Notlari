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
    public partial class OgrenciForm : Form
    {
        public OgrenciForm()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci o = new UniPortal.Ogrenci();
            o.ad = TxtAd.Text;
            o.soyad = TxtSoyad.Text;
            o.telefon = TxtTel.Text;

            DataGridOgrenci.Rows.Add(o.ad, o.soyad, o.telefon);
            MessageBox.Show(o.BilgiGoster());
        }
    }
}
