using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myClient_callSelf : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string point = Request["point"];
        string shape = Request["shape"];
        if (point == null || shape == null) return;
        msg.Text=String.Format("The point is: {0}, the shape is {1}<br />", point, shape);
        msg.Text += String.Format("<img src='poker/{0}{1}.gif' />", point, shape);
    }
}