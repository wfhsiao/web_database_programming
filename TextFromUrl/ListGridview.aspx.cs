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
        if (IsPostBack)
        {
            SqlDataSource2.SelectCommand = "SELECT * FROM [" + ListBox1.SelectedItem.Text + "] ";
            //GridView1.DataBind();
        }
    }


    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {        
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataBind();
    }

    protected void ListBox1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        GridView1.PageIndex = 0;
        GridView1.Sort("", SortDirection.Ascending);
        SqlDataSource2.SelectCommand = "SELECT * FROM [" + ListBox1.SelectedItem.Text + "] ";
        GridView1.DataBind();
    }
}