using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class sendmoney : System.Web.UI.Page
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
            String receiver = Regex.Replace(txtreceiver.Text, @"[^\w]", "");
            String amount = Regex.Replace(txtamount.Text, @"[^\w]", "");
            if (receiver == "")
            {
                lblmsg.Visible = true;
                lblmsg.Text = "Receiver Username Must not be empty.";
                mtop.Style["margin-top"] = "40px";
            }
            else if (amount == "")
            {
                lblmsg.Visible = true;
                lblmsg.Text = "Amount Must not be empty";
                mtop.Style["margin-top"] = "40px";
            }
            else
            {
                if (Convert.ToInt32(amount) < 100)
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Minimum amount you can send is, RS100";
                    mtop.Style["margin-top"] = "40px";
                }
                else
                {
                    ProjectDatasetTableAdapters.usersTableAdapter ta = new ProjectDatasetTableAdapters.usersTableAdapter();
                    String rcount = ta.checkbyusername(receiver).ToString();
                    if (Convert.ToInt32(rcount) == 0)
                    {
                        lblmsg.Visible = true;
                        lblmsg.Text = "User is not registered";
                        mtop.Style["margin-top"] = "40px";
                    }
                    else
                    {
                        ProjectDataset.usersDataTable td = new ProjectDataset.usersDataTable();
                        td = ta.GetDataByusername(username);
                            String sid = td.Rows[0]["user_id"].ToString();

                            String sbalance = td.Rows[0]["balance"].ToString();
                        if (Convert.ToInt32(sbalance) < Convert.ToInt32(amount))
                        {
                            lblmsg.Visible = true;
                            lblmsg.Text = "You Do not Have Enough Balance";
                            mtop.Style["margin-top"] = "40px";
                        }
                        else
                        {
                            ta.updatesenderbalance(Convert.ToInt32(amount), username);
                            ta.updatereceiverbalance(Convert.ToInt32(amount), receiver);
                            td = ta.GetDataByusername(receiver);
                            string rid = td.Rows[0]["user_id"].ToString();
                            lblmsg.Visible = true;
                            lblmsg.Text = "Amount successfully Transferred!";
                            lblmsg.Style["background"] = "#4CAF50!important";
                            mtop.Style["margin-top"] = "40px";
                                ProjectDatasetTableAdapters.transfersTableAdapter tta = new ProjectDatasetTableAdapters.transfersTableAdapter();
                            tta.Insert(Convert.ToInt32(sid), Convert.ToInt32(rid), Convert.ToInt32(amount),DateTime.Now);
                        }
                    }
                }
            }
        } catch(Exception ex)
            {
                lblmsg.Visible = true;
                lblmsg.Text = ex.ToString();
                mtop.Style["margin-top"] = "40px";
            }
        }
    }
}