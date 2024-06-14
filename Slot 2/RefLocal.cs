//using System;

//class Program
//{
//    static int[] numbers = { 1, 2, 3, 4, 5 };

//    static ref int FindNumber(int target)
//    {
//        for (int ctr = 0; ctr < numbers.Length; ctr++)
//        {
//            if (numbers[ctr] == target)
//            {
//                return ref numbers[ctr];
//            }
//        }

//        throw new ArgumentException("Target not found");
//    }

//    static void Main(string[] args)
//    {
//        Console.Write("Original sequence: ");
//        Console.WriteLine(string.Join(" ", numbers));

//        ref int value = ref FindNumber(3);
//        value *= 2;

//        Console.Write("New sequence: ");
//        Console.WriteLine(string.Join(" ", numbers));

//        Console.ReadLine();
//    }
//}
