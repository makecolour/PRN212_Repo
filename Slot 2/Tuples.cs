//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Create tuples
//        (string MyString, int MyNumber) MyValues = ("Hello world!", 2050);
//        Console.WriteLine($"MyString: {MyValues.MyString}");
//        Console.WriteLine($"MyNumber: {MyValues.MyNumber}");
//        Console.ReadLine();
//    }


//    static (int sum, int count) MyMethod(int[] values)
//    {
//        // Declare a tuple
//        var r = (sum: 0, count: 0);

//        for (int i = 0; i < values.Length; i++)
//        {
//            if (IsEvenNumber(values[i]))
//            {
//                r.sum += values[i];
//                r.count++;
//            }
//        }

//        return r;
//    }

//    static bool IsEvenNumber(int n)
//    {
//        return n % 2 == 0;
//    }

//    static void Main(string[] args)
//    {
//        int[] numbers = { 2, 1, 5, 6, 3, 4, 7, 8, 10, 9 };
//        var (sum, count) = MyMethod(numbers);
//        Console.WriteLine($"Sum: {sum}, Count: {count}");
//        Console.ReadLine();
//    }
//}



