using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                Session["username"] = null;
                Session["logintype"] = null;
                Response.Redirect("default.aspx");
            }
            Response.Redirect("default.aspx");
        }
    }
}