using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListGridview : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlDataSource2.SelectCommand = "SELECT * FROM [" + ListBox1.SelectedItem.Text + "] ";
        GridView1.DataBind();
    }
}