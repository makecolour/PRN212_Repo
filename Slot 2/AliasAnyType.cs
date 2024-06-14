//using Point = System.ValueTuple<int, int>; // Corrected the tuple alias syntax
//using System.IO; // Added namespace for File and StreamReader

//internal partial class Program // Corrected partial class declaration
//{
//    private static async Task Main(string[] args) // Changed void to Task for async Main
//    {
//        Point p = (3, 5);
//        Console.WriteLine($"({p.Item1}, {p.Item2})"); // Corrected tuple element access

//        using var file = File.OpenRead("data.txt");
//        using var reader = new StreamReader(file);

//        string line = await reader.ReadLineAsync();
//        Console.WriteLine(line); // Added console output for the read line
//    }
//}
