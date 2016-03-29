using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RedesSociales
{
    class Factory
    {
        //class Factory

        public Inetwork CreateRequest(string network)
        {
            network = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(network.ToLower()); ;
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                var type = assembly.GetTypes().First(t => t.Name == network);
                return (Inetwork)Activator.CreateInstance(type);
            }
            catch (Exception e)
            {

                return new facebook();
            }
        }


    }
}
