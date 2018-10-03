using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            myInit();
            nextQ();
        }
    }

    private void myInit()
    {
        Session["correct"] = 0;
        Session["current"] = 0;
    }

    private void nextQ()
    {
        Random r = new Random();
        int a = r.Next(1, 10);
        int b = r.Next(1, 10);
        Session["number1"] = 10 * a + b;
        Session["number2"] = 10 * a + (10 - b);
        num1.Text = Session["number1"].ToString();
        num2.Text = Session["number2"].ToString();
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        int ans = int.Parse(TextBox1.Text);
        int number1 = int.Parse(Session["number1"].ToString());
        int number2 = int.Parse(Session["number2"].ToString());
        int correct = int.Parse(Session["correct"].ToString());
        if (number1 * number2 == ans)
        {
            msg.Text += string.Format("{0} * {1} = {2} 答對了！<br />", number1, number2, ans);
            correct += 1;
            Session["correct"] = correct ;
        }
        else
            msg.Text += string.Format("{0} * {1} = {2} 答錯了！ 正确答案是{3} <br />", number1, number2, ans, number1 * number2);

        int current = int.Parse(Session["current"].ToString()) + 1;
        Session["current"] = current ;
        if (current==3)
        {
            msg.Text += string.Format("得分：{0}, <a href='{1}'>重玩</a>", 100 * correct / current, System.IO.Path.GetFileName(System.Web.HttpContext.Current.Request.Url.AbsolutePath));
        } else
        {
            TextBox1.Text = "";
            nextQ();
        }
    }
}