using CodeFirst_Sample_2.DBCon;
using CodeFirst_Sample_2.DBCon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst_Sample_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MarketContext context = new MarketContext())
            {
                var result = context.Category.ToList();
                if (result.Count==0)
                {
                    context.Category.Add(new Category { CategoryName = "Oyun Konsolu" });
                    context.Category.Add(new Category { CategoryName = "Dizüstü Bilgisayar" });

                    context.SaveChanges();
                }
                result = context.Category.ToList();
                foreach (var item in result)
                {
                    CBoxUrunKategori.Items.Add(item);
                }
            }
            DGridList.Visible = false;
            GBoxUrunEkle.Enabled = false;
        }

        private void MenuItemTumUrunler_Click(object sender, EventArgs e)
        {
            using (MarketContext Context = new MarketContext())
            {
                var result = Context.Product.ToList();
                DGridList.DataSource = result;
            }
            DGridList.Visible = true;
        }

        private void MenuItemUrunEkle_Click(object sender, EventArgs e)
        {
            GBoxUrunEkle.Enabled = true;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Product urun = new Product();
            urun.ProductName = TxtUrunAdi.Text;
            urun.ProductPrice = NumUrunFiyati.Value;            
            Category c = (Category)CBoxUrunKategori.SelectedItem; // Yeni kategori ekler.
            urun.CategoryID = c.CategoryID;

            using (MarketContext context = new MarketContext())
            {
                context.Product.Add(urun);
                context.SaveChanges();
            }
        }
    }
}
