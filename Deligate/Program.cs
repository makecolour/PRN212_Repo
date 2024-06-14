namespace Deligate
{
    public delegate int MyDelegate(int numOne, int numTwo);
    internal class Program
    {
        static internal void Add(int numOne, int numTwo) { }


        public delegate int myDelegate(int x, int y);
        public int sum(int x, int y) => x + y;
        public int sub(int x, in int y) => x - y;
        public int multi(int x, int y) => x * y;

        static void Main(string[] args)
        {
            Program p = new Program();
            int x = 10, y = 3;
            myDelegate my = new myDelegate(p.sum);
            //
            Console.WriteLine($"Ket qua = {my(x,y)}");
            Console.ReadLine();
        }


    }

}
