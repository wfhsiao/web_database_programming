DBPractice
內含keywords(word, ch_def, en_def)

<pre>
protected void DetailsView1_DataBound(object sender, EventArgs e)
    {
        if (DetailsView1.CurrentMode == DetailsViewMode.Edit)
        {
            if (DetailsView1.DataItem != null)
            {
                DropDownList ddl = (DropDownList)DetailsView1.FindControl("ddlRating");
                ddl.Items.Clear();
                for (int i = 0; i < 11; i++)
                    ddl.Items.Add(i.ToString());
                DataRowView row = (DataRowView)DetailsView1.DataItem;
                ddl.SelectedValue = DataBinder.Eval(row, "rating").ToString();
            }
        }
    }
</pre>
