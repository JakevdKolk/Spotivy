using System;
using System.Collections.Generic;

namespace Spotivy
{
    internal class Artiest
    {
        public string name;
        public string[] song;

        public Artiest(string name, string song)
        {
            this.name = name;
            this.song = new string[] { song }; // Store single song in an array
        }

        public List<Artiest> InitArtists()
        {
            // Create list of artist names
            string[] names = new string[] { "Robert Johnson", "Louis Armstrong", "Johnny Cash", "Linkin Park", "Taylor Swift", "Kanye West", "Django Reinhart", "Muddy Waters", "Mozart", "Katy Perry" };

            // Create list of songs
            string[] songs = new string[] { "Crossroad blues", "Moon river", "Ring of fire", "In the end", "Fortnight", "CARNIVAL", "Minor swing", "Manishboy", "Fur Elise", "Flowers" };

            // Create a list of Artiest
            List<Artiest> artists = new List<Artiest>();

            // Loop through all the names and songs
            for (int i = 0; i < names.Length; i++)
            {
                // Create a new Artiest and add to the list
                artists.Add(new Artiest(names[i], songs[i]));
            }

            // Return the new list of artists
            return artists;
        }
    }
}
