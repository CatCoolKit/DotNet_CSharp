using StudentManagerV7Encapsulation.Entities;

namespace StudentManagerV7Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithGetSetWithoutEncapsulation();
        }

        static void PlayWithGetSetWithoutEncapsulation()
        {
            Student student = new Student();
            Console.WriteLine($"Get Id: {student.Id}");
            student.Id = "S01";
            Console.WriteLine($"Set Id: {student.Id}");
        }

        static void PlayWithGetSet()
        {
            int yob = 2004;
            Console.WriteLine($"Yob: {yob}");
            int age = 2021 - yob;
            Console.WriteLine($"Age: {age}");
        }
    }
}
