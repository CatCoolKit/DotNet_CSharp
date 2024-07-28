using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV3EmptyCtor.Entities
{
    internal class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        public Student()
        {
        }

        //public override string? ToString()
        //{
        //    return base.ToString();
        //}
        public override string? ToString()
        {
            return $"Id: {_id} | Name: {_name} | Yob: {_yob} | Gpa: {_gpa}";
        }

        public string GetName() => _name;
        public void SetName(string value) => _name = value;
        public string GetId() => _id;
        public void SetId(string value) => _id = value;
        public int GetYob() => _yob;
        public double GetGgpa() => _gpa;
        public void SetYob(int value) => _yob = value;
        public void SetGpa(double value) => _gpa = value;

    }
}
