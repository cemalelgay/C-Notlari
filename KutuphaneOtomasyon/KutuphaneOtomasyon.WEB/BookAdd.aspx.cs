using KutuphaneOtomasyon.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KutuphaneOtomasyon.WEB
{
    public partial class BookAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlWriter.DataSource = WriterRepository.GetAllWriter();
                ddlWriter.DataTextField = "WriterName";
                ddlWriter.DataValueField = "WriterID";
                ddlWriter.DataBind();
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {

        }
    }
}