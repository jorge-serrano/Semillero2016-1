using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedesSociales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            Inetwork Network;
            string network = comboBox1.Text;
            Factory factory = new Factory();
            Network = factory.CreateRequest(network);
            webBrowser1.Navigate(Network.direccion);

        }
    }
}
