using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD
{
    public partial class Musteriler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (BakkalDBEntities1 db = new BakkalDBEntities1())
            {
                Repeater1.DataSource = db.Customers.ToList();
                Repeater1.DataBind();
            }
            if (Request.QueryString["ID"] != null)
            {
                int id = int.Parse(Request.QueryString["ID"]);

                using (BakkalDBEntities1 db = new BakkalDBEntities1())
                {
                    var result = db.Customers.Find(id);
                    db.Customers.Remove(result);
                    db.SaveChanges();

                    Response.Redirect("Musteriler.aspx");
                }
            }
        }
    }
}