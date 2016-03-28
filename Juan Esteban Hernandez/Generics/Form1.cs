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
        private Dictionary<string,string> customers;
        private Stack<Order> orders;
 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string,string> customer in customers)
            {
                            var currentOrder = orders.Pop();
                            Messenger msg = new Messenger();
                            msg.SendMessage(customer.Key, CreateMessage(currentOrder));
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
            TextFileDataAccess data = new TextFileDataAccess();
            try
            {
                customers = data.GetCustomers(@"C:\Semillero\Labs\Semillero2016-1\Juan Esteban Hernandez\Generics\Properties\DataSources");
            }
            catch (Exception)
            {

                lblError.Visible = true;
                lblError.Text = "Error loading the dictionary, the email needs to be unique";
            } 
            orders = data.GetOrders(@"C:\Semillero\Labs\Semillero2016-1\Juan Esteban Hernandez\Generics\Properties\DataSources");
            //customerBindingSource.DataSource = customers;
            //var clients = ;
            var customer = from row in customers select new { Mail = row.Key, Name = row.Value };
            dgCustomers.DataSource = customer.ToArray();
            orderBindingSource.DataSource = orders;

        }

        private void customerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dgCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
