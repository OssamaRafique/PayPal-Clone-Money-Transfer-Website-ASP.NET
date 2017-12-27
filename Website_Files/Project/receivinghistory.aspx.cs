using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class receivinghistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String username = (String)Session["username"];
                ProjectDatasetTableAdapters.usersTableAdapter ds = new ProjectDatasetTableAdapters.usersTableAdapter();
                ProjectDataset.usersDataTable dtn = new ProjectDataset.usersDataTable();
                dtn = ds.GetDataByusername(username);
                int userid = Convert.ToInt32(dtn.Rows[0]["user_id"].ToString());
                ProjectDataset.usersDataTable dt = new ProjectDataset.usersDataTable();
                dt = ds.getreceiveinfo(userid);
                if (dt.Rows.Count > 0)
                {
                    tblsent.Visible = true;
                    lblmsg.Visible = false;
                    tblsent.DataSource = dt;
                    tblsent.DataBind();
                }
                else
                {
                    tblsent.Visible = false;
                    lblmsg.Visible = true;
                    lblmsg.Text = "You have not received any payment yet!";
                }
            }
            catch (Exception ex)
            {
                lblmsg.Visible = true;
                lblmsg.Text = ex.ToString();
            }
        }
    }
}