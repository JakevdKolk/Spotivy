using System;

public enum Genre
{
    blues,
    jazz,
    country,
    metal
}

public class Nummer
{
    private string name;
    private string artiest = "test"; // Changed to private for consistency
    private double lengte;
    private Genre genre;

    public Nummer(string name, double length, Genre genre)
    {
        this.name = name;
        this.lengte = length;
        this.genre = genre;
    }

   
}
