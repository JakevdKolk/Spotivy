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
            // Set username
            UserName = userName;
        }

        /**
         * 
         * method that creates alot of users
         */
        public List<User> initUsers()
        {
            // create list of usernames
            string[] addUsers = new string[] { "Odin", "Jake", "Florian", "Kanye East", "Velican", "Delta", "Eddie", "Robert", "Floris", "Bart" };
            // create a list of Uers
            List<User> users = new List<User>();
            //Loop trough all the usernames
            foreach (string user in addUsers)
            {
                // create a new user
                users.Add(new User(user));
            }
            //return the new users
            return users;
        }

        public User searchUser(string userName, List<User> users)
        {
            

            User foundUser = users.FirstOrDefault(user => user.UserName.ToLower() == userName.ToLower());


            if (foundUser != null) {
                Console.WriteLine(foundUser.UserName);
                return foundUser;


            }
            else
            {
                Console.WriteLine("error no user found");
                return null;
            }
        }
    
    }
}
