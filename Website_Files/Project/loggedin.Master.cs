using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Project
{
    public partial class loggedin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["username"] == null)
                {
                    Response.Redirect("login.aspx");
                }
                else
                {
                    Loadavatar();
                    ProjectDatasetTableAdapters.usersTableAdapter ta = new ProjectDatasetTableAdapters.usersTableAdapter();
                    ProjectDataset.usersDataTable dt = new ProjectDataset.usersDataTable();
                    string username = (string)Session["username"];
                    dt = ta.GetDataByusername(username);
                    lblname.InnerText = dt.Rows[0]["fullname"].ToString();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }
        public void Loadavatar()
        {
            ProjectDatasetTableAdapters.usersTableAdapter ta = new ProjectDatasetTableAdapters.usersTableAdapter();
            ProjectDataset.usersDataTable dt = new ProjectDataset.usersDataTable();
            string username = (string)Session["username"];
            dt = ta.getavatarbyusername(username);
            if ((dt.Rows[0]["user_avatar"] as byte[])!=null)
            {
                byte[] bytes = (byte[])dt.Rows[0]["user_avatar"];
                String bse64 = Convert.ToBase64String(bytes);
                //avatar.ImageUrl = "data:Image/png;base64," + bse64;
                //avatar1.ImageUrl = "data:Image/png;base64," + bse64;
                avatar.ImageUrl = "assets/img/avatar.png";
                avatar1.ImageUrl = "assets/img/avatar.png";
            }
            else
            {
                avatar.ImageUrl = "assets/img/avatar.png";
                avatar1.ImageUrl = "assets/img/avatar.png";
            }
        }
        public string Loadchart(int month)
        {
            ProjectDatasetTableAdapters.usersTableAdapter ds = new ProjectDatasetTableAdapters.usersTableAdapter();
            string username = (string)Session["username"];
            
            if (ds.chartvalue(username,month) != null)
            {
                string chartv = ds.chartvalue(username,month).ToString();
                return chartv;
            }
            else
            {
                return "0";
            }
        }
    }
}