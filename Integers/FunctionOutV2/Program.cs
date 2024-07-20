namespace FunctionOutV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum, sumEven, sumOld, countEven, countOld;
            DoSomething(out sum, out sumEven, out sumOld, out countEven, out countOld);
            Console.WriteLine(
                $"Sum: {sum}, SumEven: {sumEven}, SumOld: {sumOld}, CountEven: {countEven}, CountOld: {countOld}");
        }

        /// <summary>
        /// <see langword="int"/> sum, sumEven, sumOld, countEven, countOld
        /// <see langword="int"/> array numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10} 
        /// </summary>
        /// <param name="sum"></param>
        /// <param name="sumEven"></param>
        /// <param name="sumOld"></param>
        /// <param name="countEven"></param>
        /// <param name="countOdd"></param>
        static void DoSomething(out int sum, out int sumEven, out int sumOld, out int countEven, out int countOdd)
        {
            sum = 0;
            sumEven = 0;
            sumOld = 0;
            countEven = 0;
            countOdd = 0;
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int number in numbers)
            {
                sum += number;
                if (number % 2 == 0)
                {
                    sumEven += number;
                    countEven++;
                }
                else
                {
                    sumOld += number;
                    countOdd++;
                }
            }
        }
    }
}
