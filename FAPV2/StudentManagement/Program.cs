using StudentManagement.Entities;
using StudentManagement.Services;

namespace StudentManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();
            studentService.Add(new Student(1, "John", new DateTime(2000, 1, 1), "123", "123", "HCM"));
            studentService.Add(new Student(2, "Peter", new DateTime(2000, 1, 1), "123", "123", "HCM"));
            studentService.Add(new Student(3, "Marry", new DateTime(2000, 1, 1), "123", "123", "HCM"));
            studentService.Add(new Student(4, "Tom", new DateTime(2000, 1, 1), "123", "123", "HCM"));
            studentService.Add(new Student(5, "Jerry", new DateTime(2000, 1, 1), "123", "123", "HCM"));

            studentService.Show();
            Console.WriteLine("Before update");

            studentService.Update(new Student(3, "Marry", new DateTime(2000, 1, 1), "456", "789", "FU-HCM"));

            studentService.Show();
        }
    }
}
