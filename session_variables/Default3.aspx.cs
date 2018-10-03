using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DateTime dt = DateTime.Today;
        DateTime dt2 = DateTime.Now;
        Response.Output.Write("{0}<br />", dt.ToShortDateString());
        dt = dt.AddDays(7);
        Response.Output.Write("{0:d}<br />", dt);
        Response.Write(dt2);
    }
}