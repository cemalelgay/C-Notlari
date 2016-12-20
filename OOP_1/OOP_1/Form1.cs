using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_1
{
    public partial class Form1 : Form
    {
        Ogrenci ogr1 = new Ogrenci();
        Ogrenci ogr2 = new Ogrenci();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ogr1.AdSoyadi = "Cemal Elgay";
            ogr1.OgrNo = 50;

            ogr2.AdSoyadi = "Yavuz Gedik";
            ogr2.OgrNo = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ogr1.AdSoyadi + " " + ogr1.OgrNo);
            MessageBox.Show(ogr2.AdSoyadi + " " + ogr2.OgrNo);
        }
    }
}
