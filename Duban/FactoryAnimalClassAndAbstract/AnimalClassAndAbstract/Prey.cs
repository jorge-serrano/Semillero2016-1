using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalClassAndAbstract
{
    public interface Prey
    {
        Animal Animal
        {
            get;
            set;
        }
    
        void Runaway();
    }
}
