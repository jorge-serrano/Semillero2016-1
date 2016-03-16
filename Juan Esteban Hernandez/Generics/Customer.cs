using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Customer
    {
       //public  CustomerId { get; set; }

        public string Mail { get; set; }

        public string  Name{ get; set; }

        public Stack<Order> Orders { get; set; }

        public Customer()
        {
            Orders = new Stack<Order>();
        }
    }
}
