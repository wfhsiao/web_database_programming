# 108學年第一學期 網頁與資料庫 課堂練習程式
<pre>
   protected void Button2_Click(object sender, EventArgs e)
    {
        SqlDataSource1.DeleteCommand = "delete from [playcards]";
        SqlDataSource1.Delete();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string[] shapes = { "s", "h", "d", "c" };
        string[] points = { "a", "2", "3", "4", "5", "6", "7", "8", "9", "t", "j", "q", "k" };
        string insert_sql = "insert into [playcards]([shape], [point]) values";
        string sql = "";
        foreach (string s in shapes)
        {
            foreach (string p in points)
            {
                if (sql == "")
                    sql = insert_sql;
                else
                    sql += ",\n";
                sql += string.Format("('{0}', '{1}')", s, p);
            }
        }

        try
        {
            SqlDataSource1.InsertCommand = sql;
            SqlDataSource1.Insert();            
        }
        catch (Exception ex)
        {
            Response.Output.Write("insertion error: {0}, sql={1}", ex.Message, sql);            
        }        

    }

    protected void DropDownList1_DataBound(object sender, EventArgs e)
    {
        DropDownList1.Items.Insert(0, new ListItem("請選擇花色", "%"));
    }

    protected void DropDownList2_DataBound(object sender, EventArgs e)
    {
        DropDownList2.Items.Insert(0, new ListItem("請選擇點數", "%"));
    }

    protected void GridView1_DataBound(object sender, EventArgs e)
    {
        DataView dv = (DataView)SqlDataSource1.Select(new DataSourceSelectArguments());
        Literal1.Text = "符合上面條件的資料共有: " + dv.Count + " 筆.";
        
    }</pre>
