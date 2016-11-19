using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTier
{
    public class Administrator : User
    {
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
