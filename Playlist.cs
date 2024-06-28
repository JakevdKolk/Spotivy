using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy
{
    class Playlist : Songlist {

        public Playlist(string albumName) : base(albumName)
        {
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
