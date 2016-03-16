using System.Collections.Generic;
using System.IO;

namespace Generics
{
    class DataAccess
    {
        public List<Customer> GetCustomers(string folderName)
        {
            var file = OpenFile(folderName, "customers.txt");
            var customersList = new List<Customer>();
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                string[] fields = SplitLine(line);
                if (customersList.Exists(x=>x.Email==fields[1]))
                    continue;
                customersList.Add(new Customer()
                {
                    customerId = int.Parse(fields[0]),
                    Email = fields[1],
                    Name = fields[2]
                });
            }
            return customersList;
        }
        public List<Order> GetOrders(string folderName)
        {
            var file = OpenFile(folderName, "orders.txt");
            var ordersList = new List<Order>();
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                string[] fields = SplitLine(line);
                ordersList.Add(new Order()
                {
                    Quantity = short.Parse(fields[0]),
                    Description = fields[1],
                    Deadline = short.Parse(fields[2])
                });
            }
            return ordersList;
        }
        private string[] SplitLine(string line)
        {
            return line.Split(',');
        }
        private StreamReader OpenFile(string folderName, string fileName)
        {
            return File.OpenText(folderName + "\\" + fileName);
        }
    }
}