using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string username = (string)(Session["username"]);
                ProjectDatasetTableAdapters.usersTableAdapter ta = new ProjectDatasetTableAdapters.usersTableAdapter();
                string balance=ta.GetBalancebyusername(username).ToString();
                ProjectDataset.usersDataTable dt = new ProjectDataset.usersDataTable();
                dt = ta.GetDataByusername(username);
                String ubalance=dt.Rows[0]["balance"].ToString();
                String userid=dt.Rows[0]["user_id"].ToString();
                lblbalance.InnerText = ubalance+" PKR";
                ProjectDatasetTableAdapters.transfersTableAdapter tds = new ProjectDatasetTableAdapters.transfersTableAdapter();
                String counter = tds.transactioncount(username).ToString();
                if (Convert.ToInt32(counter)>0)
                {
                    String intransfers = ta.transfercount(Convert.ToInt32(userid)).ToString();
                    lbltransfers.InnerText = intransfers + " PKR";
                }
                ProjectDatasetTableAdapters.withdrawalsTableAdapter wds = new ProjectDatasetTableAdapters.withdrawalsTableAdapter();
                String wcounter = wds.withdrawalcount(username).ToString();
                if (Convert.ToInt32(wcounter) > 0)
                {
                    String twithdrawals = wds.totalwithdrawals(username).ToString();
                    lblwithdrawals.InnerText = twithdrawals + " PKR";
                }
            }
            catch (Exception Ex)
            {
                Response.Write(Ex.ToString());
            }
        }
    }
}