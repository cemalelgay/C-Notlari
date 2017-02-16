using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReadyDropdownList
{
    public partial class DropPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region Yöntem 1
            //using (NorthwindEntities db = new NorthwindEntities())
            //{
            //    List<Category> catList = db.Categories.ToList();

            //    foreach (var item in catList)
            //    {
            //        DropDownList1.Items.Add(item.ToString());
            //    }
            //}
            #endregion

            #region Yöntem 2
            using (NorthwindEntities db = new NorthwindEntities())
            {
                List<Category> catList = db.Categories.ToList();

                DropDownList1.DataSource = catList;
                DropDownList1.DataTextField = "CategoryName";
                DropDownList1.DataValueField = "CategoryID";
                DropDownList1.DataBind();
            }
            #endregion

        }
    }
}