using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maill.UsersClasses
{


    public class InfoEmailSending
    {
        public InfoEmailSending(string smtpClientAdress,
        StringPair emailAdressfrom,
        StringPair emailAdressTo, 
        string emailPassword,
        string subject, string body)
        {
            SmtpClientAdress = smtpClientAdress ?? throw new ArgumentNullException(nameof(smtpClientAdress));
            EmailAdressfrom = emailAdressfrom ?? throw new ArgumentNullException(nameof(emailAdressfrom));
            EmailAdressTo = emailAdressTo ?? throw new ArgumentNullException(nameof(emailAdressTo));
            EmailPassword = emailPassword ?? throw new ArgumentNullException(nameof(emailPassword));
            Subject = subject ?? throw new ArgumentNullException(nameof(subject));
            Body = body ?? throw new ArgumentNullException(nameof(body));
        }

        public string SmtpClientAdress { get; set; }
        public StringPair EmailAdressfrom { get; set; }
        public StringPair EmailAdressTo { get; set; }
        public string EmailPassword { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }


    }
}
