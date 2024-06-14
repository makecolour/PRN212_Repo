class Program
{
    static void Main(string[] args)
    {
        int n1 = 35;
        int n2 = 45;
        int result;
        //Using lambda expression to add two numbers
        Func<int, int, int> addNumber = (a, b) => a + b;
        result = addNumber(n1, n2);
        Console.WriteLine($"Sum of {n1} and {n2} is {result}");
        Console.ReadLine();
    }
}