using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyImageButton : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Random r = new Random();
        int v = r.Next(0, 52);
        string[] s = { "s", "h", "d", "c" };
        string[] p = { "a", "2", "3", "4", "5", "6", "7", "8", "9", "t", "j", "q", "k" };

        ImageButton1.ImageUrl = String.Format("~/poker/{0}{1}.bmp", p[v % 13], s[v / 13]);
        Response.Write(v);
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Output.Write("({0},{1})<br>", e.X, e.Y);
    }
}