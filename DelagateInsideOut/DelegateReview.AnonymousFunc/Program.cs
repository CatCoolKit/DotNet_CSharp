namespace DelegateReview.AnonymousFunc
{
    public delegate void NoInputNoOutputDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Call func directly");
            PrintNumbers();

            Console.WriteLine("Call func via delegate");
            NoInputNoOutputDelegate printNumbers = PrintNumbers;
            printNumbers();

            Console.WriteLine("Call func via anonymous function");
            NoInputNoOutputDelegate printOddNumbers = delegate
            {
                Console.WriteLine("Printing odd numbers from 0 to 100.");
                for (int i = 0; i < 100; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            };
            printOddNumbers();

            //Vừa lẻ vừa chẵn
            Console.WriteLine("Even and Odd");
            printOddNumbers += PrintEvenNumbers;
            printOddNumbers();

        }

        static void PrintNumbers()
        {
         Console.WriteLine("Printing numbers from 0 to 100.");
            for (int i = 0; i < 100; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintEvenNumbers()
        {
            Console.WriteLine("Printing numbers from 0 to 100.");
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
