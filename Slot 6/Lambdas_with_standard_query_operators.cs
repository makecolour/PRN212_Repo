using System;
using System.Linq;

namespace DemoLambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize an array of strings
            string[] names = { "David", "Jane", "Peter", "John", "Mark" };

            // Use a lambda expression to sort the array
            foreach (string item in names.OrderBy(s => s))
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
