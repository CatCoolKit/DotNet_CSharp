using Bmi;

namespace BmiTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bmi = BmiCalculator.GetBmi(80, 1.8);
        }
        public static double CalculateBmi(double weight, double height)
        {
            return weight / (height * height);
        }
    }
}
