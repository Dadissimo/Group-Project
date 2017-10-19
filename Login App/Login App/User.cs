using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_App
{
    public class User
    {
        public string name;
        public string pw;

        public User(string name, string pw)
        {
            this.name = name;
            this.pw = pw;
        }
    }
}
