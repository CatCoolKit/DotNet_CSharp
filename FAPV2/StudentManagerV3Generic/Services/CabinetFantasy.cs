using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV3Generic.Services
{
    public class CabinetFantasy<T>
    {
        private T[] _cabinet;
        private int _currentIndex;

        public CabinetFantasy(int size)
        {
            _cabinet = new T[size];
            _currentIndex = 0;
        }

        public void Add(T item)
        {
            if (_currentIndex == _cabinet.Length)
            {
                Console.WriteLine("Cabinet is full!");
                return;
            }
            _cabinet[_currentIndex] = item;
            _currentIndex++;
        }

        public void Remove(T item) {
            for (int i = 0; i < _cabinet.Length; i++)
            {
                if (_cabinet[i].Equals(item))
                {
                    _cabinet[i] = default(T);
                    _currentIndex--;
                    return;
                }
            }
            Console.WriteLine("Item not found!");
        }

        public void Display()
        {
            foreach (var item in _cabinet)
            {
                if (item != null)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
