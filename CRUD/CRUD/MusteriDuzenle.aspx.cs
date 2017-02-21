using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD
{
    public partial class MusteriDuzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["ID"]);
                using (BakkalDBEntities1 db = new BakkalDBEntities1())
                {
                    var result = db.Customers.Find(id);
                    txtAd.Text = result.CustomerName;
                    txtSoyad.Text = result.CustomerSurname;
                    txtTelefon.Text = result.PhoneNumber;
                    txtAdres.Text = result.Adress;
                }
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (BakkalDBEntities1 db = new BakkalDBEntities1())
            {
                int id = int.Parse(Request.QueryString["ID"]);
                var result = db.Customers.Find(id);
                result.CustomerName = txtAd.Text;
                result.CustomerSurname = txtSoyad.Text;
                result.PhoneNumber = txtTelefon.Text;
                result.Adress = txtAdres.Text;

                db.SaveChanges();

                Response.Redirect("MusteriDuzenle.aspx");
            }
        }
    }
}