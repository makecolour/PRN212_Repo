//using System;

//class Program
//{
//    static int Sum(int x, int y) => x + y;
//    static void Print(string msg) => Console.WriteLine(msg.ToUpper());

//    static void Main(string[] args)
//    {
//        int a = 15, b = 25, s;
//        string strResult;

//        // Func delegate takes two input parameters of int type
//        // and returns a value of int type:
//        Func<int, int, int> sumFunc = Sum;

//        // Invoke Sum method by Func delegate
//        s = sumFunc(a, b);
//        strResult = $"{a} + {b} = {s}";

//        Console.WriteLine("***Invoke Print method by Action delegate***");

//        // Action delegate takes one input parameter of string type
//        Action<string> action = Print;
//        action(strResult);

//        Console.ReadLine();
//    }
//}
