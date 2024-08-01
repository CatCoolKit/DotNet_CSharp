namespace DelegateReview.LambdaEx.V2
{
    delegate void OneInputNoOutputDelegate(int n);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Enter a number to print the list of numbers from 1 to that number");
            int n = int.Parse(Console.ReadLine());
            //OneInputNoOutputDelegate oneInputNoOutputDelegate = n => PrintIntegerList(n);
            OneInputNoOutputDelegate oneInputNoOutputDelegate = PrintIntegerList;
            oneInputNoOutputDelegate(n);
        }

        private static void PrintIntegerList(int n)
        {
            if (n < 1)
            {
                Console.WriteLine("The number must be greater than 0");
                return;
            }
            Console.WriteLine("The list of numbers from 1 to " + n);
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
