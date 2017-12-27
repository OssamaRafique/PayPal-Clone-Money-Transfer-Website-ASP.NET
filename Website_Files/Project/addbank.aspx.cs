using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class addbank : System.Web.UI.Page
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
            try
            {
                string username = (string)(Session["username"]);
                String bankname = txtbankname.Text.ToString();
                String accountno = txtbankaccount.Text.ToString();
                if (bankname == "")
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Bank Name Must not be empty.";
                    mtop.Style["margin-top"] = "40px";
                }
                else if (accountno == "")
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Account Number Must not be empty";
                    mtop.Style["margin-top"] = "40px";
                }
                else
                {
                    ProjectDatasetTableAdapters.usersTableAdapter ta = new ProjectDatasetTableAdapters.usersTableAdapter();
                    ProjectDataset.usersDataTable td = new ProjectDataset.usersDataTable();
                    td = ta.GetDataByusername(username);
                    String uid = td.Rows[0]["user_id"].ToString();
                    lblmsg.Visible = true;
                    lblmsg.Text = "Bank Added Successfully!";
                    lblmsg.Style["background"] = "#4CAF50!important";
                    mtop.Style["margin-top"] = "40px";
                    ProjectDatasetTableAdapters.user_banksTableAdapter bds = new ProjectDatasetTableAdapters.user_banksTableAdapter();
                    bds.Insert(Convert.ToInt32(uid), bankname, accountno);
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