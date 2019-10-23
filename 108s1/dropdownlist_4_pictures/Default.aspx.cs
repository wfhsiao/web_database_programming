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
            string[] shapes = { "s", "h", "d", "c" };
            string[] points = { "a", "2", "3", "4", "5", "6", "7", "8", "9", "t", "j", "q", "k" };
            DropDownList1.DataSource = shapes;
            DropDownList2.DataSource = points;
            DropDownList1.DataBind();
            DropDownList2.DataBind();
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        show_pictures();
    }

    private void show_pictures()
    {
        string s = DropDownList1.SelectedValue;
        string p = DropDownList2.SelectedValue;
        msg.Text += string.Format("<img src='poker/{0}{1}.gif' />", p, s);
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        show_pictures();
    }
}