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

            Artiest Artiest = new Artiest("Funny Cat Man", initNumber);
            List<Artiest> artists = Artiest.InitArtists(nummers);
            artists.Add(Artiest);
            User user = new User("player");
            //Create list of test users
            
            List<User> users = user.initUsers();
            users.Add(user);
            Console.WriteLine("Search user");

            user.searchUser(Console.ReadLine(),users );

            //loop trough all test users.
            foreach (Artiest artist in artists)
            {
                Console.Write(artist.name + " - ");
                foreach(Nummer nummer in artist.songs)
                {

                    Console.WriteLine(nummer.name);
                }
            
            }

        }

    }

}
