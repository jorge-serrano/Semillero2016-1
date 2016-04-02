using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloMVC.Models
{
    public class CustomerDetail
    {

        public int CustomerDetailId { get; set; }

        public int CustomerId { get; set; }

        public string Email { get; set; }

       public virtual Customer Customer { get; set; }

    }
}