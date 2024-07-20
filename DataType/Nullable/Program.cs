namespace Nullable
{
    public delegate void MyDelegate(string message);

    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithNullV3();
        }
        static void PlayWithNullV4()
        {
            Student student1 = null;
            Student student2 = student1 ?? new Student("SE2", "Hung", 2003, 8.6);
            student2?.ShowProfile();
            student1 = new Student("SE1", "An", 2004, 8.6);

            Student student3 = student1 ?? new Student("SE4", "Khang", 2003, 8.6);
            student3?.ShowProfile();
        }
        static void PlayWithNullV3()
        {
            Student student1 = null;
            student1?.ShowProfile();
            student1 = new Student("SE1", "An", 2004, 8.6);
            student1?.ShowProfile();
            Student student2 = student1;
            student2._gpa = 9.0;
            student1?.ShowProfile();
        }
        static void PlayWithNullV2()
        {
            Student student1 = null;
            if(student1 != null)
            {
                student1.ShowProfile();
            }
            else
            {
                Console.WriteLine("Student is null");
            }
            Console.WriteLine("The new way to check null before using it");
            student1?.ShowProfile();
        }

        static void PlayWithNull()
        {
            Student student;
            //student.ShowProfile();
            Student student1 = null;
            student1.ShowProfile();
        }

        static void CreateAsStudentObject()
        {
            Student student = new Student("SE1", "An", 2004, 8.6);
            student.ShowProfile();
        }
    }
}
