using Microsoft.VisualBasic.FileIO;
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
        string url = "http://einstein.nptu.edu.tw:9212/sources/datastructure/StudentWebs/data/phrases.csv";
        WebRequest webReq = WebRequest.Create(url);
        WebResponse webRes = webReq.GetResponse();
        Stream webStream = webRes.GetResponseStream();
        TextFieldParser csvParser = new TextFieldParser(webStream, Encoding.GetEncoding("Big5"))
        {
            Delimiters = new string[] { "," },
            TrimWhiteSpace = true
        };
        // skip the header
        //csvParser.ReadLine();
        int item_field = 1;
        while (!csvParser.EndOfData)
        {
            string[] str = csvParser.ReadFields();
            for (int i = 0; i <= str.Length - 1; i++)
                Response.Output.Write("({0}) ", str[i]);

            Response.Write("<br />");
        }
    }
}