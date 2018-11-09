using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Collections_Lists_Challenge
{
    class User
    {
        public string UserName { get; set; }
        public int UserAge { get; set; }

        public User(string userName, int userAge)
        {
            UserName = userName;
            UserAge = userAge;
        }
    }
}
