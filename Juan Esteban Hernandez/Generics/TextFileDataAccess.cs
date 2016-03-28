using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Generics
{
    public class TextFileDataAccess :IDataAccess
    {
        /// <summary>
        /// Get the list of customers from a text file
        /// </summary>
        /// <param name="folderName">full path of the folder taht contains the txt file</param>
        /// <returns></returns>
        public Dictionary<string,string> GetCustomers(string folderName)
        {
            var file = OpenFile(folderName, "Personas.txt");
          
           var Customers = new Dictionary<string,string>();
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                
                string[] fields = SplitLine(line);
           
                Customers.Add(fields[0], fields[1]);
               
            }
            return Customers;
        }
        public Stack<Order> GetOrders(string folderName)
        {
            var file = OpenFile(folderName, "Pedidos.txt");
            var orderStack = new Stack<Order>();
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                string[] fields = SplitLine(line);

                orderStack.Push(new Order { 
                    ProductDescription = fields[1],
                    Quantity= short.Parse(fields[0])
                });
            }
            return orderStack;
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
