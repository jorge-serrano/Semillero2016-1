using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClassAndAbstract
{
    public class Factory
    {

        
        public Animal CreateAnimal(string Tipo)
        {
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                var type = assembly.GetTypes().First(t => t.Name == Tipo);
               
                return (Animal)Activator.CreateInstance(type);

            }
            catch (Exception)
            {
                Console.Write("There isn´t Animal");
                return null;
            }

        }

    }
}


