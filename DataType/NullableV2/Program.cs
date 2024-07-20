namespace NullableV2
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double? _gpa;

        public Student(string id, string name, int yob, double? gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        public void ShowProfile()
        {
            Console.WriteLine($"ID: {_id}, Name: {_name}, YOB: {_yob}, GPA: {_gpa}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //double gpa = null;
            //Console.WriteLine(gpa);
            double? gpa = null;
            Console.WriteLine(gpa);
        }
    }
}
