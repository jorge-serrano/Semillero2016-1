using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSelector
{
    interface Network
    {

        string User
        {
            get;
            set;
        }

        string Password
        {
            get;
            set;
        }

        string Url
        {
            get;
            set;
        }

        void Connect();
    }
}
