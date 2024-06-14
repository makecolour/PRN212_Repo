//using System;

//// Declaring a delegate
//public delegate void MyDelegate(string msg);

//public class MyClass
//{
//    public static void Print(string message) => Console.WriteLine($"{message.ToUpper()}");
//    public static void Show(string message) => Console.WriteLine($"{message.ToLower()}");
//}

//class Program
//{
//    // MyDelegate type parameter
//    static void InvokeDelegate(MyDelegate dele, string msg) => dele(msg);

//    static void Main(string[] args)
//    {
//        string msg = "Passing Delegate As A Parameter";
//        InvokeDelegate(MyClass.Print, msg);
//        InvokeDelegate(MyClass.Show, msg);
//        Console.ReadLine();
//    }
//}
