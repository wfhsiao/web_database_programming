using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GeneratingDS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection myConn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
        string sqlStr = "select * from words";
        SqlDataAdapter myCommand = new SqlDataAdapter(sqlStr, myConn); // 'sqlStr is a plain select columns from table where ...
        DataSet ds = new DataSet();
        myCommand.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
}