using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generics
{
    public partial class Form1 : Form
    {
        private List<Customer> customers;
        private List<Order> orders;
 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Customer customer in customers)
            {
                foreach (Order order in orders)
                    customer.Orders.Push(order);
                while (customer.Orders.Count > 0)
                {
                    var currentOrder = customer.Orders.Pop();
                    Messenger msg = new Messenger();
                    msg.SendMessage(customer.Mail, CreateMessage(currentOrder));
                }
            }
        }

        private string CreateMessage(Order currentOrder)
        {
            return "Your Order " +
                   currentOrder.ProductDescription + Environment.NewLine +
                   "Will be sent soon";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Customer data = new Customer();
            customers = data.GetCustomers(@"D:\ForkJorge\Semillero2016-1\YessicaG\Generics\Dates");
            Order data2 = new Order();
            orders = data2.GetOrders(@"D:\ForkJorge\Semillero2016-1\YessicaG\Generics\Dates");
            customerBindingSource.DataSource = customers;
            orderBindingSource.DataSource = orders;

        }
    }
}
