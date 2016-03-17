using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Generics
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string Mail { get; set; }

        public string Name { get; set; }

        public Stack<Order> Orders { get; set; }

        public Customer()
        {
            Orders = new Stack<Order>();

        }
        public List<Customer> GetCustomers(string folderName)
        {
            var file = OpenFile(folderName, "customers.txt");
            var customersList = new List<Customer>();
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                if (line.Length < 1)
                    break;
                string[] fields = line.Split(',');
                if (customersList == null)
                    continue;
                customersList.Add(new Customer()
                {
                    CustomerId = int.Parse(fields[0]),
                    Mail = fields[1],
                    Name = fields[2]
                });
            }
            return customersList;
        }
      
        private StreamReader OpenFile(string folderName, string fileName)
        {
            return File.OpenText(folderName + "\\" + fileName);
        }
    }
}
