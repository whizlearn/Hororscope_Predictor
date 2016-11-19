using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTier
{
    public class User
    {
        protected string _name;
        protected DateTime _birthday;
        protected string _avatar;

        public string UserName 
        {
            get { return _name; }
            set { _name = value; }
        }

        public DateTime Birthday 
        { 
            get { return _birthday; }
            set { _birthday = value; }
        }

        public string Avatar
        {
            get { return _avatar; }
            set { _avatar = value; }
        }


    }
}
