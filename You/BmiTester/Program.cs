using Bmi;

namespace BmiTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = BmiCalculator.GetBmi(70, 1.7);
            Console.WriteLine(result);
        }
    }
}
