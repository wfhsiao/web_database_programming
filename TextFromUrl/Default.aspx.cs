using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Microsoft.VisualBasic.FileIO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlDataSource1.InsertCommand = "if not exists(select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'words') begin "
                + "CREATE TABLE[dbo].[words](" + "[Id] INT IDENTITY(1, 1) NOT NULL primary key," + "[word] VARCHAR(200)  NOT NULL,"
                + "[ch_explanation] NVARCHAR(MAX) NOT NULL," + "); end";
            SqlDataSource1.Insert();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlDataSource1.DeleteCommand = "delete from [words]";
        SqlDataSource1.Delete();
        SqlDataSource1.DeleteCommand = "drop table[words]";
                SqlDataSource1.Delete();
                SqlDataSource1.InsertCommand = "if not exists(select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'words') begin "
            + "CREATE TABLE[dbo].[words](" + "[Id] INT IDENTITY(1, 1) NOT NULL primary key," + "[word] VARCHAR(200)  NOT NULL,"
            + "[ch_explanation] NVARCHAR(MAX) NOT NULL," + "); end";
                SqlDataSource1.Insert();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        string url = "http://einstein.nptu.edu.tw:9212/sources/datastructure/StudentWebs/data/somewords.csv";
        WebRequest webReq = WebRequest.Create(url);
        WebResponse webRes = webReq.GetResponse();
        Stream webStream = webRes.GetResponseStream();

        TextFieldParser csvParser = new TextFieldParser(webStream, Encoding.GetEncoding("Big5")) //need to refer visual basic
        {
            Delimiters = new string[] { "," },
            TrimWhiteSpace = true
        };
        // skip the header
        //csvParser.ReadLine();
        //int item_field = 1;
        while (!csvParser.EndOfData)
        {
            string[] str = csvParser.ReadFields();
            string sqlcmd = string.Format("insert into [words] values('{0}',N'{1}')", str[0].Replace("'", "''"), str[1].Replace("'", "''"));
            try
            {
                SqlDataSource1.InsertCommand = sqlcmd;
                SqlDataSource1.Insert();
            }
            catch(Exception ex)
            {
                Response.Write(ex);
            }
        }
    }
}