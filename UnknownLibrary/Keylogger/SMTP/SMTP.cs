using System;
using System.Net;
using System.Net.Mail;

namespace UnknownLibrary.SMTP
{
    public static class SMTP
    {
        public static void SendMail(string EMailFrom, string EMailTo, string SMTPServer, string SMTPPort, string Password, string Subject, string Body)
        {
            using (MailMessage mailMessage = new MailMessage())
            {
                mailMessage.From = new MailAddress(EMailFrom);
                mailMessage.To.Add(EMailTo);
                mailMessage.Subject = Subject;
                mailMessage.Body = Body;
                mailMessage.IsBodyHtml = false;

                using (SmtpClient SMTP = new SmtpClient(SMTPServer, Convert.ToInt16(SMTPPort)))
                {
                    SMTP.UseDefaultCredentials = false;
                    SMTP.Credentials = new NetworkCredential(EMailFrom, Password);
                    SMTP.EnableSsl = true;
                    SMTP.Send(mailMessage);
                }
            }
        }
    }
}
