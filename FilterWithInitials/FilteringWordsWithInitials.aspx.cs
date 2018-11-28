using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FilteringWordsWithInitials : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void GridView1_DataBound(object sender, EventArgs e)
    {
        DataView dv = (DataView)SqlDataSource1.Select(new DataSourceSelectArguments());
        Literal1.Text = "符合上面條件的資料共有: " + dv.Count + " 筆.";
    }
}