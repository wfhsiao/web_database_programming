using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    static int sum = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int n = Convert.ToInt16(TextBox1.Text);
        sum += n;
        Literal1.Text = sum.ToString();
        TextBox1.Focus();
        TextBox1.Attributes["onfocus"] = "this.select()";

    }
}