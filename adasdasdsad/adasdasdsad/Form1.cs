using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adasdasdsad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 5; i < 10; i++)
            {
                Button btn = new Button();
                btn.Width = 30;
                btn.Height = 30;
             
                if (i == 9)
                {
                    btn.Left = 0;
                }
                if (i < 10)
                {
                    btn.Left = btn.Width * i;
                    btn.Top = btn.Height;

                }
                if (i >= 10 && i < 20)
                {
                    btn.Left = btn.Width * (i - 10);
                    btn.Top = btn.Height * 2;
                }
             
                this.Controls.Add(btn);
            }
        }
    }
}
