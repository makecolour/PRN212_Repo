class Program
{
    static int Sum(int a, int b) => a + b;

    static void Print(string msg) => Console.WriteLine(msg.ToUpper());

    static void Main()
    {
        int a = 15, b = 25, s;
        String strResult;
        Func<int, int, int> sumFunc = Sum;
        s = sumFunc(a,b);
        strResult = $"{a} + {b} = {s}";
        Console.WriteLine("***Invoke Print method by Action delegate***");
        Action<string> action = Print;
        action(strResult);
        Console.ReadLine();
    }
}