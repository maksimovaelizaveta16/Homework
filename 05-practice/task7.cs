using System;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "level_01_scene.unity";

        // Find dot, extract name, convert to upper
        int dotIndex = fileName.IndexOf('.');
        string name = fileName.Substring(0, dotIndex);
        string upperName = name.ToUpper();

        Console.WriteLine(upperName);
    }
}
