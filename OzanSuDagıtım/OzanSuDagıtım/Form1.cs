using OzanSuDagıtım.DBConnection;
using OzanSuDagıtım.DBConnection.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OzanSuDagıtım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (OzanSuDagıtımModel con = new OzanSuDagıtımModel())
            {
                //Product p = new Product();
                //p.ProductName = "Pınar 19lt";
                //p.ProductPrice = 11.5;
                //con.Product.Add(p);

                //con.Product.Add(new Product { ProductName = "Hayat 19lt", ProductPrice = 8.45 });
                //con.SaveChanges();

                var result = con.Product.ToList();
                dataGridView1.DataSource = result;
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            using (OzanSuDagıtımModel con = new OzanSuDagıtımModel())
            {
                Product p = new Product();
                p.ProductName = TxtUrunIsmi.Text;
                p.ProductPrice = Convert.ToDouble(numericUrunFiyat.Value);
                p.ProductSize = Convert.ToInt32(numericUrunLitre.Value);
                con.Product.Add(p);
                con.SaveChanges();

                dataGridView1.DataSource = con.Product.ToList();
            }            
        }
    }
}
