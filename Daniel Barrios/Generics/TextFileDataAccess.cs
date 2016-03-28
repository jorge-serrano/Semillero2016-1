using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Generics
{
    public class TextFileDataAccess : IDataAccess
    {
        string line;
        /// <summary>
        /// Get the list of customers from a text file
        /// </summary>
        /// <param name="folderName">full path of the folder taht contains the txt file</param>
        /// <returns></returns>
        public List<Customer> GetCustomers(string folderName)    
        {
            var file = OpenFile(folderName, "customers.txt");
            var customersList = new List<Customer>();
            while (!file.EndOfStream)
            {
                line = file.ReadLine();
                if(line.Length <1)
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
        public List<Order> GetOrders(string folderName)
        {
            var file = OpenFile(folderName, "orders.txt");
            var ordersList = new List<Order>();
            while (!file.EndOfStream)
            {
                line = file.ReadLine();
                string[] fields = line.Split(',');
                
                ordersList.Add(new Order()
                {
                    Quantity = short.Parse(fields[0]),
                    ProductDescription = fields[1]
                });
            }
            return ordersList;
        }

        private StreamReader OpenFile(string folderName, string fileName)
        {
            return File.OpenText(folderName + "\\" + fileName);
        }
    }
}
