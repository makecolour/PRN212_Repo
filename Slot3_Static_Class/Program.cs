using System;

static class UtilityClass
{
    public static void PrintTime()
    {
        Console.WriteLine(DateTime.Now.ToShortTimeString());
    }

    public static void PrintDate()
    {
        Console.WriteLine(DateTime.Today.ToShortDateString());
    }
}

class Program
{
    static void Main(string[] args)
    {
        // No instance is created since the class is static
        UtilityClass.PrintDate();
        UtilityClass.PrintTime();
    }
}
