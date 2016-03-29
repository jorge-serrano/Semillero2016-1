using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RedesSociales
{
    public class facebook : Inetwork
    {
        private string Usuario, Contrasena, Direccion="http://www.facebook.com";

        public string usuario
        {
            get
            {
                return Usuario;
            }
            set
            {
                Usuario = value;
            }
        }

        public string contrasena
        {
            get
            {
                return Contrasena;
            }
            set
            {
                Contrasena = value;
            }
        }

        public string direccion
        {
            get
            {
                return Direccion;
            }
            set
            {
                Direccion = value;
            }
        }

        public void validar()
        {
            throw new NotImplementedException();
        }
    }
}
