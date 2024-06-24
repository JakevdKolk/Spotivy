using System;
using System.Collections.Generic;

namespace Spotivy
{
    internal class Artiest
    {
        public string name;
        public Nummer[] songs;

        public Artiest(string name, Nummer song)
        {
            this.name = name;
            this.songs = new Nummer[] { song }; // Store single song in an array
        }

        public static List<Artiest> InitArtists(List<Nummer> numbers)
        {
            // Create list of artist names
            string[] names = new string[] { "Robert Johnson", "Louis Armstrong", "Johnny Cash", "Linkin Park", "Taylor Swift", "Kanye West", "Django Reinhart", "Muddy Waters", "Mozart", "Katy Perry" };

            // Create a list of Artiest
            List<Artiest> artists = new List<Artiest>();

            // Loop through all the names and songs
            for (int i = 0; i < names.Length; i++)
            {
                // Create a new Artiest and add to the list
                artists.Add(new Artiest(names[i], numbers[i]));
            }

            // Return the new list of artists
            return artists;
        }
    }
}
