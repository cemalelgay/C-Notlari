using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD
{
    public partial class MusteriEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            using (BakkalDBEntities1 db = new BakkalDBEntities1())
            {
                Customer cus = new Customer();
                cus.CustomerName = txtAd.Text;
                cus.CustomerSurname = txtSoyad.Text;
                cus.PhoneNumber = txtTelefon.Text;
                cus.Adress = txtAdres.Text;

                db.Customers.Add(cus);
                db.SaveChanges();

                Response.Redirect("Musteriler.aspx");
            }
        }
    }
}