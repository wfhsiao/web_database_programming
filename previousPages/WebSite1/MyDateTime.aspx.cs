using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyDateTime : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DateTime d = DateTime.Today;
        Response.Write((int)d.DayOfWeek);
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        //msg.Text = Calendar1.SelectedDate.ToString("d");
        DateTime d = Calendar1.SelectedDate;
        for (int i = 0; i < 7; i++)
        {                     
            if ((int)d.AddDays(-i).DayOfWeek == 3)
            {
                msg.Text += string.Format("<a href='{0}'>CNN {1}</a><br />", getUrl(d.AddDays(-i)), d.AddDays(-i).ToString("d"));
                d = d.AddDays(-i);
                RadioButtonList1.Items.Add(d.ToString("d"));
                break;
            }
        }

        for (int i = 0; i < 9; i++)
        {
            d = d.AddDays(-7);
            msg.Text += string.Format("<a href='{0}'>CNN {1}</a><br />", getUrl(d), d.ToString("d"));
            RadioButtonList1.Items.Add(d.ToString("d"));
        }

    }

    private string getUrl(DateTime d)
    {
        string res = "http://www.liveabc.com/epaper/cnn/{0}/{1:00}/{2:00}/paper.asp";
        int year = d.Year;
        int month = d.Month;
        int day = d.Day;
        res = string.Format(res, year, month, day);
        return res;
    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DateTime d = DateTime.Parse(RadioButtonList1.SelectedValue);
        Response.Redirect(getUrl(d));
    }
}