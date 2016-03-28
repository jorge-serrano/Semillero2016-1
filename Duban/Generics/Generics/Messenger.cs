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
        {   //mailClient.UseDefaultCredentials = false;
            mailClient.Credentials = new NetworkCredential("duban.rojas@yuxipacific.com","drkafka07");
            //

            mailClient.EnableSsl = true;
        }
        public bool SendMessage(string AddressTo, string MessageToSend)
        {
            MailMessage message = new MailMessage("duban.rojas@yuxipacific.com", AddressTo, "Your Order is ready", MessageToSend);
            mailClient.Send(message);
            return true;
        }
    }
}
