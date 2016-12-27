using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsanKaynaklari_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NumericSatisAdeti.Enabled = false;
            BtnGuncelle.Enabled = false;
        }

        private void LstBoxCalisanlar_DoubleClick(object sender, EventArgs e)
        {
            SatisTemsilcisi st = (SatisTemsilcisi)LstBoxCalisanlar.SelectedItem;

            ComboBoxElemanTuru.Enabled = false;
            NumericMaas.Enabled = false;
            NumericSSKNo.Enabled = false;
            NumericSatisAdeti.Enabled = true;
            BtnGuncelle.Enabled = true;

            NumericSSKNo.Value = st.sskNo;
            NumericMaas.Value = Convert.ToDecimal(st.maas);
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SatisTemsilcisi st = new SatisTemsilcisi();
            st.elemanTuru = ComboBoxElemanTuru.SelectedItem.ToString();
            st.maas = Convert.ToDouble(NumericMaas.Value);
            st.sskNo = Convert.ToInt32(NumericSSKNo.Value);
            LstBoxCalisanlar.Items.Add(st);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SatisTemsilcisi st = (SatisTemsilcisi)LstBoxCalisanlar.SelectedItem;

            int satisAdeti = Convert.ToInt32(NumericSatisAdeti.Value);
            NumericMaas.Value = Convert.ToDecimal(st.ZamYap(Convert.ToInt32(NumericSatisAdeti.Value)));
        }
    }
}
