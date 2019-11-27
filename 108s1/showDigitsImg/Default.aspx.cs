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
            int[] cs = { 1, 11, 111, 1111 };
            int[] ds = { 9, 19, 29 };
            DropDownList1.DataSource = cs;
            DropDownList2.DataSource = ds;
            DropDownList1.DataBind();
            DropDownList2.DataBind();
            doTimes();

            string c = Request["c"];
            string d = Request["d"];
            if (c != null && d != null)
            {
                DropDownList1.Visible = false;
                DropDownList2.Visible = false;
                int cv = Convert.ToInt32(c);
                int dv = Convert.ToInt32(d);
                long res = cv * dv;
                Literal1.Text = string.Format("{0} x {1} = {2}", cv, dv, res);
                showImages(Literal1.Text);
            }
        }
    }

    private void showImages(string text)
    {
        string res = "<br />";
        char[] cs = text.ToCharArray();
        for (int i=0; i<cs.Length; i++)
        {
            if (cs[i]>='0' && cs[i]<='9')
            {
                res += string.Format("<img src='images/{0}.gif' />", cs[i]);
            } else
            {
                res += cs[i];
            }
        }
        Literal1.Text += res;
    }

    private void doTimes()
    {
        int cv = Convert.ToInt32(DropDownList1.SelectedValue);
        int dv = Convert.ToInt32(DropDownList2.SelectedValue);
        long res = cv * dv;
        Literal1.Text = string.Format("{0} x {1} = {2}", cv, dv, res);
        showImages(Literal1.Text);
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        doTimes();
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        doTimes();
    }
}