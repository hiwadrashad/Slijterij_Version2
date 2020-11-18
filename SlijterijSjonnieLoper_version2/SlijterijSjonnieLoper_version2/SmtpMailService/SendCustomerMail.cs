using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace SlijterijSjonnieLoper_version2.SmtpMailService
{
    public static class SendCustomerMail
    {
        public static void SendMailToCustomer(string email, string pathfile)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("testmailopdracht@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Sjonnie's liqour store";
                mail.Body = "Dear Sir/Ma'am in the attachment you will see the approval message for your purchase";
                mail.IsBodyHtml = true;
                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(pathfile);
                mail.Attachments.Add(attachment);

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new System.Net.NetworkCredential("testmailopdracht@gmail.com", "testmail");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }
    }
}