using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogEkranı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Devam Etmek İstiyormusun?", "Onay Ekranı", MessageBoxButtons.YesNoCancel);

            //if (result == DialogResult.Yes)
            //{
            //    BtnKaydet.Text = "Evet";
            //}
            //else if (result == DialogResult.No)
            //{
            //    BtnKaydet.Text = "Hayır";
            //}
            //else
            //{
            //    BtnKaydet.Text = "İptal";
            //}


            if (TxtAd.Text != "")
            {
                listBox1.Items.Add(TxtAd.Text);
            }
            TxtAd.Clear();
            TxtAd.Focus();
            TxtAd.ForeColor = Color.Red;
            
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek İstiyormusun?", "Onay Ekranı", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else if (result == DialogResult.No)
            {
                
            }
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hepsi Silinecek?", "Onay Ekranı", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                listBox1.Items.Clear();
            }
        }
    }
}
