using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV10PropertyHotKey.Entities
{
    public class Student
    {
        private string _id; //Backing field
        //Field chống lưng cho property
        private string _name;
        private int _yob;
        private double _gpa;

        //propfull tab tab => tạo ra property đầy đủ
        //Kỹ thuật viết code gồm Backing field và get set style mới property gọi là kỹ thuât full property 

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Yob { get => _yob; set => _yob = value; }
        public double Gpa { get => _gpa; set => _gpa = value; }

    }
}
