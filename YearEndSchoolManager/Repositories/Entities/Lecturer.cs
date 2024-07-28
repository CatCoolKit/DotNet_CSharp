using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class Lecturer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Yob { get; set; }
        public double Salary { get; set; }

        public Lecturer()
        {
        }

        public Lecturer(string id, string name, string email, int yob, double salary)
        {
            Id = id;
            Name = name;
            Email = email;
            Yob = yob;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Email: {Email}, Yob: {Yob}, Salary: {Salary}";
        }

        public void ShowProfile()
        {
            Console.WriteLine(ToString());
        }
    }
}
