using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV11PropertyAutoBackingField.Entities
{
    internal class Student
    {
        public string Id { get; set; } // Auto-implemented property, no need to declare backing field explicitly
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }
    }
}
