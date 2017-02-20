using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StandartControls
{
    public partial class _2_ListBox : System.Web.UI.Page
    {
        void KategoriListele()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                ddlKategoriler.DataSource = db.Categories.ToList();
                ddlKategoriler.DataTextField = "CategoryName";
                ddlKategoriler.DataValueField = "CategoryId";
                ddlKategoriler.DataBind();
            }
        }
        void UrunGetir(int catID)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                lbUrunler.DataSource = db.Products.Where(u => u.CategoryID == catID).ToList();
                lbUrunler.DataTextField = "ProductName";
                lbUrunler.DataBind();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            {
                KategoriListele();
            }
        }

        protected void ddlKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrunGetir(int.Parse(ddlKategoriler.SelectedItem.Value));
        }
    }
}