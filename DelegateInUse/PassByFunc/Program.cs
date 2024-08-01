namespace PassByFunc
{
    internal class Program
    {
        static private List<int> _list = new List<int> { 1, 2, 3, 4, 5, 10, 15, 20, 25, 30, -5, -6, -7, -8 };
        static void Main(string[] args)
        {

            //1. in ra số chẵn
            Console.WriteLine("Tong so chan: ");
            SumDemand(CheckEven);
            Console.WriteLine();
        }

        public static void SumDemand(Predicate<int> f)
        {
            int result = 0;
            foreach (var x in _list)
            {
                if (f(x) == true)
                {
                    result += x;
                }
            }
            Console.WriteLine($"Tong so chan la: {result}");
        }

        public static void DoOnDemand(Func<int, bool> f)
        {
            int result = 0;
            foreach (var x in _list)
            {
                if (x > 0)
                {
                    result += x;
                }
            }
        }

        static bool CheckEven(int x)
        {
            return x % 2 == 0;
        }
    }
}
