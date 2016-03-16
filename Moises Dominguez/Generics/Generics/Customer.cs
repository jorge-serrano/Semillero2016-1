using System.Collections.Generic;

namespace Generics
{
    class Customer
    {
        public int customerId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public Stack<Order> Orders { get; set; }
        public Customer()
        {
            Orders = new Stack<Order>();
        }
    }
}
