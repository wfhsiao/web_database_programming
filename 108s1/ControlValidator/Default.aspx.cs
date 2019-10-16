using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void IsEven(object source, ServerValidateEventArgs args)
    {
        args.IsValid = Convert.ToInt16(TextBox5.Text) % 2 == 0;
    }
}