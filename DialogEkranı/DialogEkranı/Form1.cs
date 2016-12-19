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
            DialogResult result = MessageBox.Show("Devam Etmek İstiyormusun?","Onay Ekranı", MessageBoxButtons.YesNoCancel);

            if(result == DialogResult.Yes)
            {
                button1.Text = "Evet";
            }
            else if (result == DialogResult.No)
            {
                button1.Text = "Hayır";
            }
            else
            {
                button1.Text = "İptal";
            }
        }
    }
}
