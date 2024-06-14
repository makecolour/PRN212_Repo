
namespace DemoLambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = {"David", "Nina", "Mike", "Sara"};
            foreach (string n in name.OrderBy(s => s))
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}