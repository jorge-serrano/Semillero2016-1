using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClassAndAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            Animal instance = factory.CreateAnimal(Convert.ToString(Console.ReadLine()));

            Console.Write(instance);
            Console.ReadKey();
        }
    }
}
