namespace ActionGenericDelegate
{
    delegate void MyAction<T>(T arg);
    delegate void OneInputNoOutPutDelegate(double x);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge #6 - Call method as normal");
            ComputeExponent(5);
            Console.WriteLine();

            Console.WriteLine("Challenge #7 - Call method using lambda");
            OneInputNoOutPutDelegate f = (x) => Console.WriteLine($"The result {x}^2 is {Math.Pow(x, 2)}");
            f(5);
            Console.WriteLine();

            Console.WriteLine("Challenge #8 - Using Action<> - Generic on the method with up to 16 16 params");
            Action<double> f2 = ComputeExponent;
            f2(5);
            Console.WriteLine();

            Console.WriteLine("Challenge #9 - Tính mũ 3 của một con số in ra, dùng luôn anonymous & lambda ex");
            Action<double> f3 = x => Console.WriteLine($"The result {x}^3 is {Math.Pow(x, 3)}");
            //Action<int> f3 = delegate (int x) { Console.WriteLine($"The result {x}^3 is {Math.Pow(x, 3)}"); };
            f3(5);
            Console.WriteLine();

            Console.WriteLine("Challenge #10 - Tính diện tích hình chữ nhật - Width, Length");
            Action<double, double> f4 = (w, l) => Console.WriteLine($"The area of the rectangle with width {w} and length {l} is {w * l}");
            f4(5, 10);
            Console.WriteLine();

            Console.WriteLine("Challenge #11 - In ra các số chẵn từ 1 đến N");
            Action<int> f5 = n =>
            {
                if (n < 1)
                {
                    Console.WriteLine(
                    "The number must be greater than 0");
                    return;
                }
                Console.WriteLine($"The list of even numbers from 1..{n}");
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
            };
            f5(10);
            Console.WriteLine();

        }

        static void ComputeExponent(double x)
        {
            double result = Math.Pow(x, 2);
            Console.WriteLine($"The result {x}^2 is {result}");
        }
    }
}
