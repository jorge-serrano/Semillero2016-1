using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalClassAndAbstract
{
    public interface Predator
    {
        Animal Animal
        {
            get;
            set;
        }
    
        void Hunt();
    }
}
