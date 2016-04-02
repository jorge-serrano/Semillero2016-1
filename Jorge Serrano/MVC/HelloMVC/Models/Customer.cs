using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloMVC.Models
{
    public class Customer
    {
        public Customer()
        {
            Details = new List<CustomerDetail>();
        }
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public ICollection<CustomerDetail> Details { get; set; }


    }
}