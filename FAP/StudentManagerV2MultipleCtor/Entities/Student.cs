using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2MultipleCtor.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

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

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return $"Id: {_id} | Name: {_name} | Yob: {_yob} | Gpa: {_gpa}";
        }

        public string GetName() => _name;
        public void SetName(string name) => _name = name;
        public string GetId() => _id;
        public void SetId(string id) => _id = id;
        public int GetYob() => _yob;
        public double GetGgpa() => _gpa;
        public void SetYob(int yob) => _yob = yob;
        public void SetGpa(double gpa) => _gpa = gpa;
    }
}
