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
            if(checkEmpty()) return;

            nummers.Remove(nummer);
        }
        public bool checkEmpty()
        {
            bool isEmpty = !nummers.Any();
            if(isEmpty)
            {
                Console.WriteLine("GRRRRRRRR list is empty");
                return true;
            }
            return false;
        }
        public User showUserStatsFromPlayer()
        {
            Console.WriteLine("username: " + user.UserName);

            //idk you might want to do something with the user i guess
            return user;
        }
        public void putAlbumIntoPlaylist(Album albumemtje)
        {
            List<Nummer> nummertjes = albumemtje.nummers;
            //ik heb iets gevonden voor de album class!!!!!!
            foreach(Nummer nummer in nummertjes)
            {
                nummers.Add(nummer);
            }

        }
    }
}
