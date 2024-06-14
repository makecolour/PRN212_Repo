using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating an anonymous type object using 'var'
        var obj1 = new { id = 1000, name = "jack" };
        // Correcting the string interpolation for obj1
        Console.WriteLine($"id: {obj1.id}, name: {obj1.name}");

        // Creating an anonymous type object using 'dynamic'
        dynamic obj2 = new { id = 2000, name = "scott", Email = "scott@gmail.com" };
        // Correcting the string interpolation for obj2
        Console.WriteLine($"id: {obj2.id}, name: {obj2.name}, Email: {obj2.Email}");

        // Wait for user input before closing the console
        Console.ReadLine();
    }
}
