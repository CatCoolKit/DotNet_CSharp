using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        public Student()
        {
        }

        public Student(string id, string name, string email, int yob, double gpa)
        {
            Id = id;
            Name = name;
            Email = email;
            Yob = yob;
            Gpa = gpa;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Email: {Email}, Yob: {Yob}, Gpa: {Gpa}";
        }

        public void ShowProfile()
        {
            Console.WriteLine(ToString());
        }
    }
}
