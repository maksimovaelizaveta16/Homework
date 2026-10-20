using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your birth year: ");
        int birthYear = int.Parse(Console.ReadLine());

        // Calculate age
        int age = 2026 - birthYear;

        // Print greeting and age
        Console.WriteLine($"Hello, {name}!");
        Console.WriteLine($"You are {age} years old.");

        // Print uppercase name and length
        Console.WriteLine($"Uppercase name: {name.ToUpper()}");
        Console.WriteLine($"Name length: {name.Length}");
    }
}
