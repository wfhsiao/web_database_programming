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
        //int A = 3;
        //int B = 12;
        //Response.Output.Write("Hello {1}: {0}<br />", A, B); // slot filling
        //Circle c1 = new Circle();
        //Response.Write(c1);
        if (! IsPostBack)
        {
            string[] colors = { "red", "orange", "yellow", "green", "blue", "indigo", "purple" };
            DropDownList1.DataSource = colors;
            DropDownList1.DataBind();
        }
        

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int score = Convert.ToInt16(TextBox1.Text);
        switch (score / 10)
        {
            case 10:
            case 9:Response.Write("優等");
                break;
            case 8:Response.Write("甲等");
                break;
            case 7:Response.Write("乙等");
                break;
            case 6:Response.Write("丙等");
                break;
            default:Response.Write("不及格");
                break;
        }         
                    

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        mybody.Attributes["bgcolor"] = DropDownList1.SelectedValue;
    }
}

class Circle
{
    override public string ToString()
    {
        return "I'm a circle.";
    }
}