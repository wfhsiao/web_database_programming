using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    static string current = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        string i = Request["i"];
        string j = Request["j"];
        current += string.Format("<img src='images/{0}.gif' /><img src='images/{1}.gif' />", i, j);
        msg.Text = current;
    }
}