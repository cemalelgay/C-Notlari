using IZSUFormApp.DataLayer.DBCon;
using IZSUFormApp.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IZSUFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dtTarih.Format = DateTimePickerFormat.Custom;
            dtTarih.CustomFormat = "MM-yyyy";
            dtTarih.ShowUpDown = true;

            BtnKaydet.Enabled = false;
            GroupBoxFatura.Enabled = false;
            using (IzsuDBContext context = new IzsuDBContext())
            {
                var result = context.AboneTuru.ToList();

                foreach (var item in result)
                {
                    cboxAboneTuru.Items.Add(item);
                }

                //int yeniAboneNo = context.Abone.OrderByDescending(a => a.AboneNo).FirstOrDefault().AboneNo++;
                Abone _abone = context.Abone.OrderByDescending(a => a.AboneNo).FirstOrDefault();
                int yeniAboneNo = _abone.AboneNo;
                yeniAboneNo++;

                TxtAboneNo.Text = yeniAboneNo.ToString();

            }
        }
        private void TxtAboneNo_Leave(object sender, EventArgs e)
        {
            using (IzsuDBContext context = new IzsuDBContext())
            {
                int _aboneNo = int.Parse(TxtAboneNo.Text);
                var result = context.Abone.FirstOrDefault(a => a.AboneNo == _aboneNo);
                if (result != null)
                {
                    TxtAboneNo.Enabled = false;
                    TxtAdSoyad.Enabled = false;
                    cboxAboneTuru.Enabled = false;
                    GroupBoxFatura.Enabled = true;

                    TxtAdSoyad.Text = result.AboneAdSoyad;
                    cboxAboneTuru.SelectedIndex = result.AboneTuruID - 1;

                    TxtFaturaAboneNo.Text = result.AboneNo.ToString();
                    TxtFaturaAdSoyad.Text = result.AboneAdSoyad;
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bulunamadı!");
                    BtnKaydet.Enabled = true;
                    TxtAdSoyad.Enabled = true;
                    cboxAboneTuru.Enabled = true;
                }
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Abone a = new Abone();
            a.AboneNo = int.Parse(TxtAboneNo.Text);
            a.AboneAdSoyad = TxtAdSoyad.Text;

            AboneTuru at = (AboneTuru)cboxAboneTuru.SelectedItem;
            a.AboneTuruID = at.AboneTuruID;

            using (IzsuDBContext context = new IzsuDBContext())
            {
                context.Abone.Add(a);
                context.SaveChanges();
            }
        }

        private void BtnBas_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in GroupBoxAbone.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
            TxtAboneNo.Enabled = true;
        }
    }
}
