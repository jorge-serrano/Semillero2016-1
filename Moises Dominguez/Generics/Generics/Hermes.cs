using System;
using System.Net;
using System.Net.Mail;

namespace Generics
{
    class Hermes
    {
        readonly SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587);
        public Hermes()
        {
            mailClient.Credentials = new NetworkCredential("moises.dominguez@yuxipacific.com", "Password$4");
            mailClient.EnableSsl = true;
        }
        public bool SendMessage(string AddressTo, string MessageToSend)
        {
            MailMessage message = new MailMessage("moises.dominguez@yuxipacific.com", AddressTo, "Your Order is ready", MessageToSend);
            try {
                mailClient.Send(message);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
