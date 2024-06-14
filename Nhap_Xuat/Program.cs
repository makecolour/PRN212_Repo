namespace Nhap_Xuat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");//tự động xuống dòng
            int a = 5;
            Console.WriteLine("a = " + a);
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("a = {0}, b = {1}, c = {2}", 1,4,3);
            //Console.WriteLine(Console.Read());
            // đọc từ bàn phím rồi trả về mã ascii, chỉ nhận được 1 ký tự
            //Console.WriteLine(Console.ReadLine());
            //đọc dữ liệu từ bàn phím cho đến khi gặp dấu enter
            Console.ReadKey();//ko truyen tham so auto = flase

            int value = 109;
            object objectValue = value; // boxing

            int newValue = (int)value; //unboxxing
            Console.ReadKey();//hiện phím ấn lên màn hình
        }
    }
}
