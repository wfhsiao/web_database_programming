using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyTimeSpan : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DateTime d = DateTime.Parse("10/23/2015 14:00pm");
        DateTime d1 = DateTime.Parse("10/23/2015 17:00pm");
        DateTime d2 = d1.AddHours(24);
        Response.Output.Write("{0}-{1}={2}<br />", d1, d, d1.Subtract(d));
        Response.Output.Write("{0}-{1}={2}<br />", d2, d, d2.Subtract(d));
        Response.Output.Write("{0}-{1}={2:f2} hours<br />", d2, d, d2.Subtract(d).TotalHours); 
    }
}