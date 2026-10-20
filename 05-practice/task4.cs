using System;

class Program
{
    static void Main(string[] args)
    {
        // Create variables here
        string modelName = "Cube";
        int polygons = 12;
        float animationDuration = 5.0f;
        bool isVisible = true;
        float rotationAngle = 90.0f;

        Console.WriteLine($"Model name: {modelName}");
        Console.WriteLine($"Polygons: {polygons}");
        Console.WriteLine($"Animation duration: {animationDuration}");
        Console.WriteLine($"Visible: {isVisible}");
        Console.WriteLine($"Rotation angle: {rotationAngle}");
    }
}
