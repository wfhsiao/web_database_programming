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
            string[] names = { "TextBox1", "TextBox2" };
            DropDownList1.DataSource = names;
            DropDownList1.DataBind();
            string[] cs = { "item 1", "item 2", "item 3", "item 4", "item 5" };
            CheckBoxList1.DataSource = cs;
            CheckBoxList1.DataBind();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Literal1.Text = "Hello";
        TextBox1.Visible = false;
        TextBox2.Enabled = false;

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox c = (TextBox) Page.FindControl(DropDownList1.SelectedValue);
        c.Text = "Here";
    }



    protected void Button2_Click(object sender, EventArgs e)
    {
        Literal2.Text = string.Format("你輸入了:{0}", TextBox3.Text);

    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
        Button2_Click(sender, e);
    }

    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Literal2.Text = "你選了:<br />";
        for (int i = 0; i < CheckBoxList1.Items.Count; i++)
        {
            if (CheckBoxList1.Items[i].Selected)
                Literal2.Text += CheckBoxList1.Items[i] + "<br />";
        }
    }
}