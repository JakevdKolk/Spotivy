using Spotivy.Users;
using System;

public enum Genre
{
    blues,
    jazz,
    country,
    metal,
    pop,
    hiphop,
    gypsyJazz,
    classical,
}

public class Nummer
{
    public string name { get; set; }
    private string artiest = "test"; // Changed to private for consistency
    public double lengte;
    public Genre genre;
        
    public Nummer(string name, double length, Genre genre)
    {
        this.name = name;
        this.lengte = length;
        this.genre = genre;

    }


    public List<Nummer> InitNumbers()
    {
        // Create list of song names
        string[] names = new string[] { "Crossroad blues", "Moon river", "Ring of fire", "In the end", "Fortnight", "CARNIVAL", "Minor swing", "Manishboy", "Fur Elise", "Flowers" };

        // Create lengths corresponding to each song
        double[] lengths = new double[] { 3.5, 4.0, 5.2, 3.3, 4.4, 2.8, 3.7, 4.1, 5.0, 3.9 };

        // Create genres corresponding to each song
        Genre[] genres = new Genre[] { Genre.blues, Genre.jazz, Genre.country, Genre.metal, Genre.pop, Genre.hiphop, Genre.gypsyJazz, Genre.blues, Genre.classical, Genre.pop };

        // Create a list of Nummer
        List<Nummer> numbers = new List<Nummer>();

        // Loop through all the names, lengths, and genres
        for (int i = 0; i < names.Length; i++)
        {
            // Create a new Nummer and add to the list
            numbers.Add(new Nummer(names[i], lengths[i], genres[i]));
        }

        // Return the new list of numbers
        return numbers;
    }


}
