using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class sendEmail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string server = "mail.nptu.edu.tw";
        MailMessage message = new MailMessage("wfhsiao@mail.nptu.edu.tw", "wfhsiao@gmail.com", "Test send mail from aspnet", "Hello!");
        SmtpClient mailClient = new SmtpClient();

        mailClient.Host = server;
        mailClient.Send(message);
        message.Dispose();
    }
}