using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

public partial class EmailSend : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        MailMessage mail = new MailMessage();
        mail.To.Add(txtto.Text);
        mail.From = new MailAddress(txtfrom.Text);
        mail.Subject = txtsub.Text;
        string Body = txtmsg.Text;
        mail.Body = Body;
        mail.IsBodyHtml = true;
        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.Credentials = new System.Net.NetworkCredential(txtfrom.Text, txtpass.Text);
        smtp.EnableSsl = true;
        smtp.Send(mail);
    }
}