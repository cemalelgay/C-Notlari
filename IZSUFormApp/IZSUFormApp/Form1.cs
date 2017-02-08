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
            #region TarihFormat
            dtTarih.Format = DateTimePickerFormat.Custom;
            dtTarih.CustomFormat = "MM-yyyy";
            dtTarih.ShowUpDown = true;
            #endregion
            #region ErişimKısıtlama
            BtnKaydet.Enabled = false;
            GroupBoxFatura.Enabled = false;
            #endregion
            #region AboneTurleriCekmeVeYenıAboneNo
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
            #endregion
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

                    var gelenDeger = context.Fatura.OrderByDescending(f => f.FaturaID).FirstOrDefault(f => f.AboneID == result.AboneID);

                    if (gelenDeger != null)
                    {
                        TxtFaturaOncekiSayac.Enabled = false;
                        TxtFaturaOncekiSayac.Text = gelenDeger.GuncelSayac.ToString();
                    }
                    else
                    {
                        TxtFaturaOncekiSayac.Text = "0";
                    }
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

            foreach (Control ctrl in GroupBoxFatura.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }

            TxtAboneNo.Enabled = true;
            dgvBilgiler.DataSource = null;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            int _aboneNo = int.Parse(TxtFaturaAboneNo.Text);

            Fatura f = new Fatura();
            f.FaturaTarihi = dtTarih.Value;
            f.GuncelSayac = int.Parse(TxtFaturaGuncelSayac.Text);
            f.OncekiSayac = int.Parse(TxtFaturaOncekiSayac.Text);

            using (IzsuDBContext context = new IzsuDBContext())
            {
                int _aboneID = context.Abone.FirstOrDefault(a => a.AboneNo == _aboneNo).AboneID;

                f.AboneID = _aboneID;
                f.OdemeTutari = (decimal)f.OdemeHesapla();

                // var result = context.Fatura.
                //FirstOrDefault(fa => f.AboneID == _aboneID && (fa.FaturaTarihi.Month == dtTarih.Value.Month && fa.FaturaTarihi.Year == dtTarih.Value.Year));

                var result = context.Fatura.FirstOrDefault(fa => fa.AboneID == _aboneID && (fa.FaturaTarihi.Month == dtTarih.Value.Month && fa.FaturaTarihi.Year == dtTarih.Value.Year));

                if (result != null)
                {
                    MessageBox.Show(dtTarih.Value.Month + "-" + dtTarih.Value.Year + "tarihine ait fatura bulunmaktadır.");
                }
                else
                {
                    context.Fatura.Add(f);
                    context.SaveChanges();
                    MessageBox.Show("Fatura Eklendi");
                }
            }
        }

        private void BtnGetir_Click(object sender, EventArgs e)
        {
            int _aboneNo = int.Parse(TxtFaturaAboneNo.Text);

            using (IzsuDBContext context = new IzsuDBContext())
            {
                int _aboneID = context.Abone.FirstOrDefault(a => a.AboneNo == _aboneNo).AboneID;

                dgvBilgiler.DataSource = context.Fatura.Where(f => f.AboneID == _aboneID && (f.FaturaTarihi.Month == dtTarih.Value.Month && f.FaturaTarihi.Year == dtTarih.Value.Year)).Select
                (f => new
                {
                    FaturaID = f.FaturaID,
                    AboneAd = f.Abone.AboneAdSoyad,
                    OdemeTutari = f.OdemeTutari,
                    OdemeDurumu = f.Tahsilat == false ? "Ödenmedi" : "Ödendi",
                    Tarih = f.FaturaTarihi.Month + "-" + f.FaturaTarihi.Year
                }).ToList();
            }

        }

        private void BtnTumunuGetir_Click(object sender, EventArgs e)
        {
            int _aboneNo = int.Parse(TxtFaturaAboneNo.Text);

            using (IzsuDBContext context = new IzsuDBContext())
            {
                int _aboneID = context.Abone.FirstOrDefault(a => a.AboneNo == _aboneNo).AboneID;

                var result = context.Fatura.Where(f => f.AboneID == _aboneID).Select(f => new
                {
                    FaturaID = f.FaturaID,
                    AboneAd = f.Abone.AboneAdSoyad,
                    OdemeTutari = f.OdemeTutari,
                    OdemeDurumu = f.Tahsilat == false ? "Ödenmedi" : "Ödendi",
                    Tarih = f.FaturaTarihi.Month + "-" + f.FaturaTarihi.Year
                }).ToList();

                decimal toplamBorc = 0;
                foreach (var item in result)
                {
                    if (item.OdemeDurumu == "Ödenmedi")
                    {
                        toplamBorc += item.OdemeTutari;
                    }
                }

                TxtToplamBorc.Text = toplamBorc + ToString() + " ₺";

                dgvBilgiler.DataSource = result; 
            }
        }

        private void dgvBilgiler_DoubleClick(object sender, EventArgs e)
        {
            int faturaID = Convert.ToInt32(dgvBilgiler.SelectedRows[0].Cells[0].Value);

            DialogResult dr = MessageBox.Show("Ödeme Yapmak İstiyor Musunuz?", "Uyarı", MessageBoxButtons.OKCancel);

            using (IzsuDBContext context = new IzsuDBContext())
            {
                var result = context.Fatura.FirstOrDefault(f => f.FaturaID == faturaID);

                result.Tahsilat = true;
                context.SaveChanges();
            }
        }
    }
}
