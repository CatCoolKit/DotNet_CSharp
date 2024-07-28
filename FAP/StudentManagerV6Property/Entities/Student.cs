using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV6Property.Entities
{
    internal class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        public string Id 
        {
            get { return _id; }
            set => _id = value;
        }

        public string GetId()
        {
            return _id;
        }
        public void SetId(string value)
        {
            _id = value;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string value)
        {
            _name = value;
        }
         public int GetYob()
        {
            return _yob;
        }
        public void SetYob(int value)
        {
            _yob = value;
        }
        public double GetGpa()
        {
            return _gpa;
        }
        public void SetGpa(double value) 
        {
            _gpa = value;
        }

    }
}
