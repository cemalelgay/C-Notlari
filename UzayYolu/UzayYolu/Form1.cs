using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UzayYolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int genislik, yukseklik;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            genislik = Form1.ActiveForm.Width;
            yukseklik = Form1.ActiveForm.Height;

            switch (e.KeyCode)
            {
                case Keys.Left: //A
                    SpaceShip.Left -= 10;
                    break;

                case Keys.Right: //D
                    SpaceShip.Left += 10;
                    break;

                case Keys.Up: //W
                    SpaceShip.Top -= 10;
                    break;

                case Keys.Down: //S
                    SpaceShip.Top += 10;
                    break;

                case Keys.Space:
                    int x = SpaceShip.Location.X + SpaceShip.Width / 2;
                    int y = SpaceShip.Location.Y + SpaceShip.Width / 2;
                    rocket.Location = new Point(x, y);
                    rocket.Visible = true;
                    timer1.Start();
                    break;

                default:
                    break;
            }
            int SpaceX = SpaceShip.Location.X;
            int SpaceY = SpaceShip.Location.Y;

            if (SpaceX > genislik - SpaceShip.Width || SpaceX <= 0)
            {
                MessageBox.Show("Lanet Olsun Oyun Bitti...!");
            }
            else if (SpaceY > yukseklik - SpaceShip.Height || SpaceY <= 0)
            {
                MessageBox.Show("Lanet Olsun Oyun Bitti...!");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            genislik = Form1.ActiveForm.Width;
            yukseklik = Form1.ActiveForm.Height;
            if (rocket.Location.X < genislik)
            {
                rocket.Left += 10;
            }
            else
            {
                timer1.Stop();
            }
        }

        //Duvarlara çarpınca game over
        // 2.roket atıldığında 1.gitmeye devam etsin.
    }
}
