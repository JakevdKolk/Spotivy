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
            nummers.Remove(nummer);
        }

    }
}
