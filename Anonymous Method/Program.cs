public delegate void MyDele(int val);
class Program
{
    static void Main()
    {
        MyDele printValue = delegate (int val) 
        {
            Console.WriteLine("Inside Anoymous method. Value: {0}", val);
        };
        printValue += delegate
        {
            Console.WriteLine("This is anonymous method");
        };
    printValue(100);
    Console.ReadLine();
    }
}