using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        msg.Text = String.Format("This is {0}.", System.IO.Path.GetFileName(System.Web.HttpContext.Current.Request.Url.AbsolutePath));
        if (PreviousPage != null)
        {
            TextBox txt = (TextBox)PreviousPage.FindControl("TextBox1");
            Response.Output.Write("content: {0}", txt.Text);
        }
        else
            Response.Redirect("Default.aspx");
    }
}