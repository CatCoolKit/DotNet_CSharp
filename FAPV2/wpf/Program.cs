using wpf.Entities;

namespace wpf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithStudentArrayV1();
        }

        static void PlayWithStudentArrayV1()
        {
            Student[] students = new Student[5];
            students[0] = new Student(1, "A", "HN", "123");
            students[1] = new Student(2, "B", "HN", "123");
            students[2] = new Student(3, "C", "HN", "123");
            students[3] = new Student(4, "D", "HN", "123");
            students[4] = new Student(5, "E", "HN", "123");
            foreach (Student student in students)
            {
                student.show();
            }
        }
    }
}
