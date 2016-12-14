using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarAt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void ZarAt()
        {
            int sayi;
            sayi = rnd.Next(1, 7);
            Zar1.ImageLocation = System.IO.Path.GetFullPath("Zarresim/" + sayi + ".png");
            sayi = rnd.Next(1, 7);
            Zar2.ImageLocation = System.IO.Path.GetFullPath("Zarresim/" + sayi + ".png");

            MessageBox.Show("2 Zar YüzBin Verdik");
        }

        private void Zar1_Click(object sender, EventArgs e)
        {
            ZarAt();
        }

        private void Zar2_Click(object sender, EventArgs e)
        {
            ZarAt();
        }
    }
}
