using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }

        public Student()
        {
        }

        public Student(int id, string name, DateTime dateOfBirth, string address, string phone, string city)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            Address = address;
            Phone = phone;
            City = city;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, DateOfBirth: {DateOfBirth}, Address: {Address}, Phone: {Phone}, City: {City}";
        }

        public void show()
        {
            Console.WriteLine(ToString());
        }
    }
}
