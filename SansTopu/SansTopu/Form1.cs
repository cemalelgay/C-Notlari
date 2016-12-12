﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SansTopu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        List<int> Sayilar = new List<int>(6);
        int rasgeleSayi;

        int sayac = 0;


        private void oynaBtn_Click(object sender, EventArgs e)
        {
            while (sayac < 6)
            {
                rasgeleSayi = rnd.Next(1, 50);
                if(!Sayilar.Contains(rasgeleSayi))
                {
                    Sayilar.Add(rasgeleSayi);
                    sayac++;
                }               
            }
            Sayilar.Sort();

            label1.Text = Sayilar[0].ToString();
            label2.Text = Sayilar[1].ToString();
            label3.Text = Sayilar[2].ToString();
            label4.Text = Sayilar[3].ToString();
            label5.Text = Sayilar[4].ToString();
            label6.Text = Sayilar[5].ToString();
        
            sayac = 0;
        }
    }
}
