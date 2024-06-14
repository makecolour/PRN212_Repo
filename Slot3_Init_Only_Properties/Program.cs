//When we write a property only with "get", it automatically becomes a Read Only property or we can use Init-Only properties  
public class MyClass
{
    //Init -Only property
    public int x { get; init; }
    //Read-Only property
    public int y { get; }
    public MyClass()
    {
        x = 5;
        y = 10;
    }
    public MyClass(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

}
class Program
{4
    static void Main()
    {
        MyClass obj = new MyClass { x=1};
        Console.WriteLine($"x:{obj.x}, y:{obj.y}");
        //obj.x = 10; //Error
        //obj.y = 20; //Error
        MyClass obj1 = new MyClass(50, 100);
        Console.WriteLine($"x:{obj1.x}, y:{obj1.y}");

        MyClass obj2 = new MyClass(50, 100);
        Console.WriteLine($"x:{obj2.x}, y:{obj2.y}");
        Console.ReadLine();
    }
}