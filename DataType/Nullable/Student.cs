using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    internal class Student
    {
        //gọi là field, attribute
        //instance variable nếu không có static
        //class level variable nếu có static
        private string _id; 
        private string _name;
        private int _yob; 
        public double _gpa;

        public Student()
        {

        }

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        //show profile
        public void ShowProfile()
        {
            Console.WriteLine($"ID: {_id}");
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"YOB: {_yob}");
            Console.WriteLine($"GPA: {_gpa}");
        }

    }
}
