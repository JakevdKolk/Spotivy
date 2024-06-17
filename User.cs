﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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

        /**
         * @string userName name given by user input
         * 
         * @List<User> list of all users
         * 
         * Method that searches users
         * 
         * */
        public User searchUser(string userName, List<User> users)
        {
            // get all users that start with certain chars
            List<User> foundUsers = users
                   .Where(user => user.UserName.ToLower().StartsWith(userName.ToLower(), StringComparison.OrdinalIgnoreCase))
                   .ToList();
            // check if count is above 1
            if(foundUsers.Count() > 0) {
                // check if count is 2 or higher
                if (foundUsers.Count() >= 2)
                {
                    foundUsers = selectMultipleUser(foundUsers);
                }
                Console.WriteLine("Found user " + foundUsers.First().UserName);

                return foundUsers.First();
            }
            Console.WriteLine("error no user found try again");
            return searchUser(Console.ReadLine(), users);
            
        }

        /**
         * @List<User> list of already filterted users
         * 
         * Method that gives you a choice between 2 users
         * */
        private List<User> selectMultipleUser(List<User> users)
        {
            Console.WriteLine("Multiple users found please select one");
            // show all users
            foreach(User user in users)
            {
                Console.Write(user.UserName + " , ");
            }
            //user input for selected user
            string userResponce = Console.ReadLine();
            // get all users that start with certain chars
            List<User> foundUsers = users
                   .Where(user => user.UserName.ToLower().StartsWith(userResponce.ToLower(), StringComparison.OrdinalIgnoreCase))
                   .ToList();
            //check if count is 1
            if(foundUsers.Count() == 1)
            {
                return foundUsers;
            }
            Console.WriteLine("error try again");
            return selectMultipleUser(users);
        }

        //transform to list once number generation is done
        public List<Nummer> searchNumberByName(List<Nummer> numbers) {
            Console.WriteLine("Search a number by name: ");
            string input = Console.ReadLine();
            List<Nummer> foundNummers = numbers.Where(number => number.name.ToLower().StartsWith(input.ToLower(), StringComparison.OrdinalIgnoreCase)).ToList();
            if (foundNummers.Count < 1)
            {
                Console.WriteLine("No Numbers found");
                return searchNumberByName(numbers);
            }

            else if (foundNummers.Count > 1)
            {
                Console.WriteLine("Found Multiple Numbers please select one");
                //return multiple method
            }
            return foundNummers;

        }

        public List<Nummer> searchNumberByGenre(List<Nummer> numbers)
        {
            Console.WriteLine("Search a number by genre: ");
            string input = Console.ReadLine();
            List<Nummer> foundNummers = numbers.Where(number => number.name.ToLower().StartsWith(input.ToLower(), StringComparison.OrdinalIgnoreCase)).ToList();
            if(foundNummers.Count < 1)
            {
                Console.WriteLine("No Numbers found");
                return searchNumberByGenre(numbers);
            }

            else if (foundNummers.Count > 1)
            {
                Console.WriteLine("Found Multiple Numbers please select one");
                return selectMultipleNumbers(foundNummers);
            }
            return foundNummers;

        }

        private List<Nummer> selectMultipleNumbers(List<Nummer> numbers) {
            Console.WriteLine("Multiple numbers found please select one");
            // show all users
            foreach (Nummer number in numbers)
            {
                Console.Write(number.name + " , ");
            }
            //user input for selected user
            string input = Console.ReadLine();
            // get all users that start with certain chars
            List<Nummer> foundNummers = numbers.Where(number => number.name.ToLower().StartsWith(input.ToLower(), StringComparison.OrdinalIgnoreCase)).ToList();

            //check if count is 1
            if (foundNummers.Count() == 1)
            {
                return foundNummers;
            }
            Console.WriteLine("error try again");
            return selectMultipleNumbers(numbers);
        }
    
    }
}
