using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class register : System.Web.UI.Page
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

        protected void btnregister_Click(object sender, EventArgs e)
        {
            try
            {
                string username = Regex.Replace(txtusername.Text, @"[^\w]", "");
                string fullname = Regex.Replace(txtfullname.Text, @"[^\w]", "");
                string email = txtemail.Text.ToString();
                string password = Regex.Replace(txtpassword.Text, @"[^\w]", "");
                string password_repeat = Regex.Replace(txtrepeatpassword.Text, @"[^\w]", "");
                string mobileno = Regex.Replace(txtmobile.Text, @"[^\w]", "");
                if (username == "")
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Username must not be empty.";
                    mtop.Style["margin-top"] = "40px";
                } else if (fullname=="") {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Real name must not be empty.";
                    mtop.Style["margin-top"] = "40px";
                } else if (email == "")
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Email must not be empty.";
                    mtop.Style["margin-top"] = "40px";
                } else if (password == "")
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Password must not be empty.";
                    mtop.Style["margin-top"] = "40px";
                } else if (password_repeat == "")
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Password Repeat Feild must not be empty.";
                    mtop.Style["margin-top"] = "40px";
                } else if (mobileno == "")
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Mobile no must not be empty.";
                    mtop.Style["margin-top"] = "40px";
                } else if (password != password_repeat)
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Passwords Donot Match.";
                    mtop.Style["margin-top"] = "40px";
                }
                else
                {
                    ProjectDatasetTableAdapters.usersTableAdapter ta = new ProjectDatasetTableAdapters.usersTableAdapter();
                    string ucount = ta.checkbyusername(username).ToString();
                    string ecount = ta.checkbyemail(email).ToString();
                    if (Convert.ToInt32(ucount) > 0)
                    {
                        lblmsg.Visible = true;
                        lblmsg.Text = "Username Already Exists";
                        mtop.Style["margin-top"] = "40px";
                    } else if (Convert.ToInt32(ecount) > 0)
                    {
                        lblmsg.Visible = true;
                        lblmsg.Text = "Email Already Exists";
                        mtop.Style["margin-top"] = "40px";
                    } else
                    {
                        ta.InsertQuery(username, email, password, fullname);
                        lblmsg.Visible = true;
                        lblmsg.Text = "You are Registered Successfully!";
                        lblmsg.Style["background"] = "#4CAF50!important";
                        mtop.Style["margin-top"] = "40px";
                    }
                }
            }
            catch(Exception ex)
            {
                lblmsg.Visible = true;
                lblmsg.Text = ex.ToString();
                mtop.Style["margin-top"] = "40px";
            }
        }
    }
}