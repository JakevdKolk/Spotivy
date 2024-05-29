using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy.Users
{
    internal class User
    {
        
        public string UserName { get; set; }
            
        public User(string userName)
        {
            UserName = userName;
        }

        public List<User> initUsers()
        {
            string[] addUsers = new string[] { "Odin", "Jake", "Florian", "Kanye East", "Velican", "Delta", "Eddie", "Robert", "Floris", "Bart" };
            List<User> users = new List<User>();
            foreach (string user in addUsers)
            {
                users.Add(new User(user));
            }
            return users;
        }
    
    }
}
