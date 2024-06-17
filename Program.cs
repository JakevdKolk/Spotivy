using Spotivy.Users;
namespace Spotivy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nummer Nummer = new Nummer("funny cat song", 30.5, Genre.country);
      
            //Create head user
            User user = new User("player");
            //Create list of test users
            
            List<User> users = user.initUsers();
            users.Add(user);
            Console.WriteLine("Search user");

            user.searchUser(Console.ReadLine(),users );
            user.searchNumberByGenre();
            //loop trough all test users.
         /*   foreach (User username in users)
            {
                Console.WriteLine(username.UserName);
            }*/

        }

    }

}
