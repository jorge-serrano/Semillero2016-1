using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
namespace Generics
{
    public class Order
    {
        public short Quantity { get; set; }

        public string ProductDescription { get; set; }

        public List<Order> GetOrders(string folderName)
        {
            var file = OpenFile(folderName, "orders.txt");
            var ordersList = new List<Order>();
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
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
