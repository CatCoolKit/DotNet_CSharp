namespace DelegateReview.LambdaEx
{
    public delegate void NoInputNoOutputDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            //In tổng số từ 0 đến 100
            NoInputNoOutputDelegate noInputNoOutputDelegate = () =>
            {
                Console.WriteLine("Printing sum from 0 to 100.");
                int sum = 0;
                for (int i = 0; i <= 100; i++)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
                Console.WriteLine();
            };
            noInputNoOutputDelegate();

            //In số lẻ từ 0 đến 100
            noInputNoOutputDelegate = () =>
            {
                Console.WriteLine("Printing sum odd from 0 to 100.");
                int sum = 0;
                for (int i = 0; i <= 100; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += i;
                    }
                }
                Console.WriteLine(sum);
                Console.WriteLine();
            };
            noInputNoOutputDelegate();

            //In số chẵn từ 0 đến 100
            noInputNoOutputDelegate = () =>
            {
                Console.WriteLine("Printing sum even from 0 to 100.");
                int sum = 0;
                for (int i = 0; i <= 100; i++)
                {
                    if (i % 2 == 0)
                    {
                        sum += i;
                    }
                }
                Console.WriteLine(sum);
                Console.WriteLine();
            };
            noInputNoOutputDelegate();
        }
    }
}
