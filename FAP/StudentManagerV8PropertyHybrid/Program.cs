using StudentManagerV8PropertyHybrid.Entities;

namespace StudentManagerV8PropertyHybrid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Id = "S001";
            s1.Name = "John";
            s1.Yob = 2000;
            s1.Gpa = 3.5;
            Console.WriteLine(s1.ToString());

            Student s2 = new Student() { Id = "S002", Name = "WonJi", Yob = 2001, Gpa = 3.4 };
            Console.WriteLine(s2.ToString());

            Student s3 = new Student()
            {
                Id = "S003",
                Name = "HoSung",
                Yob = 2001,
                Gpa = 3.4
            };
            Console.WriteLine(s3.ToString());

        }
    }
}
