using System;

interface ICalculate
{
    double Area();
}

class Rectangle : ICalculate
{
    private float length;
    private float width;

    public Rectangle(float x, float y)
    {
        length = x;
        width = y;
    }

    public double Area()
    {
        return length * width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle objRectangle = new Rectangle(10.2F, 20.3F);

        ICalculate calculate = objRectangle as ICalculate;

        if (calculate != null)
        {
            Console.WriteLine("Area: {0:F2}", calculate.Area());
        }
        else
        {
            Console.WriteLine("Interface method not implemented");
        }
    }
}
