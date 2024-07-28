using StudentManagerV2.Entities;
using StudentManagerV2.Services;
using System.Collections;

namespace StudentManagerV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentCabinet studentCabinet = new StudentCabinet(30);
            studentCabinet.AddStudent(new Student("John", "john@gmail.com", "123456789", "Hanoi", new DateTime(2000, 1, 1)));
            studentCabinet.AddStudent(new Student("Alice", "alice@gmail.com", "987654321", "Hanoi", new DateTime(2000, 1, 1)));
            studentCabinet.AddStudent(new Student("Bob", "bob@gmail.com", "123456789", "Hanoi", new DateTime(2000, 1, 1)));

            studentCabinet.ShowStudents();

            Console.WriteLine("-----------------------------------------");

            LecturerCabinet lecturerCabinet = new LecturerCabinet(30);
            lecturerCabinet.AddLecturer(new Lecturer("Lecturer Alice", "alice@gmail.com", "123456789", "Hanoi", new DateTime(2000, 1, 1)));
            lecturerCabinet.AddLecturer(new Lecturer("Lecturer Bob", "bob@gmail.com", "987654321", "Hanoi", new DateTime(2000, 1, 1)));
            lecturerCabinet.AddLecturer(new Lecturer("Lecturer John", "john@gmail.com", "123456789", "Hanoi", new DateTime(2000, 1, 1)));

            lecturerCabinet.ShowLecturers();

            Console.WriteLine("-----------------------------------------");

        }
    }
}
