using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Nummer
{
    int id;
    string name = "Nummer 1";
    string artiest = "test";
    double lengte = 4.35;
    enum genre
    {
        blues,
        jazz,
        country,
        metal
    }
    public void getGenre()
    {
        genre nummer1 = genre.blues;
        Console.WriteLine(nummer1);
    }

    public void getNaam()
    {
        Console.WriteLine(name);
    }
}
