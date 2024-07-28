using StudentManagerV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2.Services
{
    public class StudentCabinet
    {
        private Student[] _arr;
        private int _size;

        public StudentCabinet(int size)
        {
            _size = 0;
            _arr = new Student[size];
        }

        public void AddStudent(Student student)
        {
            Console.WriteLine($"There is/are {_size} student(s) in the cabinet");
            if (_size == _arr.Length)
            {
                Console.WriteLine("Array is full");
                return;
            }
              
            for (int i = 0; i < _size; i++)
            {
                if (_arr[i].Email == student.Email)
                {
                    Console.WriteLine("Email already exists");
                    return;
                }
            }

            _arr[_size] = student;
            _size++;
        }

        public void UpdateStudent(Student student)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_arr[i] != null && _arr[i].Email.Equals(student.Email))
                {
                    _arr[i] = student;
                    break;
                }
            }
        }

        public void ShowStudents()
        {
            if(_size == 0)
            {
                Console.WriteLine("There is no student in the cabinet");
                return;
            }
            for (int i = 0; i < _size; i++)
            {
                if (_arr[i] != null)
                {
                    Console.WriteLine(_arr[i]);
                }
            }
        }
    }
}
