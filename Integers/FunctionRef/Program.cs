namespace FunctionRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;
            DoSomething(n, out int sum, out int sumEven, out int sumOld, out int countEven, out int countOdd);
            System.Console.WriteLine(
                $"Sum: {sum}, SumEven: {sumEven}, SumOld: {sumOld}, CountEven: {countEven}, CountOld: {countOdd}");
        }

        /// <summary>
        ///  <see langword="int"/> is a value type, so it is passed by value by default.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="sum"></param>
        /// <param name="sumEven"></param>
        /// <param name="sumOld"></param>
        /// <param name="countEven"></param>
        /// <param name="countOdd"></param>
        static void DoSomething(in int n, out int sum, out int sumEven, out int sumOld, out int countEven, out int countOdd)
        {
            sum = 0;
            sumEven = 0;
            sumOld = 0;
            countEven = 0;
            countOdd = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
                if (i % 2 == 0)
                {
                    sumEven += i;
                    countEven++;
                }
                else
                {
                    sumOld += i;
                    countOdd++;
                }
            }
        }
    }
}
