using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Project
{
    public partial class uploadavatar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblmsg.Visible = false;
            }
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                HttpPostedFile postedFile = avimage.PostedFile;
                string fileName = Path.GetFileName(postedFile.FileName);
                string fileextention = Path.GetExtension(fileName);
                int filesize = postedFile.ContentLength;
                if (fileextention.ToLower() == ".jpg" || fileextention.ToLower() == ".png" || fileextention.ToLower() == ".gif")
                {
                    ProjectDatasetTableAdapters.usersTableAdapter ds = new ProjectDatasetTableAdapters.usersTableAdapter();
                    string username = (string)Session["username"];
                    Stream stream = postedFile.InputStream;
                    BinaryReader binaryreader = new BinaryReader(stream);
                    byte[] bytes = binaryreader.ReadBytes((int)stream.Length);
                    ds.updateavatar(bytes, username);
                    lblmsg.Visible = true;
                    lblmsg.Text = "Image Successfully Uploaded!";
                    lblmsg.Style["background"] = "#4CAF50!important";
                    mtop.Style["margin-top"] = "40px";
                }
                else
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Only Image files are supported.";
                    mtop.Style["margin-top"] = "40px";
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