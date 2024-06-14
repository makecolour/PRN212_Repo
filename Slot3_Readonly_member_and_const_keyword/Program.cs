using System;

public class SamplePoint
{
    public int x;
    // Initialize a readonly field
    public readonly int y = 25;
    public readonly int z;

    // Initialize a const field
    public const int t = 100;

    // Default constructor
    public SamplePoint()
    {
        // Initialize a readonly instance field
        z = 24;
    }

    // Parameterized constructor
    public SamplePoint(int p1, int p2, int p3)
    {
        x = p1;
        y = p2; // This will override the default value of y
        z = p3;
    }
}

class Program
{
    static void Main(string[] args)
    {
        SamplePoint p1 = new SamplePoint(11, 21, 32);
        Console.WriteLine($"t = {SamplePoint.t}");
        Console.WriteLine($"p1: x={p1.x}, y={p1.y}, z={p1.z}");

        SamplePoint p2 = new SamplePoint();
        Console.WriteLine($"p2: x={p2.x}, y={p2.y}, z={p2.z}");

        Console.ReadLine();
    }
}
