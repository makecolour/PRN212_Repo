using System;

public class UtilityClass
{
    // Traditional method
    public int Add(int x, int y)
    {
        return x + y;
    }

    // OR expression-bodied method (Choose one of these methods, not both)
    // public int Add(int x, int y) => x + y;

    // Fields for the Name property
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Traditional property
    public string Name
    {
        get
        {
            return FirstName + " " + LastName;
        }
    }

    // OR expression-bodied property (Choose one of these properties, not both)
    // public string Name => FirstName + " " + LastName;
}

public class Location
{
    private string locationName;

    // Constructor
    public Location(string name) => locationName = name;

    // Property with getter and setter
    public string Name
    {
        get => locationName;
        set => locationName = value;
    }
}

class Program
{
    static void Main(string[] args)
    {
        UtilityClass utility = new UtilityClass
        {
            FirstName = "John",
            LastName = "Doe"
        };
        Console.WriteLine(utility.Name); // Output: John Doe

        int sum = utility.Add(5, 7);
        Console.WriteLine($"Sum: {sum}"); // Output: Sum: 12

        Location loc = new Location("New York");
        Console.WriteLine(loc.Name); // Output: New York

        loc.Name = "Los Angeles";
        Console.WriteLine(loc.Name); // Output: Los Angeles
    }