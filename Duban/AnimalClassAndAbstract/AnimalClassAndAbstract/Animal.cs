using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalClassAndAbstract
{
    public abstract class Animal
    {
        public int Energy
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Animaltype
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Eat()
        {
            throw new System.NotImplementedException();
        }
    }
}
