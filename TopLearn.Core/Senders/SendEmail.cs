using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace TopLearn.Core.Senders
{
    public class SendEmail
    {
        public static void Send(string to, string subject, string body)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            //SmtpClient SmtpServer = new SmtpClient("testintoplearn.in");
            mail.From = new MailAddress("classicusjob@gmail.com", "تاپ لرن");
            //mail.From = new MailAddress("no-reply@testintoplearn.in", "تاپ لرن");
            mail.To.Add(to);
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;
            SmtpServer.Port = 587;
            //SmtpServer.Port = 25;
            SmtpServer.Credentials = new System.Net.NetworkCredential("classicusjob@gmail.com", "akwo oxcs qouu baxq");
            //SmtpServer.Credentials = new System.Net.NetworkCredential("no-reply@testintoplearn.in", "Xx17v@7o");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
    }
}