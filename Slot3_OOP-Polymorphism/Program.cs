using System;

public abstract class Shape
{
    public int Height { get; set; }
    public int Width { get; set; }

    // Virtual method with a default implementation
    public virtual void Draw()
    {
        Console.WriteLine("Performing base class Drawing tasks");
    }

    // Method with implementation
    public void Print()
    {
        Console.WriteLine("Performing base class Printing tasks");
    }

    // Abstract method that must be overridden in derived classes
    public abstract void Display();
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }

    public override void Display()
    {
        Console.WriteLine("Display Rectangle");
    }

    public new void Print()
    {
        Console.WriteLine("Print Rectangle");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }

    public override void Display()
    {
        Console.WriteLine("Display Circle");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape shape = new Circle();
        shape.Display();
        shape.Draw();
        shape.Print();

        shape = new Rectangle();
        shape.Display();
        shape.Draw();
        shape.Print();

        Console.ReadLine();
    }
}
