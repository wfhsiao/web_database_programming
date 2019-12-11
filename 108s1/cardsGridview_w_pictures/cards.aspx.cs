using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cards : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string[] shapes = { "s", "h", "d", "c" };
        string[] points = { "a", "2", "3", "4", "5", "6", "7", "8", "9", "t", "j", "q", "k" };
        Random r = new Random();
        for (int i=0; i<shapes.Length; i++) 
            for (int j=0; j<points.Length; j++)
            {
                int score = r.Next(0, 30);
                string sql = string.Format("insert into [playcards] values ('{0}', '{1}', {2})", shapes[i], points[j], score);

                try
                {
                    SqlDataSource1.InsertCommand = sql;
                    SqlDataSource1.Insert();
                }
                catch (Exception ex)
                {

                    Response.Output.Write("insertion error: {0}, sql={1}", ex.Message, sql);
                }
                
            }
        GridView1.DataBind();
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.DataItem == null) return;
        DataRowView row = (DataRowView)e.Row.DataItem;
        Label lbl = (Label)e.Row.FindControl("lblshape");
        DropDownList ddl = (DropDownList)e.Row.FindControl("ddlPt");
        if (lbl != null)
            lbl.Text = string.Format("<a href='http://www.google.com.tw/search?q={0}'>{1}</a>", row["shape"], row["shape"]);
        else if (ddl != null)
        {
            Init(ddl);
            ddl.SelectedValue = row["point"].ToString();
        }
    }

    private void Init(DropDownList ddl)
    {
        string[] points = { "a", "2", "3", "4", "5", "6", "7", "8", "9", "t", "j", "q", "k" };
        ddl.DataSource=  points;
        ddl.DataBind();
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        DropDownList ddl = (DropDownList)GridView1.Rows[e.RowIndex].FindControl("ddlPt");
        SqlDataSource2.UpdateParameters["point"].DefaultValue = ddl.SelectedValue;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlDataSource1.DeleteCommand = "delete from [playcards]";
        SqlDataSource1.Delete();
        GridView1.DataBind();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlDataSource1.UpdateCommand = "if exists (select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME='playcards') begin drop table playcards end";
        SqlDataSource1.Update();
        SqlDataSource1.UpdateCommand = "CREATE TABLE [dbo].[playcards] ( " + "    [Id] INT NOT NULL PRIMARY KEY IDENTITY, " +
            "    [shape] CHAR NOT NULL, " + "    [point] CHAR NOT NULL, " + "    [score] INT NOT NULL DEFAULT 0 )";
        SqlDataSource1.Update();
        GridView1.DataBind();
    }
}