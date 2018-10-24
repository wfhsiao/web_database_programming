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
        string str="飄飄然的, 必定地不變地, 不識字的, 鋪張的奢華的, 不停的, 致命的, 現職的, 可獲利的, 憤憤不平的, 可笑的滑稽的, 固有的, 懷惡意的, 首度的, 煞有其事的, 必須的不可或缺的, 世俗的, 複雜的, 可選擇的, 無效的作廢的, 長期間持續的";
        string[] chistr = str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Response.Write(chistr.Length);

        string[] eng = { "heady", "invariably", "illiterate", "lavish", "incessant", "lethal", "incumbent", "lucrative", "indignant", "ludicrous", "inherent", "malicious", "initial", "mock", "integral", "mundane", "intricate", "optional", "invalid", "perennial" };
        Response.Write("<br />");
        Response.Write(eng.Length);
    }
}