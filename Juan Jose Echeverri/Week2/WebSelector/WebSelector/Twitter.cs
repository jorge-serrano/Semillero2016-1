using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebSelector
{
    public class Twitter : Network
    {

        public string UserName;
        public string PasswordUser;
        public string UrlUser;

        public string User
        {
            get
            {
                return User = UserName;
            }
            set
            {
                User = value;
            }
        }

        public string Password
        {
            get
            {
                return Password = PasswordUser;
            }
            set
            {
                Password = value;
            }
        }

        public string Url
        {
            get
            {
                return Url = UrlUser;
            }
            set
            {
                Url = value;
            }
        }

        public void Connect()
        {
        }
    }
}
