namespace ArrayBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number you want: ");
            int n = int.Parse(Console.ReadLine());
            int[] result = PlayWithIntegerListV1(n);
            Console.WriteLine("Result: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        static void PlayWithIntegerListV4()
        {
            int[] ints = new int[5];
        }

        static void PlayWithIntegerListV3()
        {
            int[] a = { 5, 10, 15, 20, 25, 30 };
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }

        static void PlayWithIntegerListV2()
        {
            int[] a = { 5, 10, 15, 20, 25, 30 };

            int[] a2 = [5, 10, 15, 20, 25, 30];

            int[] a3 = new int[5] { 5, 10, 15, 20, 25 };

            int[] a7 = { 5, 10, 15, 20, 25, 30 };

            int[] a4 = new int[] { 5, 10, 15, 20, 25 };

            int[] a5 = new int[5];
            a5[0] = 5;
            a5[1] = 10;
            a5[2] = 15;
            a5[3] = 20;
            a5[4] = 25;
            a5[5] = 30;

            int[] a6;
            a6 = new int[5];
            a6[0] = 5;

        }

        static int[] PlayWithIntegerListV1(int n)
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input a[" + i + "]: ");
                a[i] = int.Parse(Console.ReadLine());
            }

            return a;
        }
    }
}
