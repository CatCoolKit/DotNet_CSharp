namespace PredicateDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge #17 - Nhận GPA >= 8 là true, < 8 là  fasle");
            Predicate<double> predicate = x => x >= 8;
            Console.WriteLine("GPA 8.5 is " + predicate(8.5));
            Console.WriteLine("GPA 7.5 is " + predicate(7.5));

            var x = 2004.715;

            var fx = (double a, double b, double c) => a + b + c;
            Console.WriteLine(fx(1, 2, 3));
            Func<double, double, double, double> func = (a, b, c) => a + b + c;
            Console.WriteLine(func(1, 2, 3));

        }
    }
}
