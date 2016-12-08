using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int red, green, blue;
        //Metot(fonksiyon) yazma
        //mail@yavuzgedik.com
        private Color RasgeleRenkOlustur()
        {
            red = rnd.Next(0, 256);
            green = rnd.Next(0, 256);
            blue = rnd.Next(0, 256);

            Color rasgeleRenk = Color.FromArgb(red, green, blue);

            return rasgeleRenk;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                Button btn = new Button();
                btn.Width = 50;
                btn.Height = 50;

                btn.BackColor = RasgeleRenkOlustur();

                btn.Left = btn.Width * i;
                btn.Click += ButtonClick;

                this.Controls.Add(btn);
            }
        }

        private void ButtonClick (object sender, EventArgs e)
        {
            Button secilenbuton = sender as Button;
            this.BackColor = secilenbuton.BackColor;
        }

    }
}
