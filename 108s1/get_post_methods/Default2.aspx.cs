using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    static int N = 3;
    static int i_no, multiplicand, multiplier;
    static int correct;
    static DateTime start;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (! IsPostBack)
        {
            myinit();
            nextq();
        }
    }

    private void nextq()
    {
        Random generator = new Random();
        int a = generator.Next(1, 10);
        int b = generator.Next(1, 10);
        multiplicand = 10 * a + b;
        multiplier = 10 * a + (10 - b);
        Literal1.Text = multiplicand.ToString();
        Literal2.Text = multiplier.ToString();
    }

    private void myinit()
    {
        i_no = 0;
        correct = 0;
        start = DateTime.Now;
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        int guess = Convert.ToInt16(TextBox1.Text);
        if (guess == multiplicand * multiplier)
        {
            msg.Text += string.Format("{0}*{1}={2}==>答對了!", multiplicand, multiplier, guess);
        } else
        {
            msg.Text += string.Format("{0}*{1}={2}==>答對了! 應該是{3}", multiplicand, multiplier, guess, multiplicand*multiplier);
        }

    }
}