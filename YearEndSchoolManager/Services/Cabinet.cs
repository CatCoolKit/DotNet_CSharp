using Repositories.Entities;

namespace Services
{
    public class Cabinet<T>
    {
        //private Student[] students = new Student[300];
        //private Lecturer[] lecturers = new Lecturer[300];

        private T[] _list = new T[300];
        private int _count = 0;

        public void Add(T item)
        {
            if (_count >= _list.Length)
            {
                throw new System.Exception("Cabinet is full");
            }
            _list[_count] = item;
            _count++;
        }

        public void GetAll()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_list[i]);
            }
        }
    }
}
