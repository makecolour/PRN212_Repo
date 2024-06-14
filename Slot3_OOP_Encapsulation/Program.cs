class Customer
{
    private int Id;
    //Full property
    public int CustomerID
    {
        get { return Id; }
        set { Id = value; }
    }
    //Automatic property
    public string CustomerName { get; set; } = "New Customer";
    public void print()
    {
        Console.WriteLine($"ID:{CustomerID}, Name:{CustomerName}");
    }
}

class Program
{
    static void Main()
    {
        Customer c = new Customer();
        c.CustomerID = 101;
        c.print();
        c.CustomerID = 101;

        c.CustomerName = "Mark";
        c.print();
        Console.ReadLine();
    }
}