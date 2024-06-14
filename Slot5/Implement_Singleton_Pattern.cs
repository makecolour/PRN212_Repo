//using System;

//public sealed class Singleton
//{
//    private static readonly Singleton instance = new Singleton();
//    private static int totalInstances = 1; // Initialize totalInstances to 1 since the instance is created here

//    // Private constructor to prevent instantiation outside the class
//    private Singleton()
//    {
//        Console.WriteLine("--Private constructor is called.");
//    }

//    // Static constructor
//    static Singleton()
//    {
//        Console.WriteLine("--Static constructor is called.");
//    }

//    // Public property to access the singleton instance
//    public static Singleton Instance
//    {
//        get
//        {
//            return instance;
//        }
//    }

//    // Public method to get the total number of instances created
//    public int GetTotalInstances()
//    {
//        return totalInstances;
//    }

//    // Public method to print a message
//    public void Print()
//    {
//        Console.WriteLine("Hello World.");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("#1. Trying to get a Singleton instance, called firstInstance.");
//        Singleton firstInstance = Singleton.Instance;
//        Console.Write("--Invoke Print() method: ");
//        firstInstance.Print();

//        Console.WriteLine("#2. Trying to get another Singleton instance, called secondInstance.");
//        Singleton secondInstance = Singleton.Instance;
//        Console.WriteLine($"--Number of instances: {secondInstance.GetTotalInstances()}");
//        Console.Write("--Invoke Print() method: ");
//        secondInstance.Print();

//        if (firstInstance.Equals(secondInstance))
//        {
//            Console.WriteLine("=> The firstInstance and secondInstance are the same.");
//        }
//        else
//        {
//            Console.WriteLine("=> Different instances exist.");
//        }

//        Console.Read();
//    }
//}
