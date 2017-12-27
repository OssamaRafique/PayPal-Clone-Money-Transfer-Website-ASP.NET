using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                Response.Redirect("dashboard.aspx");
            }
            if (!IsPostBack)
            {
                lblmsg.Visible = false;
            }
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = Regex.Replace(txtusername.Text, @"[^\w]", "");
                string password = Regex.Replace(txtpassword.Text, @"[^\w]", "");
                if (username == "")
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Username must not be empty.";
                    mtop.Style["margin-top"] = "40px";
                }
                else if (password == "")
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Password must not be empty.";
                    mtop.Style["margin-top"] = "40px";
                }
                else
                {
                    ProjectDatasetTableAdapters.usersTableAdapter ta = new ProjectDatasetTableAdapters.usersTableAdapter();
                    string ucheck = ta.checkbyusername(username).ToString();
                    string pcheck = ta.passwordcheck(username, password).ToString();
                    if (Convert.ToInt32(ucheck) == 0)
                    {
                        lblmsg.Visible = true;
                        lblmsg.Text = "Username doesn't Exist.";
                        mtop.Style["margin-top"] = "40px";
                    }
                    else if (Convert.ToInt32(pcheck) == 0)
                    {
                        lblmsg.Visible = true;
                        lblmsg.Text = "Username/Password Is incorrect.";
                        mtop.Style["margin-top"] = "40px";
                    }
                    else if (username == "admin")
                    {
                        Session["username"] = username;
                        Session["logintype"] = "admin";
                        Response.Redirect("dashboard.aspx");
                    }
                    else
                    {
                        Session["username"] = username;
                        Session["logintype"] = "user";
                        Response.Redirect("dashboard.aspx");
                    }
                }
            }
            catch (Exception ex)
            {
                lblmsg.Visible = true;
                lblmsg.Text = ex.ToString();
                mtop.Style["margin-top"] = "40px";
            }
        }
    }
}