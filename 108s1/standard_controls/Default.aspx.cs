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
        if (! IsPostBack)
        {
            string[] names = { "TextBox1", "TextBox2" };
            DropDownList1.DataSource = names;
            DropDownList1.DataBind();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Literal1.Text = "Hello";
        TextBox1.Visible = false;
        TextBox2.Enabled = false;

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox c = (TextBox) Page.FindControl(DropDownList1.SelectedValue);
        c.Text = "Here";
    }
}