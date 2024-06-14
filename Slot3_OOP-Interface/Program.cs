using System;

public interface ISample
{
    // Static method in interface (valid in C# 8.0 and later)
    static void Print()
    {
        Console.WriteLine("Static method");
    }

    // Default interface method (valid in C# 8.0 and later)
    string GetString(string s)
    {
        return "Hello " + s;
    }
}

public interface ISample01
{
    void MyMethod()
    {
        Console.WriteLine("ISample01.MyMethod");
    }
}

public interface ISample02 : ISample01
{
    // New implementation of ISample01's MyMethod in ISample02
    void ISample01.MyMethod()
    {
        Console.WriteLine("ISample02.MyMethod");
    }
}

public class SampleImplementation : ISample02
{
    // Explicit interface implementation
    void ISample01.MyMethod()
    {
        Console.WriteLine("SampleImplementation.MyMethod");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Call the static method
        ISample.Print();

        // Create an instance of the implementing class
        ISample01 sample = new SampleImplementation();
        sample.MyMethod();  // This will call SampleImplementation.MyMethod()

        // Call the default interface method
        ISample sampleImpl = null;
        Console.WriteLine(sampleImpl.GetString("World"));
    }
}
