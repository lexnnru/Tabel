using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using TabelLibrary.Data;

namespace TabelLibrary
{
   public class SendMail
    {
        public string Error { get; private set; }
        public bool Send (MailSet mailset)
        {
            Error = "";
            try
            {
                using (MailMessage mail = new MailMessage(mailset.from, mailset.to, mailset.subject, mailset.message))
                {
                    mail.Attachments.Add(new Attachment(mailset.fileforsend));
                    SmtpClient client = new SmtpClient(mailset.smtp);
                    client.Port = 587;
                    client.Credentials = new System.Net.NetworkCredential(mailset.username, mailset.password);
                    client.EnableSsl = true;
                    client.Send(mail);
                    mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
                    mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                }
                return true;
            }
            catch (Exception q)
            {
                Error = q.Message;
                return false;
            }

        }

        }
}
