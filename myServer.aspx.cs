using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myServer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string point = Request["point"];
        Response.Output.Write("The point is: {0}", point);
    }
}