using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerology
{
    public class NumberService
    {
        static private List<int> _list = new List<int> { 1, 2, 3, 4, 5, 10, 15, 20, 25, 30, -5, -6, -7, -8 };

        public static void PrintNumber(Action<int> f)
        {
            foreach (var x in _list)
            {
                f(x);
            }
        }
    }
}
