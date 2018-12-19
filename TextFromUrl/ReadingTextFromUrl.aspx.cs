using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ReadingTextFromUrl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string url = "http://einstein.nptu.edu.tw:9212/sources/datastructure/StudentWebs/data/somewords.csv";
        WebRequest webReq = WebRequest.Create(url);
        WebResponse webRes = webReq.GetResponse();
        StreamReader reader = new StreamReader(webRes.GetResponseStream(), Encoding.GetEncoding("Big5"));
        while (reader.Peek() != -1)
        {
            //Response.Write(reader.ReadLine() & "<br/>") 
            string[] line = reader.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string t in line)
                Response.Write(String.Format("({0})  ", t));
            Response.Write("<br />");
        }
        reader.Close();
    }
}