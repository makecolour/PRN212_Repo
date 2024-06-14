using System;

class MyClass
{
    public static int x = 1;

    // Static constructor
    static MyClass()
    {
        x = 2;
        Console.WriteLine("Static constructor: x={0}", x);
    }

    // Instance constructor
    public MyClass()
    {
        x++;
        Console.WriteLine("Object constructor: x={0}", x);
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass m1 = new MyClass();
        MyClass.x = 4;
        MyClass m2 = new MyClass();
    }
}
