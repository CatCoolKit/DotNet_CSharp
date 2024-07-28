using StudentManagerV3EmptyCtor.Entities;

namespace StudentManagerV3EmptyCtor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine(s1.ToString());
        }
    }
}
