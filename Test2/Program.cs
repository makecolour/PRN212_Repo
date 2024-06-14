
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Student student = new Student();
    //        student.Id = 1;
    //        Console.WriteLine(Student);
    //        Console.WriteLine("Hello, World!");
    //    }
    //}


    Student st = new Student();
    st.Id = 1;
Console.WriteLine(st);

class Student
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }// full property

        public string Name { get; set; } = "Nguyen Van A";//Auto Property

        public override string ToString()
        {
            return $"Student id = {id}, name = {Name}";
        }
    }

