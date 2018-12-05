using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ReadWriteCards : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string[] s = { "s", "h", "d", "c" };
        string[] p = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K" };

        for (int i=0; i<s.Length; i++)
        {
            for (int j=0; j<p.Length; j++)
            {
                SqlDataSource1.InsertCommand = String.Format("insert into cards values ('{0}', '{1}', 0)", s[i], p[j]);
                SqlDataSource1.Insert();
            }
        }
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlDataSource1.DeleteCommand = "delete from cards ";
        SqlDataSource1.Delete();
    }

    protected void GridView1_DataBound(object sender, EventArgs e)
    {
        DataView dv = (DataView)SqlDataSource1.Select(new DataSourceSelectArguments());
        Literal1.Text = "符合上面條件的資料共有: " + dv.Count + " 筆.";
    }

    protected void DropDownList1_DataBound(object sender, EventArgs e)
    {
        DropDownList1.Items.Insert(0, new ListItem("All shapes", "%"));
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.DataItem == null) return;
        Label lbl = (Label) e.Row.FindControl("lblShape");
        DropDownList ddl = (DropDownList) e.Row.FindControl("ddlShape");
        if (lbl != null)
            lbl.Text = "<a href='http://www.google.com.tw/search?q=" + lbl.Text + "'>" + lbl.Text + "</a>";
        else if (ddl != null) {
            DataRowView row = (DataRowView)e.Row.DataItem;
            ddl.SelectedValue = (string) row["shape"];
        }
    
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        DropDownList ddl = (DropDownList) GridView1.Rows[e.RowIndex].FindControl("ddlShape");
        SqlDataSource1.UpdateParameters["shape"].DefaultValue = ddl.SelectedValue;
    }
}