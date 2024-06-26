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
        public void initSonglist(List<Nummer> nummertjes)
        {
            foreach(Nummer nummertje in nummertjes)
            {
                nummers.Add(nummertje);
            }
        }
        public void playInList() {
            Nummer firstNummer = nummers.First();

            Console.WriteLine("You are listening to: " + firstNummer.name + " Number length: " + firstNummer.lengte + " Genre is: " + firstNummer.genre);

        }
        // needs to get moved to the client class
        public void play(Nummer nummer)
        {
            Console.WriteLine("You are listening to: " + nummer.name + " Number length: " + nummer.lengte + " Genre is: " + nummer.genre);
        }

        public List<Nummer> shuffle()
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

        
            return nummers;
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
        public List<Nummer> delete(Nummer nummer)
        {
                
        }
    }
}
