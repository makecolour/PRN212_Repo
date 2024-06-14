using System.Diagnostics.CodeAnalysis;
static (int sum, int count) MyMethod(int[] values)
{
    // declare a tuple
    var r = (sum: 0, count: 0);
    for (int i = 0; i < values.Length; i++)
    {
        if (IsEvenNumber(values[i]))
        {
            r.sum += values[i];
            r.count++;
        }
    }
    return r;
    bool IsEvenNumber(int n)
    {
        return (n % 2 == 0);
    }
}

int[] numbers = { 2, 1, 5, 6, 3, 4, 7, 8, 10, 9 };
var (sum, count) = MyMethod(numbers);
Console.WriteLine($"Sum: {sum}, Count: {count}");
Console.ReadLine();
