using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Stack<string> pedidos = new Stack<string>();
        Dictionary<string, string> clientes = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\YUXI\Documents\clientes.txt");
            while ((line = file.ReadLine()) != null)
            {
                try
                {
                    string[] pairs = line.Split(',');
                    clientes.Add(pairs[1], pairs[0]);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            file.Close();
        
        }
         
        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (KeyValuePair<string, string> cliente in clientes)
            {
                i++;
                SendMail(cliente.Value, i, pedidos.Pop());
            }

        }

        private void SendMail(string WindowsFormsApplication1, int i, string item)
        {
            Random rnd = new Random();

            var fromAddress = new MailAddress("daniel.barrios@yuxipacific.com");//defino como variable el e-mail de donde envio el correo
            var toAddress = new MailAddress(WindowsFormsApplication1);//Correo destinatario
            const string fromPassword = "D4n13l.2016";//clave del correo que se estan enviando los otros correos
            const string subject = "Subject";
            string body = "Saludos, su pedido sera entregado en "+i+" dias, su contenido "+item;

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

        private void button2_Click(object sender, EventArgs e)
        {
            string line;
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\YUXI\Documents\pedidos.txt");
                while ((line = file.ReadLine()) != null)
                {
                    string[] pairs = line.Split(',');
                    pedidos.Push(pairs[1]);
                }
                file.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        } 
    }
}
