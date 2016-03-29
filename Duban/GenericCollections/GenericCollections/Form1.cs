using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace GenericCollections
{
    public partial class Form1 : Form
    {

        /// </summary>
        Stack<string> order = new Stack<string>();
        Dictionary<string, string> clientes = new Dictionary<string, string>();
        string line;
        string[] pairs = new string[2];
        public Form1()
        {
            InitializeComponent();
        }        

        private void SendMail(string WindowsFormsApplication1,  string item)
        {
            int i =0;
            var fromAddress = new MailAddress("duban.rojas@yuxipacific.com");
            var toAddress = new MailAddress(WindowsFormsApplication1);
            const string fromPassword = "drkafka07";
            const string subject = "Subject";
            i++;
            string body = "HI, your order will be delivered in " + i + " days, its content " + item;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {

                smtp.Send(message);
            }

        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader(@"E:\customers.txt");
            while ((line = file.ReadLine()) != null)
            {
                try
                {
                    pairs = line.Split(',');
                    clientes.Add(pairs[0], pairs[1]);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            file.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                StreamReader file = new StreamReader(@"E:\orders.txt");
                while ((line = file.ReadLine()) != null)
                {
                    pairs = line.Split(',');
                    order.Push(pairs[1]);
                }
                file.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //int i = 0;
            foreach (KeyValuePair<string, string> cliente in clientes)
            {
                //i++;
                SendMail(cliente.Key, order.Pop());
            }
            //i = 0;
        }               
    }
}
