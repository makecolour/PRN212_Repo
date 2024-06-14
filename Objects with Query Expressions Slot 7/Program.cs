static void Main(string[] args)
{
    //Declare and intialize an array of strings
    string[] names = { "David", "Jane", "Peter", "John" };
    var items = from word in names
                where word.Contains("a")
                select word;
    foreach (string s in items)
    {
        Console.WriteLine(s);
    }
    Console.ReadLine();
}