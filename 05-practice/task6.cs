using System;

class Program
{
    static void Main(string[] args)
    {
        string data = "x=10;y=20;z=30";

        // Split and print each coordinate
        string[] coordinates = data.Split(';');

        foreach (string coordinate in coordinates)
        {
            string[] parts = coordinate.Split('=');
            Console.WriteLine($"Coordinate {parts[0]} = {parts[1]}");
        }
    }
}
