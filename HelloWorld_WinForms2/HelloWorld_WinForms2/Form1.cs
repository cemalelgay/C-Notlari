using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld_WinForms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Merhaba İzmir");
        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ad: " + AdTxtB.Text + "\nSifre: " + SifreTxtB.Text);
        }
    }
}
