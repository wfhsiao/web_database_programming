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
        Random r = new Random();
        for (int i = 0; i < 10; i++)
        {
            Response.Output.Write("<img src='dice/d{0}.gif' />",r.Next(1, 7));
        }
       
    }
}