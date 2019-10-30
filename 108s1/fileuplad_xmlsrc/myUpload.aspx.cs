using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myUpload : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            string fn = FileUpload1.FileName;
            FileUpload1.SaveAs(Server.MapPath("uploads/" + fn));
            HyperLink1.NavigateUrl = "uploads/" + fn;
            HyperLink1.Text = fn;
            HyperLink1.Visible = true;
        }
    }
}