using System.Collections.Generic;

namespace Generics
{
    public interface IDataAccess
    {
        /// <summary>
        /// Get the list of customers from a text file
        /// </summary>
        /// <param name="folderName">full path of the folder taht contains the txt file</param>
        /// <returns></returns>
        List<Customer> GetCustomers(string folderName);

        List<Order> GetOrders(string folderName);
    }
}