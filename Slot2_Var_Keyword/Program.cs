using System;

class Program
{
    static void Main(string[] args)
    {
        var myInt = 0;
        var myBool = true;
        var myString = "Hello";
        var myDouble = 0.5;

        // Print out the underlying type
        Console.WriteLine("myInt is a: "+ myInt.GetType().Name);
        Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
        Console.WriteLine("myString is a: {0}", myString.GetType().Name);
        Console.WriteLine("myDouble is a: {0}", myDouble.GetType().Name);
        Console.ReadLine();
        //var cannot null
        //var cannot intialize to a method group or function
        //var cannot be used as a field
        //var cannot be used as a return type
        //var cannot be used as a parameter
        //var cannot be used as a property
        //var cannot be used as a member of a class
      
    }
}
