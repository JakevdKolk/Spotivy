using Spotivy.Users;
namespace Spotivy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create head user
            User user = new User("player");
            //Create list of test users
            List<User> users = user.initUsers();

            //loop trough all test users.
         /*   foreach (User username in users)
            {
                Console.WriteLine(username.UserName);
            }*/
        }
    }
}
