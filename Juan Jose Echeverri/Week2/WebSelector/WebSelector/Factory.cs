using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSelector
{
    class Factory
    {
        public Network RequestNet(string red, string User, string Pass, string Url)
        {
            try
            {
                if (red == "FB")
                {
                    Facebook person1 = new Facebook();
                    return person1;
                }
                else if (red == "TT")
                {
                    Twitter person1 = new Twitter();
                    return person1;
                }
                else if (red == "G+")
                {
                    Gplus person1 = new Gplus();
                    return person1;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception)
            {
                return null;
            }
        }
    }
}
