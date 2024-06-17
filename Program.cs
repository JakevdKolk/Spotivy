using Spotivy.Users;
namespace Spotivy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nummer initNumber = new Nummer("funny cat song", 30.5, Genre.classical);
            List<Nummer> nummers = initNumber.InitNumbers();
            nummers.Add(initNumber);
       
            //Create head user
            User user = new User("player");
            //Create list of test users
            
            List<User> users = user.initUsers();
            users.Add(user);

           // user.searchUser(Console.ReadLine(),users );
            user.searchNumberByGenre(nummers);
            user.searchNumberByName(nummers);   
            //loop trough all test users.
           

        }

    }

}
