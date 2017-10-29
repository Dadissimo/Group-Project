using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandragil
{
    public class User
    {
        public int Id { get; }
        public string Name;
        public string Password;


        public User(int id, string username, string password)
        {
            Id = id;
            Password = password;
            Name = username;
        }
        public User()
        {

        }
    }
}
