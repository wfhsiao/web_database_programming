using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyListItem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (! IsPostBack)
        {
            string[] names = { "紅", "橙", "黃", "綠", "藍", "靛", "紫" };
            string[] colors = { "red", "orange", "yellow", "green", "blue", "indigo", "purpose" };

            //for (int i = 0; i < names.Length; i++)
            //{
            //    DropDownList1.Items.Add(new ListItem(names[i], colors[i]));
            //}
            //DropDownList1.Items.Insert(0, new ListItem("黑", "black"));
            DropDownList1.DataSource = getDataSource(names, colors);
            DropDownList1.DataTextField = "key";
            DropDownList1.DataValueField = "value";
            DropDownList1.DataBind();
            body1.Attributes.Add("bgcolor", DropDownList1.SelectedValue);
        }
    }

    private DataTable getDataSource(string[] keys, string[] values)
    {
        DataTable dt = new DataTable();
        DataColumn c1 = new DataColumn("key", Type.GetType("System.String"));
        DataColumn c2 = new DataColumn("value", Type.GetType("System.String"));
        dt.Columns.Add(c2);
        dt.Columns.Add(c1);
        for (int i = 0; i < keys.Length; i++)
        {
            DataRow r = dt.NewRow();
            r["key"] = keys[i];
            r["value"] = values[i];
            dt.Rows.Add(r);
        }

        return dt;
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        body1.Attributes.Add("bgcolor", DropDownList1.SelectedValue);
    }
}