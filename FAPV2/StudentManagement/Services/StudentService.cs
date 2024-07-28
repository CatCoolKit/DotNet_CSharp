using StudentManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Services
{
    public class StudentService
    {
        private Student[] _arr = new Student[30];
        private int _count = 0;

        public StudentService(int size)
        {
            _arr = new Student[size];
        }

        public StudentService()
        {

        }

        public void Add(Student student)
        {
            if (_count == _arr.Length)
            {
                Console.WriteLine("Array is full");
                return;
            }
            _arr[_count] = student;
            _count++;
        }
        public void Update(Student student)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_arr[i].Id == student.Id)
                {
                    _arr[i] = student;
                    return;
                }
            }
            Console.WriteLine("Student not found");
        }

        public void Show()
        {
            for (int i = 0; i < _count; i++)
            {
                _arr[i].show();
            }
        }
    }
}
