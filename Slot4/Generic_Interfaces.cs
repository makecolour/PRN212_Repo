//using System;

//// Declare an interface with constraint: struct (Value type)
//interface IBasic<T> where T : struct
//{
//    T Add(T a, T b);
//}

//// Implement interface IBasic with int type
//class MyFirstClass : IBasic<int>
//{
//    public int Add(int a, int b) => a + b;
//}

//// Implement interface IBasic with double type
//class MySecondClass : IBasic<double>
//{
//    public double Add(double a, double b) => a + b;
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        MyFirstClass firstClass = new MyFirstClass();
//        int resultInt = firstClass.Add(10, 20);
//        Console.WriteLine(resultInt);
//        MySecondClass secondClass = new MySecondClass();
//        double resultDouble = secondClass.Add(10.5, 20.5);
//        Console.WriteLine(resultDouble);
//        Console.ReadLine();
//    }
//}
