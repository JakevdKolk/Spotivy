using System;

public enum Genre
{
    blues,
    jazz,
    country,
    metal,
    rock
}

public class Nummer
{
    public string name;
    private string artiest = "test"; 
    private double lengte;
    private Genre genre;

    public Nummer(string name, double length, Genre genre)
    {
        this.name = name;
        this.lengte = length;
        this.genre = genre;
    }

   
}
