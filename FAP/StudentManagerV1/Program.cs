using StudentManagerV1.Entities;

namespace StudentManagerV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("1", "Nguyen Van A", 2000, 3.5);
            student.ToString();

            Student student2 = new Student(name: "Nguyen Van B", gpa: 3.4, id: "SE1", yob: 2002);
        }
    }
}
