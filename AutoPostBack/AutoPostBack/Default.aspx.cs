using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutoPostBack
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("İl Seçiniz...");
                DropDownList1.Items.Add("İzmir");
                DropDownList1.Items.Add("İstanbul");
                DropDownList1.Items.Add("Ankara");

                DropDownList2.Items.Add("İlçe Seçiniz...");
                DropDownList2.Enabled = false;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Enabled = true;

            if (DropDownList1.SelectedIndex==1)
            {
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add("Karşıyaka");
                DropDownList2.Items.Add("Konak");
                DropDownList2.Items.Add("Buca");
            }
            else if(DropDownList1.SelectedIndex==2)
            {
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add("Aksaray");
                DropDownList2.Items.Add("Kadıköy");
                DropDownList2.Items.Add("Eminönü");
            }
            else if(DropDownList1.SelectedIndex==3)
            {
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add("Dikmen");
                DropDownList2.Items.Add("Keçiören");
                DropDownList2.Items.Add("Polatlı");
            }
        }
    }
}