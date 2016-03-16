using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        private static List<Customer> customers;
        private static List<Order> orders;
        private static Hermes msg = new Hermes();
        static void Main(string[] args)
        {
            DataAccess data = new DataAccess();
            customers = data.GetCustomers(@"e:/");
            orders = data.GetOrders(@"e:/");
            send();
            Console.ReadKey();
        }
        private static void send()
        {
            foreach (Customer customer in customers)
            {
                foreach (Order order in orders)
                    customer.Orders.Push(order);
                while (customer.Orders.Count > 0)
                {
                    var currentOrder = customer.Orders.Pop();
                    Console.WriteLine(customer.Email+" "+currentOrder.Description);
                    //Console.WriteLine(CreateMessage(currentOrder));
                    msg.SendMessage(customer.Email, CreateMessage(currentOrder));
                }
            }
        }
        private static string CreateMessage(Order currentOrder)
        {
            return "Hi, we have successfully received your " + 
                currentOrder.Description + " order, it will be delivered in " + 
                currentOrder.Deadline + 
                " day(s).";
        }
    }
}
