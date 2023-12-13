using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace maill.UsersClasses
{
    public class SendingEmail
    {
        public SendingEmail(InfoEmailSending infoEmailSending)
        {
            InfoEmailSending = infoEmailSending ?? throw new ArgumentNullException(nameof(infoEmailSending));
        }

        private InfoEmailSending InfoEmailSending { get; set;}

        public void Send() 
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient(InfoEmailSending.SmtpClientAdress);

                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = true;

                NetworkCredential basicAuthenticationInfo = new NetworkCredential(InfoEmailSending.EmailAdressfrom.EmailAdress,
                InfoEmailSending.EmailPassword);

                smtpClient.Credentials = basicAuthenticationInfo;

                MailAddress from = new MailAddress(InfoEmailSending.EmailAdressfrom.EmailAdress,
                InfoEmailSending.EmailAdressfrom.Name);

                MailAddress to = new MailAddress(InfoEmailSending.EmailAdressTo.EmailAdress,
                InfoEmailSending.EmailAdressTo.Name);

                MailMessage mailMessage = new MailMessage(from, to);

                MailAddress replyTo = new MailAddress(InfoEmailSending.EmailAdressfrom.EmailAdress);
                mailMessage.ReplyToList.Add(replyTo);

                Encoding encoding = Encoding.UTF8;

                mailMessage.Subject = InfoEmailSending.Subject;
                mailMessage.SubjectEncoding = encoding;

                mailMessage.Body = InfoEmailSending.Body;
                mailMessage.BodyEncoding = encoding;

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }

        }
    }
}
