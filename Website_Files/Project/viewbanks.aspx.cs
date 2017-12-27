using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class viewbanks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string username = (string)(Session["username"]);
                ProjectDatasetTableAdapters.user_banksTableAdapter ds = new ProjectDatasetTableAdapters.user_banksTableAdapter();
                ProjectDataset.user_banksDataTable dt = new ProjectDataset.user_banksDataTable();
                dt = ds.GetDataid(username);
                if (dt.Rows.Count > 0)
                {
                    banksview.Visible = true;
                    lblmsg.Visible = false;
                    banksview.DataSource = dt;
                    banksview.DataBind();
                }
                else
                {
                    banksview.Visible = false;
                    lblmsg.Visible = true;
                    lblmsg.Text = "Sorry, You have not added any bank account yet!";
                }
            } catch(Exception ex)
            {
                lblmsg.Visible = true;
                lblmsg.Text = ex.ToString();
            }
            
        }
    }
}