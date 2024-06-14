namespace Slot2PRN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String msg = "Welcome to C#.NET Programming";
            Console.WriteLine("{0}", msg);
            for(int j = 0; j < args.Length; j++)
            {
                Console.WriteLine($"Arg: {args[j]}");
            }

            //dynamic
            dynamic myValue = 0;
            Console.WriteLine("myInt is a:{0}", myValue.GetType().Name);
            myValue = true;
            Console.WriteLine("myBool is a:{0}", myValue.GetType().Name);
            myValue = "Hello";
            Console.WriteLine("myString is a:{0}", myValue.GetType().Name);
            myValue = 0.5;
            Console.WriteLine("myInt is a:{0}", myValue.GetType().Name);

            //boxing and unboxing
            int value = 109;
            object objectValue = value; // boxing
            int newValue = (int)value; //unboxxing

            //String Interpolation
            double salary = 200.234;
            String name = "Soren";
            //Using curly-bracket syntax.
            String str1 = string.Format("Name: {0,6}, Salary: {1,7:N2}", name, salary);
            Console.WriteLine(str1);
            //Using string interpolation
            String str2 = $"Name: {name,7}, Salary: {salary,8:N2}";
            Console.WriteLine(str2);

            //Console Class
            double d;
            int i;
            String s;
            DateTime date;
            Console.WriteLine("Data Type Parsing");
            Console.WriteLine("Enter a String value: ");
            s = Console.ReadLine();
            Console.WriteLine("Enter a Double value: ");
            d = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Integer value: ");
            i = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter a Date value: ");
            //date = DateTime.Parse(Console.ReadLine());


             //      *** Numeric Literal Syntax  ***
              Console.WriteLine("**** Use Digit Separators *****");
                Console.Write("Integer: ");
                Console.WriteLine(123_456);
                Console.Write("Double:");
                Console.WriteLine(123_456.12);
                Console.Write("Hex: ");
                Console.WriteLine(0x_00_00_FF);
                Console.WriteLine("***** Use Binary Literals *****"); Console.WriteLine("Sixteen: {0}", 0b_0001_0000);
                Console.WriteLine("Thirty Two: {0}", 0b_0010_0000);
                Console.WriteLine("Sixty Four: {0}", 0b_0100_0000); 
             Console.ReadLine();


            //    ***  Passing Parameters with ref, out and params  ***

            static void MyMethod(int a, ref int b, out int c)
            {
                a = 3;
                b = 4;
                c = 5;
            }
                int x = 1, y = 2, z;
                MyMethod(x, ref y, out z);
                Console.WriteLine($"x:{x}, y:{y}, z:{z}");
                Console.ReadLine();


            static void SumArray(out int s, params int[] list)
            {
                int i;
                s = 0;
                for (i =0; i < list.Length; i++)  
                s += list[i];

            }
                int a;
                SumArray(out a, 1, 2, 3, 4); Console.WriteLine($"s={a}");
                int[] myIntArray = { 5, 6, 7, 8, 9 }; SumArray(out a, myIntArray);
                Console.WriteLine($"s={a}"); SumArray(out a);
                Console.WriteLine($"s={a}"); 
                Console.ReadLine();


            //Ref locals and Ref returns
            
                /*
                 static int[] numbers = { 1, 2, 3, 4, 5 };

                static ref int findnumber(int target)
                {
                    bool flag = true;
                    ref int value = ref numbers[0];
                    for (int ctr = 0; ctr < numbers.length && flag; ctr++)
                    {
                        if (numbers[ctr] == target)
                        {
                            value = ref numbers[ctr];
                            flag = false;
                            return ref value;
                        }
                    }
                    return ref value;
                } */


                    //Console.WriteLine("original sequence:");
                    //Console.WriteLine(string.Join(" ", numbers));

                    //ref int value2 = ref findnumber(3);
                    //value2 *= 2;

                    //Console.WriteLine("new sequence:");
                    //Console.WriteLine(string.Join(" ", numbers));

                
            }



            //   *** Local Function and Static Local Function ***

                int x1 = 1;
                int y1 = 2;

                // Local Function
                void AddValue(int a, int b)
                {
                    Console.WriteLine("Value of a is: " + a);
                    Console.WriteLine("Value of b is: " + b);
                    Console.WriteLine("Value of x is: " + x1);
                    Console.WriteLine("Value of y is: " + y1);
                    Console.WriteLine("Sum: {0}", a + b + x1 + y1);
                    Console.WriteLine();
                }

                //Calling the local function
                //AddValue(3, 4);
                //AddValue(5, 6);
                //Console.ReadLine();

            
            
             
                // AreaOfCircle is the local function of the main function
                void AreaOfCircle(double radius)
                {
                    double area = 3.14 * radius * radius;
                    Console.WriteLine("Radius of the circle: " + radius);
                    Console.WriteLine("Area of circle: " + area);

                    // Calling static local function
                    Circumference(radius);
                }

                // Circumference is the Static local function
                static void Circumference(double radius)
                {
                    double circumference = 2 * 3.14 * radius;
                    Console.WriteLine($"Circumference of the circle is: {circumference:N2}");
                }

                // Calling the AreaOfCircle function
                //AreaOfCircle(10);
                //Console.ReadLine();
            
            

            //     ***  Discards (_)  (dùng khi ta không quan tâm tới biến đó )  ***

            // 1.Using discard with out parameter 
                //string[] stringArray = { "12", "Hello", "3.14", "20" }; 
                //for (int i1 = 0; i1 < stringArray.Length; i1++)
                //{
                //    if (int.TryParse(stringArray[i1], out _))
                //     Console.WriteLine($"{stringArray[i]}: valid");
                //else

                //    Console.WriteLine($"{stringArray[i]}: invalid");
                //    Console.ReadLine();
                //}
            

            // 2.Using discard with Tuples
            //static (string first, string middle, string last) SplitNames(string fullName)
            //{
            //    string[] strArray = fullName.Split(' ');
            //    return (strArray[0], strArray[1], strArray[2]);
            //}
            //static void Main(string[] args)
            //{
            //    var (first, _, last) = SplitNames("Philip F Japikse"); // discard middle name
            //    Console.WriteLine($"{first}:{last}");
            //    Console.ReadLine();
            //}


            /*The swichcase
            - The switch statement cases also support patterns. These patterns can include a type check, plus additional conditions:  

            switch (i)
            {
                case int n when n > 100: ... break;
                case Car c: ... break;    //c is instance of Car
                case null:... break;
                case var j when (j.Equals(10)):... break;
                default:... break;
            */



            /*
            Console.Write("Input data: ");
            int.TryParse(Console.ReadLine(), out int n);
            if (n is int count && count > 0)
            {
                Console.WriteLine(new string('*', count));
            }
            else
            {
                Console.WriteLine("Data invalid.");
                Console.ReadLine();
            }
            static void Main(string[] args)
            {
                Console.Write("Input data:");
                int.TryParse(Console.ReadLine(), out int n); switch (n)
                {
                    case int count when count > 0:
                        Console.WriteLine(new string('*', count));
                        break;
                    default:
                        Console.WriteLine("Data invalid.");
                        break;
                        Console.ReadLine();
                }
            }*/

            //using System;
            //   Null-Condition Operator

            /*Trong C#, Null-Conditional Operator (toán tử điều kiện null) được giới thiệu trong C# 6.0, cho phép bạn truy cập các thành viên của một đối tượng một cách an toàn mà không cần kiểm tra null trước. Toán tử này giúp đơn giản hóa mã và tránh các lỗi NullReferenceException.

            Có hai dạng toán tử điều kiện null:

            Toán tử ?.: Được sử dụng để truy cập một thành viên của một đối tượng chỉ khi đối tượng đó không phải là null.
            Toán tử ??: Được sử dụng để cung cấp một giá trị mặc định nếu biểu thức bên trái là null.
            Ví dụ về Toán tử ?.*/

            /*    int[] array1 = null;
                Console.WriteLine($"{array1?.Length.ToString() ?? "Array is empty."}"); array1 = new int[] { 2, 1, 3 };
                dynamic[] array2 = { array1, null };
                var s = array2?[0]?.Length ?? "Array is empty.";
                Console.WriteLine($"{s}");
                s = array2?[1]?.Length ?? "Array is empty."; Console.WriteLine($"{s}");*/


            //   Nullable value types
            /*class Program
            {
                static double? pi = 3.14;
                static char? letter = 'a';
                static int m2 = 10;
                static int? m = m2;
                static bool? flag = null;
                // An array of a nullable value type
                static int?[] arr = new int?[10];

                static void Main(string[] args)
                {
                    int? a = null;
                    if (a is null)
                    {
                        Console.WriteLine("a does not have a value");
                        a = 2050;
                        if (a is int valueOfA)
                        {
                            Console.WriteLine($"a is {valueOfA}");
                        }
                    }

                    Console.ReadLine();
                }
            }*/

            //   Nullable reference types 
            /*class Program
            {
                static void PrintFullName(string first, string? middle, string last)
                {
                    Console.WriteLine(middle?.Length);
                    Console.WriteLine(first + middle + last);
                }

                static void Main(string[] args)
                {
                    string firstName = "Mike ";
                    string? middleName = null;
                    string lastName = "John";

                    PrintFullName(firstName, middleName, lastName);
                    Console.ReadLine();
                }
            }*/
            //   Primary Constructors for Classes and Structs

            /*public class Person
            {
                public string FirstName { get; set; }
                public string LastName { get; set; }

                public Person(string firstName, string lastName)
                {
                    FirstName = firstName;
                    LastName = lastName;
                }

                public override string ToString()
                {
                    return $"{FirstName} {LastName}";
                }
            }

            class Program
            {
                static void Main(string[] args)
                {
                    Person person = new Person("John", "Doe");
                    Console.WriteLine(person);
                }
            }*/

            //   Alias Any Type
            //using System.IO;
            //using System.Threading.Tasks;

            // Khai báo alias cho tuple
            /*using Point = System.ValueTuple<int, int>;

            internal partial class Program
            {
                private static async Task Main(string[] args)
                {
                    // Khởi tạo Point
                    Point p = (3, 5);
                    Console.WriteLine($"({p.Item1}, {p.Item2})");

                    // Đảm bảo file "data.txt" tồn tại trong cùng thư mục với tệp thực thi
                    using var file = File.OpenRead("data.txt");
                    using var reader = new StreamReader(file);

                    // Đọc dòng từ file
                    string line = await reader.ReadLineAsync();
                    Console.WriteLine(line);
                }
            }*/


    }
}

