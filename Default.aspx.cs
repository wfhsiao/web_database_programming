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
        string [] colors = { "pink", "red", "orange", "yellow", "green", "blue" };
        if (! IsPostBack)
        {
            DropDownList1.DataSource = colors;
            DropDownList1.DataBind();
            mybody.Attributes["bgcolor"] = colors[0];
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        mybody.Attributes["bgcolor"] = DropDownList1.SelectedValue;
    }
}