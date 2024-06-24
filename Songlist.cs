using System;
using System.Collections.Generic;

namespace Spotivy.Users
{
    internal class Songlist
    {
        public string playlist_name { get; set; }
        public List<Nummer> nummers { get; set; } = new List<Nummer>();

        public Songlist(string playlist_name)
        {
            this.playlist_name = playlist_name;
        }

        public Nummer play()
        {
            // Implementation for play
            return null;
        }

        public void shuffle()
        {
            Random rng = new Random();
            int n = nummers.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Nummer value = nummers[k];
                nummers[k] = nummers[n];
                nummers[n] = value;
            }

            foreach(Nummer nummers in nummers)
            {
                Console.WriteLine(nummers.name);
            }
        }

        public Nummer skip()
        {
            // Implementation for skip
            return null;
        }

        /* Temporary, needs to be moved to the playlist class */
        public void add(Nummer nummer)
        {
            nummers.Add(nummer);
        }
    }
}
