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
            myInit();
        }
        //for (int k = 0; k < 10; k++)
        //{
        //    Response.Output.Write("{0}", k);
        //    if (k != 9)
        //        Response.Write(", ");
        //}
    }

    private void myInit()
    {
        string[,] colors = { { "紅", "red" }, { "橙", "orange" }, { "黃", "yellow" }, { "綠", "green" } };
        // string[] c_colors = { "紅", "橙", "黃", "綠" };
        for (int i = 0; i < colors.GetLength(0); i++)
        {
            DropDownList1.Items.Add(new ListItem(colors[i,0], colors[i,1]));
        }

        //foreach (string x in colors)
        //{
        //    DropDownList1.Items.Add(x);
        //}
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        mybody.Attributes["bgcolor"] = DropDownList1.SelectedValue;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int start = Convert.ToInt16(TextBox1.Text);
        int end = Convert.ToInt32(TextBox2.Text);
        long sum = mySum(start, end);
        Literal1.Text = Convert.ToString(sum);
    }

    private long mySum(int start, int end)
    {
        long sum = 0;
        for (int i = start; i <= end; i++)
        {
            sum += i;
        }
        return sum;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DropDownList1_SelectedIndexChanged(sender, e);
    }
}