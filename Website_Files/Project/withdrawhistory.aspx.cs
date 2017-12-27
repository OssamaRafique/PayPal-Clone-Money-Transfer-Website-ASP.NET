using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class withdrawhistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string username = (string)(Session["username"]);
                ProjectDatasetTableAdapters.DataTable1TableAdapter nds = new ProjectDatasetTableAdapters.DataTable1TableAdapter();
                ProjectDataset.DataTable1DataTable ndt = new ProjectDataset.DataTable1DataTable();
                ndt = nds.GetData(username);
                if (ndt.Rows.Count>0)
                {
                    tbwithdraw.Visible = true;
                    lblmsg.Visible = false;
                    tbwithdraw.DataSource = ndt;
                    tbwithdraw.DataBind();
                }
                else
                {
                    tbwithdraw.Visible = false;
                    lblmsg.Visible = true;
                    lblmsg.Text = "Sorry, Don't have any withdrawal History!";
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