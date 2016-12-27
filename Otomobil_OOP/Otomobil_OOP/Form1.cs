using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomobil_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Porsche superAraba = new Porsche();
            Tofas duldul = new Tofas();
            Honda emektar = new Honda();

            //MessageBox.Show(superAraba.Yazdir());
            //MessageBox.Show(superAraba.çalirtir());

            //MessageBox.Show(duldul.Yazdir());
            //MessageBox.Show(duldul.çalirtir());

            //MessageBox.Show(emektar.Yazdir());
            //MessageBox.Show(emektar.çalirtir());

            //Porsche superAraba = new Porsche();
            //Tofas duldul = new Tofas();
            //Honda emektar = new Honda();

            MessageBox.Show(superAraba.ToString());
            MessageBox.Show(superAraba.çalirtir());

            MessageBox.Show(duldul.ToString());
            MessageBox.Show(duldul.çalirtir());

            MessageBox.Show(emektar.ToString());
            MessageBox.Show(emektar.çalirtir());

        }
    }
}
