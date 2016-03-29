using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalClassAndAbstract
{
    public class Frog : Animal, Predator, Prey
    {
        public Predator_2 Predator_2
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Animal Animal
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Hunt()
        {
            throw new NotImplementedException();
        }


        public void Runaway()
        {
            throw new NotImplementedException();
        }
    }
}
