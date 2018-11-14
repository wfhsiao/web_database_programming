using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ReadWriteCards : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string[] s = { "s", "h", "d", "c" };
        string[] p = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K" };

        for (int i=0; i<s.Length; i++)
        {
            for (int j=0; j<p.Length; j++)
            {
                SqlDataSource1.InsertCommand = String.Format("insert into cards values ('{0}', '{1}', 0)", s[i], p[j]);
                SqlDataSource1.Insert();
            }
        }
        
    }
}