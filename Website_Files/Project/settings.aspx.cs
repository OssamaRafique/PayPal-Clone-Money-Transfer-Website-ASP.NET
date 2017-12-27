using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class settings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblmsg.Visible = false;
            }
        }

        protected void btnsend_Click(object sender, EventArgs e)
        {
            String username = (String)Session["username"];
            String Name = txtname.Text.ToString();
            String pass = txtpassword.Text.ToString();
            ProjectDatasetTableAdapters.usersTableAdapter ds = new ProjectDatasetTableAdapters.usersTableAdapter();
            String count = ds.passwordcheck(username, pass).ToString();
            if(Convert.ToInt32(count)>0)
            {
                ds.updatefullname(Name, username);
                lblmsg.Visible = true;
                lblmsg.Style["background"] = "#4CAF50!important";
                lblmsg.Text = "Name Successfully Changed";
                mtop.Style["margin-top"] = "40px";
            }
            else
            {
                lblmsg.Visible = true;
                lblmsg.Text = "Password Is Incorrect";
                mtop.Style["margin-top"] = "40px";
            }
        }
    }
}