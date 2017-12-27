using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class withdraw : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                Loadbanks();
                lblmsg.Visible = false;
            }
        }

        protected void btnwithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                String username = (string)Session["username"];
                String bankid = dropdownbank.SelectedItem.Value.ToString();
                String wamount = txtamount.Text.ToString();
                int amount = Convert.ToInt32(wamount);
                ProjectDatasetTableAdapters.withdrawalsTableAdapter wds = new ProjectDatasetTableAdapters.withdrawalsTableAdapter();
                ProjectDatasetTableAdapters.usersTableAdapter uds = new ProjectDatasetTableAdapters.usersTableAdapter();
                ProjectDataset.usersDataTable udt = new ProjectDataset.usersDataTable();
                udt = uds.GetDataByusername(username);
                String userid = udt.Rows[0]["user_id"].ToString();
                int balance = Convert.ToInt32(udt.Rows[0]["balance"].ToString());
                String bankcount=uds.verifybankforwithdrawal(username, Convert.ToInt32(bankid)).ToString();
                if (Convert.ToInt32(bankcount) > 0)
                {
                    if (amount < 500)
                    {
                        lblmsg.Visible = true;
                        lblmsg.Text = "Minimum amount to withdraw is 500 PKR";
                        mtop.Style["margin-top"] = "40px";
                    } else if (balance<amount)
                    {
                        lblmsg.Visible = true;
                        lblmsg.Text = "You Don't have Enought Balance";
                        mtop.Style["margin-top"] = "40px";
                    } else
                    {
                        lblmsg.Visible = true;
                        lblmsg.Text = "Withdrawal Successfully Initiated.";
                        lblmsg.Style["background"] = "#4CAF50!important";
                        mtop.Style["margin-top"] = "40px";
                        wds.insertwithdrawal(Convert.ToInt32(userid), Convert.ToInt32(bankid), Convert.ToInt32(wamount));
                        uds.updatesenderbalance(Convert.ToInt32(wamount), username);
                    }
                } else
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "This bank account is not yours.";
                    mtop.Style["margin-top"] = "40px";
                }
            } catch(Exception ex)
            {
                lblmsg.Visible = true;
                lblmsg.Text = ex.ToString();
                mtop.Style["margin-top"] = "40px";
            }
        }
        protected void Loadbanks()
        {
            String username = (String)Session["username"];
            ProjectDatasetTableAdapters.usersTableAdapter uds = new ProjectDatasetTableAdapters.usersTableAdapter();
            ProjectDataset.usersDataTable uta = new ProjectDataset.usersDataTable();
            uta = uds.getuserbankaccounts(username);
            dropdownbank.DataSource = uta;
            dropdownbank.DataTextField = "bankdetails";
            dropdownbank.DataValueField = "bankid";
            dropdownbank.DataBind();
            dropdownbank.Items.Insert(0, new ListItem("Please Select Bank Account", "-1"));
        }

        protected void dropdownbank_SelectedIndexChanged(object sender, EventArgs e)
        {
            dropdownbank.SelectedValue = dropdownbank.SelectedItem.Value;
        }
    }
}