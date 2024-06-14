using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            using var reader = new StreamReader(@"C:\data.txt");
            var content = reader.ReadToEnd();
            Console.WriteLine($"File length: {content.Length}");
        }
        catch (FileNotFoundException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadLine();
    }
}
