namespace FuncDelegate
{
    delegate TResult MyFunc<T, TResult>(T arg);
    delegate double OneInputOneOutPut(double x);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge #12 - Method return value");
            OneInputOneOutPut f = ComputeExponent;
            double result = f(5);
            Console.WriteLine($"The result is {result}");
            Console.WriteLine();

            Console.WriteLine("Challenge #13 - Using Func<> - Generic on the method with up to 16 16 params");
            Func<double, double> f2 = (x) => { return x * x; };
            double result2 = f2(5);
            Console.WriteLine($"The result is {result2}");
            Console.WriteLine();

            Console.WriteLine("Challenge #14 - Tính chu vi tam giác");
            Func<double, double, double, double> f3 = (a, b, c) => { return a + b + c; };
            double result3 = f3(3, 4, 5);
            Console.WriteLine($"The perimeter of the triangle with 3 sides {3}, {4}, {5} is {result3}");
            Console.WriteLine();

            Console.WriteLine("Challenge #15 - Trả về một con số bất kỳ");
            Random random = new Random();
            Func<double> f4 = () => { return random.Next(); };
            double result4 = f4();
            Console.WriteLine($"The random number is {result4}");
            Console.WriteLine();

            Console.WriteLine("Challenge #16 - Nhận GPA >= 8 là true, < 8 là  fasle");
            Func<double, bool> f5 = (gpa) =>
            {
                if (gpa >= 8)
                {
                    return true;
                }
                return false;
            };
            bool result5 = f5(8.5);
            Console.WriteLine($"The result is {result5}");
            Console.WriteLine();

        }

        static double ComputeExponent(double x)
        {
            return x * x;
        }
    }
}
