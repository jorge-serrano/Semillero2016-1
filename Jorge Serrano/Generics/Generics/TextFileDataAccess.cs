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
        /// <summary>
        /// Get the list of customers from a text file
        /// </summary>
        /// <param name="folderName">full path of the folder taht contains the txt file</param>
        /// <returns></returns>
        public List<Customer> GetCustomers(string folderName)
        {
            var file = OpenFile(folderName, "customers.txt");
            var customersList = new List<Customer>();
            var validator = new Dictionary<string,bool>();
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                if(line.Length <1)
                    break;
                string[] fields = SplitLine(line);
                if (validator.ContainsKey(fields[1]))
                   continue;
                validator.Add(fields[1],true);
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
                string line = file.ReadLine();
                string[] fields = SplitLine(line);
                
                ordersList.Add(new Order()
                {
                    Quantity = short.Parse(fields[0]),
                    ProductDescription = fields[1]
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
