using Spotivy.Users;
namespace Spotivy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("player");

            List<User> users = user.initUsers();
         /*   foreach (User username in users)
            {
                Console.WriteLine(username.UserName);
            }*/
        }
    }
}
