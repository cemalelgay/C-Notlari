﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CemalElgay_KafeSiparisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            #region Combobox Yemek - İçeçek

            ComboBoxYemek.Items.Add("Kuru Fasulye");
            ComboBoxYemek.Items.Add("Tavuklu Pilav");
            ComboBoxYemek.Items.Add("Simit Tost");
            ComboBoxYemek.Items.Add("Lazanya");

            ComboBoxIcecek.Items.Add("Su");
            ComboBoxIcecek.Items.Add("Kola");
            ComboBoxIcecek.Items.Add("Limonata");
            ComboBoxIcecek.Items.Add("Çay");
            ComboBoxIcecek.Items.Add("Kahve");

            #endregion

            #region Masa Button   
            int sayac = 1;    
                 
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button btn = new Button();
                    btn.Width = 40;
                    btn.Height = 40;
                    btn.Left = btn.Width * j;
                    btn.Top = btn.Width * i;
                    btn.Text = sayac.ToString(); ;
                    groupBox1.Controls.Add(btn);
                    a
                    sayac++;
                }
            }
            #endregion
        }

        private void BtnSiparis_Click(object sender, EventArgs e)
        {
           
        }
    }
}
