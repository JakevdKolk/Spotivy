using Spotivy;

namespace Spotivy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the main user
            User user = new User("player");
            // Create a new song list
            Songlist songs = new Songlist("my songlist");
            Playlist playlist = new Playlist("a playlist", user);

            // Create a new number
            Nummer initNumber = new Nummer("funny cat song", 30.5, Genre.classical);

            // Initialize the list of numbers
            List<Nummer> nummers = initNumber.InitNumbers();
            nummers.Add(initNumber);

            // Assign the initialized list to the song list
            songs.initSonglist(nummers);
            // Shuffle the songs
            songs.shuffle();    
            songs.stop(nummers.First());
            songs.playInList();
            songs.play(nummers.First());
            songs.stop(nummers.First());

            

            // Create a list of test users and add the main user to it
            List<User> users = user.initUsers();
            Friends friend = new Friends();
            friend.addFriend(user);
            friend.addFriend(users.First());
            friend.deleteFriend(user);
            friend.showFriendList();

            users.Add(user);

            // Search for numbers by genre and name
            user.searchNumberByGenre(nummers);
            user.searchNumberByName(nummers);

        }
    }
}
