using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int cnt = (int)Session["cnt"];
        Session["cnt"] = cnt + 1;
        msg.Text += String.Format("{0}: Page_Load<br />", Session["cnt"]);
    }

    // preinit, load, prerender, unload
    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (! IsPostBack) Session["cnt"] = 0;
        msg.Text += ("Page_PreInit<br />");
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        int cnt = (int)Session["cnt"];
        Session["cnt"] = cnt+1;
        msg.Text += String.Format("{0}: Page_PreRender<br />", Session["cnt"]);
    }

    protected void Page_UnLoad(object sender, EventArgs e)
    {
        //int cnt = (int)Session["cnt"];
        //Session["cnt"] = cnt + 1;
        msg.Text += String.Format("{0}: Page_UnLoad <br />", Session["cnt"]);
    }
}