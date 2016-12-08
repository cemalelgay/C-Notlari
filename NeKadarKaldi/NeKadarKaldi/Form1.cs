using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeKadarKaldi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            int gunlukSaat = Convert.ToInt32(gunlukSaatTxtB.Text);

            if (gunlukSaat>24)
            {
                MessageBox.Show("1 Gün 24 Saat");
                gunlukSaatTxtB.Text = " ";
            }
            else
            {
                int gun = 10000 / gunlukSaat;
                int ay = gun / 30;
                int yil = gun / 365;
                
                MessageBox.Show("Gün : " + gun + "\nAy : " + ay + "\n Yıl : " + yil);
            }
            
        }

        private void HesapBtn_Click(object sender, EventArgs e)
        {
            double uykusaat = Convert.ToInt32(gunSaatTxtB.Text);
            double yasam = Convert.ToInt32(yasTxtB.Text);
            double oran = uykusaat / 24;
            MessageBox.Show(oran * yasam + "Yıl : ");  //u*365*80/24/365 
        }
    }
}
