using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RedesSociales
{
    public interface Inetwork
    {
        string usuario
        {
            get;
            set;
        }

        string contrasena
        {
            get;
            set;
        }

        string direccion
        {
            get;
            set;
        }
    
        void validar();
    }
}
