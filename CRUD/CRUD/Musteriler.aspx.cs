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
            using (BakkalDBEntities db = new BakkalDBEntities())
            {
                Repeater1.DataSource = db.Customers.ToList();
                Repeater1.DataBind();
            }
        }
    }
}