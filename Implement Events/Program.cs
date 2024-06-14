public delegate void PrintDetails(string msg);
class Program
{
    event PrintDetails Print;
    void Show(string msg) => Console.WriteLine(msg.ToUpper());
    
    static void Main()
    {
        Program p = new Program();
        //Register with the event
        p.Print += new PrintDetails(p.Show);
        //Raise "Print" event
        p.Print("Hello World!");
        Console.ReadLine();
    }
}