using StudentManagerV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2.Services
{
    public class LecturerCabinet
    {
        private Lecturer[] _lecturers;
        private int _size;

        public LecturerCabinet(int size)
        {
            _size = 0;
            _lecturers = new Lecturer[size];
        }

        public void AddLecturer(Lecturer lecturer)
        {
            Console.WriteLine($"There is/are {_size} lecturer(s) in the cabinet");
            if (_size == _lecturers.Length)
            {
                Console.WriteLine("Array is full");
                return;
            }

            for (int i = 0; i < _size; i++)
            {
                if (_lecturers[i].Email == lecturer.Email)
                {
                    Console.WriteLine("Email already exists");
                    return;
                }
            }

            _lecturers[_size] = lecturer;
            _size++;

        }

        public void ShowLecturers()
        {
            if (_size == 0)
            {
                Console.WriteLine("There is no lecturer in the cabinet");
                return;
            }
            for (int i = 0; i < _size; i++)
            {
                Console.WriteLine(_lecturers[i].ToString());
            }
        }
    }
}
