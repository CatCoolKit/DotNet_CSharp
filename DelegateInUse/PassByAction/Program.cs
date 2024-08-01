namespace PassByAction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoOnDemand(() =>
            {
                Console.WriteLine("The song The 1 - by Taylor Swift");
                Console.WriteLine();
                Console.WriteLine(
                    "[Verse 1]\r\nI'm doing good, I'm on some new shit");
            });
        }

        static void DoOnDemand(Action f)
        {
            Console.WriteLine("DoOnDemand: I'm doing something before calling the delegate");
            f();
        }
    }
}
