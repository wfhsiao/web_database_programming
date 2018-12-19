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
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlDataSource1.DeleteCommand = "delete from [phrases]";
        SqlDataSource1.Delete();
    }

    protected void Button1_Click(object sender, EventArgs e)
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
        csvParser.ReadLine();
        //int item_field = 1;
        while (!csvParser.EndOfData)
        {
            string[] str = csvParser.ReadFields();
            string sql = String.Format("insert into [phrases] values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", str[0].Replace("'", "''"), str[1].Replace("'", "''"), str[2].Replace("'", "''"), str[3].Replace("'", "''"), str[4].Replace("'", "''"), str[5]);
            try
            {
                SqlDataSource1.InsertCommand = sql;
                SqlDataSource1.Insert();
            }
            catch (Exception ex)
            {
                Response.Output.Write("error: {0}, sql={1}<br/>", ex.Message, sql);

            }
                

        }
    }
}