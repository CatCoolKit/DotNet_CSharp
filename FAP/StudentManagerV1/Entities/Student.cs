using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV1.Entities
{
    public class Student
    {
        private string _id; //đặc điểm, field, attribute, state
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

        public void SetId(string id)
        {
            _id = id;
        }
        public string GetId()
        {
            return _id;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name) => _name = name;
        public int GetYob() => _yob;
        public void SetYob(int yob) => _yob = yob;
        public double GetGpa() => _gpa;
        public void SetGpa(double gpa) => _gpa = gpa;

        public override string ToString()
        {
            return $"Id: {_id}, Name: {_name}, Yob: {_yob}, Gpa: {_gpa}";
        }

    }
}
