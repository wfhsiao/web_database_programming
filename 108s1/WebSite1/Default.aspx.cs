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
            for (int i = 1; i <=12; i++)
            {
                DropDownList1.Items.Add(i.ToString());
            }
            
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Literal1.Text += string.Format("你輸入了{0}<br />", TextBox1.Text);
        TextBox1.Focus();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Literal2.Text += string.Format("你選的日期是: {0:d}<br />", Calendar1.SelectedDate);
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        myUpdate();
    }


    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        myUpdate();
    }

    private void myUpdate()
    {        
        // stateless
        Calendar1.SelectedDate = new DateTime(Convert.ToInt16(TextBox2.Text), Convert.ToInt16(DropDownList1.SelectedValue), 1);
        Calendar1.VisibleDate = Calendar1.SelectedDate;
        TextBox2.Focus();
    }
}