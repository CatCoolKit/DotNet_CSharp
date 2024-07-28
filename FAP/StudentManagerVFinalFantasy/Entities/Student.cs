using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerVFinalFantasy.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        //prop tab tab => public int MyProperty { get; set; }
        //Auto-implemented property => property tự động hiện thực hóa
    }
}
