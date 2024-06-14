//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Input data: ");
//        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
//        {
//            Console.WriteLine(new string('*', n));
//        }
//        else
//        {
//            Console.WriteLine("Data invalid.");
//        }
//        Console.ReadLine();
//    }
//}

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Input data: ");
//        int.TryParse(Console.ReadLine(), out int n);
//        switch (n)
//        {
//            case int count when count > 0:
//                Console.WriteLine(new string('*', count));
//                break;
//            default:
//                Console.WriteLine("Data invalid.");
//                break;
//        }
//        Console.ReadLine();
//    }
//}
