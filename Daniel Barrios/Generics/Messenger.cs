using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Generics
{
    public class Messenger
    {
        readonly SmtpClient mailClient = new SmtpClient("smtp.gmail.com",587);

        public Messenger()
        {
            mailClient.Credentials = new NetworkCredential("yegs95@gmail.com","matias1995");
            //mailClient.UseDefaultCredentials = false;
            mailClient.EnableSsl = true;
        }
        public bool SendMessage(string AddressTo, string MessageToSend)
        {
            MailMessage message = new MailMessage("yegs95@gmail.com",AddressTo,"Your Order is ready",MessageToSend);
            mailClient.Send(message);
            return true;
        }
    }
}
