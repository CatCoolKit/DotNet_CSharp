using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2.Entities
{
    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public double Gpa { get; set; }

        public Student()
        {
        }

        public Student(string name, string email, string phoneNumber, string address, DateTime birthDate)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, Phone Number: {PhoneNumber}, Address: {Address}, Birth Date: {BirthDate}";
        }

        public void ShowProfile()
        {
            Console.WriteLine(this);
        }
    }
}
