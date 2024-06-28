using System;
using System.Collections.Generic;

namespace Spotivy.Users
{
    internal class Songlist
    {
        public string playlist_name { get; set; }
        public List<Nummer> nummers { get; set; } = new List<Nummer>();
        protected bool isPlaying { get; set; }

        protected int indexPlaying { get; set; }
        public Songlist(string playlist_name)
        {
            this.playlist_name = playlist_name;
            this.indexPlaying = 0;
        }
        public void initSonglist(List<Nummer> nummertjes)
        {
            foreach(Nummer nummertje in nummertjes)
            {
                nummers.Add(nummertje);
            }
        }
        public void playInList() {
            isPlaying = true;
            foreach(Nummer nummer in nummers)
            {
                Console.WriteLine("You are listening to: " + nummer.name + " Number length: " + nummer.lengte + " Genre is: " + nummer.genre);

                Console.WriteLine("Do you want to listen to the next number");
                Console.WriteLine("1 yes/2 no");
                string input = Console.ReadLine();
                if(input != "1")
                {
                    Console.WriteLine("thank you for listining");
                    break;
                }
                Console.WriteLine("playing next song");
            }


        }
        // needs to get moved to the client class
        public void play(Nummer nummer)
        {
            isPlaying = true;
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

        public void skip()
        {
            // Implementation for skip
            indexPlaying = indexPlaying + 1;
            Nummer nummer = nummers[indexPlaying];

            Console.WriteLine("You skipped now playing the number: " + nummer.name + " number length: " + nummer.lengte + " genre is: " + nummer.genre);


        }
        /* can always make this a return statement if needed */
        public void stop(Nummer nummer)
        {
            if (isPlaying) {
                isPlaying=false;
                Console.WriteLine("You stopped the number: " + nummer.name + " number length: " + nummer.lengte + " genre is: " + nummer.genre);
            }
            Console.WriteLine("number isn't playing");
        }

        /* Temporary, needs to be moved to the playlist class */
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
