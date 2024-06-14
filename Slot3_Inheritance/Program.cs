using System.Globalization;

class Employee
{
    private int id;
    private string name;
    //Constuctor
    public Employee(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
    //Property
    public int ID
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

class Manager: Employee
{
    private string email;
    public Manager(int id, string name, string email) : base(id, name)
    {
        this.email = email;
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    
}

class Program
{
    static void Main()
    {
        Manager jack = new Manager(101, "Mark", "Jack@gmail.com");
        Console.WriteLine(jack);
        Console.ReadLine();
    }
}