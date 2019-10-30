using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Defaultget : System.Web.UI.Page
{
    static string current = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        string i = Request["i"];
        string j = Request["j"];
        if (i == null || j == null || i.Equals("") || j.Equals(""))
            Response.Redirect("getTest2.html");
        current += string.Format("<img src='images/{0}.gif' /><img src='images/{1}.gif' />", i, j);
        msg.Text = current;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        current = "";
        msg.Text = "";
    }
}