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
        
        private void zarAtBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int zar = rnd.Next(1, 7);
            pictureBox1.ImageLocation = System.IO.Path.GetFullPath("Zarresim/" + zar + ".png");
            MessageBox.Show("2 Zar YüzBin Verdik");
        }
    }
}
