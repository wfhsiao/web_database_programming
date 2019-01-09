針對期末考第二題insert資料至資料表的語法:<br />
string sql = String.Format("insert into [outputwords] values('{0}', N'{1}', N'{2}', '{3}', {4})", str[0].Replace("'", "''"), str[1].Replace("'", "''"), str[2].Replace("'", "''"), DateTime.Today.ToString("d"), r.Next(1,6));
<br /><br />
DetailsView比GridView方便, 它在編輯狀態下的DropDownList會自動停在對應的值, 更新時亦不用另外處理.<br />
故DetailsView的所有方法如下:<br />
<pre class="prettyprint lang-csharp">
    protected void DetailsView1_DataBound(object sender, EventArgs e)
    {        
        Label lbl = (Label)DetailsView1.FindControl("lblWord");
        //DropDownList ddl = (DropDownList)e.Row.FindControl("ddlShape");
        if (lbl != null)
            lbl.Text = "<a href='http://www.google.com.tw/search?q=" + lbl.Text + "'>" + lbl.Text + "</a>";
        
    }

    protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
    {
        GridView1.DataBind();
    }

    protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
    {
        GridView1.DataBind();
    }
 </pre>
