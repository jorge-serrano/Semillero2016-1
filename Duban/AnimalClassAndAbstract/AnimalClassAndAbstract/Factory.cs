using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClassAndAbstract
{
    public class Factory
    {

        /* public Animal CreateAnimal(string Tipo)
         {
             string Animal = Animal(string Tipo);
             Animal = obj.SquareAAnimal(Tipo);
             // The result is 9.
             Console.WriteLine(Tipo);
            
         }
         */
        public Animal CreateAnimal(string Tipo)
        {
            try
            {
                switch (Tipo)
                {


                    case "Lion":
                        return new Lion();
                    case "Snake":
                        return new Snake();
                    case "Eagle":
                        return new Eagle();
                    case "Frog":
                        return new Frog();

                    //default:
                    default: throw new NotImplementedException();
                }

            }
            catch (Exception)
            {

                Console.Write("There ins´t Animal");
                return null;
            }

        }

    }
}


