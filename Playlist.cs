using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy
{
    class Playlist : Songlist {

        User user { get; set; }

        public Playlist(string albumName, User user) : base(albumName)
        {
            this.user = user;
            // constructor of playlist class
        }

        // in life you need a playlist class amen
        public void add(Nummer nummer)
        {
            nummers.Add(nummer);
        }
        public void remove(Nummer nummer)
        {
            nummers.Remove(nummer);
        }
        public User showUserStatsFromPlayer()
        {
            Console.WriteLine("username: " + user.UserName);

            //idk you might want to do something with the user i guess
            return user;
        }

    }
}
