using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy
{
    class Friends
    {
        List<User> friends { get; set; }
        public Friends() {
            friends = new List<User>();
        }

        public List<User> addFriend(User user) {

            if (user == null)
            {
                return friends;
            }
             friends.Add(user);
            Console.WriteLine("added friend:" + user.UserName);
            return friends;
        }
        public List<User> deleteFriend(User user)
        {
            friends.Remove(user);
            Console.WriteLine("removed friend:" + user.UserName);
            return friends;
        }

        public void showFriendList()
        {
            foreach (User friend in friends)
            {
                Console.WriteLine(friend.UserName);
            }
        }
        public void showPlaylistList(User you)
        {

            foreach(User user in friends)
            {

                foreach (Playlist playlist in user.playlists)
                {
                    Console.WriteLine("playlist: " + playlist.playlist_name);
                    foreach (Nummer nummer in playlist.nummers)
                    {
                        Console.WriteLine("nummer: " + nummer.name);
                    }
                    Console.Write("do you want to copy this playlist");
                    Console.WriteLine("1 yes / 2 no");
                    if(Console.ReadLine() == "1")
                    {
                        copyPlaylist(playlist, you);
                    }

                }
               
            }

        }
        public void copyPlaylist(Playlist playlist , User user) {
            user.addPlaylist(playlist);
        }


    }
}
