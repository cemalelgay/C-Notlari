using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostBack
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("Aytekin");
                DropDownList1.Items.Add("Çeyiz");
                DropDownList1.Items.Add("Hakan");
                DropDownList1.Items.Add("Bengisu");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DropDownList1.Items.Add("Atakan");
        }
        //Butona tıklayınca yeniden page_load tekrar ekler
        //İlk form yüklendiğinde postback true olur.
    }
}