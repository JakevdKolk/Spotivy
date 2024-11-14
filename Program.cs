using Spotivy;

namespace Spotivy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool appRunning = true;
            // Create the main user
            User user = new User("player");
            // Create a new song list
            Songlist songs = new Songlist("my songlist");
            Playlist playlist = new Playlist("a playlist");

            // Create a new number
            Nummer initNumber = new Nummer("funny cat song", 30.5, Genre.classical, "hahahhaha");

            // Initialize the list of numbers
            List<Nummer> nummers = initNumber.InitNumbers();
            nummers.Add(initNumber);

            List<User> users = user.initUsers();
            users.Add(user);

            Friends friend = new Friends();
            friend.addFriend(users.First());

            // Assign the initialized list to the song list
            songs.initSonglist(nummers);
            playlist.initSonglist(nummers);

            user.addPlaylist(playlist);
            while (appRunning)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1 search user/ 2 search song/ 3 view playlists/ 4 view friends/ 5 end application");
                string mainChoice = Console.ReadLine();

                if (mainChoice == "1")
                {
                    Console.WriteLine("Enter the username to search:");
                    string userName = Console.ReadLine();
                    User foundUser = user.searchUser(userName, users);

                    Console.WriteLine("What would you like to do with " + foundUser.UserName + "?");
                    Console.WriteLine("1 add friend");
                    string userChoice = Console.ReadLine();
                    if (userChoice == "1")
                    {
                        friend.addFriend(foundUser);
                    }
                }
                else if (mainChoice == "2")
                {
                    Console.WriteLine("1 search number by name/ 2 search number by genre");
                    string searchChoice = Console.ReadLine();
                    List<Nummer> foundNummer = null;

                    if (searchChoice == "1")
                    {
                        foundNummer = user.searchNumberByName(nummers);
                    }
                    else if (searchChoice == "2")
                    {
                        foundNummer = user.searchNumberByGenre(nummers);
                    }
                    else
                    {
                        appRunning = false;
                        continue;
                    }

                    if (foundNummer != null && foundNummer.Any())
                    {
                        Console.WriteLine("Found number: " + foundNummer.First().name);
                        Console.WriteLine("1 play / 2 stop / 3 add to playlist / 4 get artist");
                        string actionChoice = Console.ReadLine();

                        if (actionChoice == "1")
                        {
                            songs.play(foundNummer.First());
                        }
                        else if (actionChoice == "2")
                        {
                            songs.stop(foundNummer.First());
                        }
                        else if (actionChoice == "3")
                        {
                            playlist.add(foundNummer.First());
                        }
                        else if (actionChoice == "4")
                        {
                            Console.WriteLine(foundNummer.First().getArtist());
                        }
                        else
                        {
                            appRunning = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No number found or invalid search option.");
                    }
                }
                else if (mainChoice == "3")
                {
                    Console.WriteLine("1 shuffle/ 2 play in list/ 3 create new playlist/ 4 skip/ 5 show all playlists");
                    string playlistChoice = Console.ReadLine();

                    if (playlistChoice == "1")
                    {
                        playlist.shuffle();
                    }
                    else if (playlistChoice == "2")
                    {
                        playlist.playInList();
                    }
                    else if (playlistChoice == "3")
                    {
                        user.addPlaylist(playlist);
                    }
                    else if (playlistChoice == "4")
                    {
                        playlist.skip();
                    }
                    else if (playlistChoice == "5")
                    {
                        user.showPlaylists();
                    }
                    else
                    {
                        appRunning = false;
                    }
                }
                else if (mainChoice == "4")
                {
                    friend.showFriendList();
                    Console.WriteLine("1 delete friend/2 show playlists");
                    string friendChoice = Console.ReadLine();

                    if (friendChoice == "1")
                    {
                        friend.deleteFriend();
                    }
                    else if (friendChoice == "2")
                    {
                        friend.showPlaylistList(user);
                    }
                }
                else if (mainChoice == "5")
                {
                    appRunning = false;
                }
            }
        }
    }
}
