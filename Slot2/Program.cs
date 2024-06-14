namespace name_of_namespace
{
    //Namespace
    //Class
    //Interface
    //Structures
    //Delegates

    //MyClass is the class in the namespace MyNamespace
    class MyClass
    {
        //Value types : int, float, double, char, bool, struct, enum

        //Reference types : class, interface, delegate, array
        //when declare a variable of a reference type,
        //the variable contains the value null until you explicitly create
        //an object by using the new operator
        static void Main()
        {
            //boxing: converting a value type to a reference type
            int i = 123;
            //boxing copies the values of i into object o
            object o = i;
            //change the value of i
            i = 456;
            Console.WriteLine("The Value-type value i is: " + i);
            Console.WriteLine("The Object-type value o is: " + o);

            //unboxing: converting a referency type to a value type
            int j = (int)o;
            Console.WriteLine("i = {0}, o= {1}, j = {2}", i, o, j);
            Console.ReadLine();

        }



    }
}