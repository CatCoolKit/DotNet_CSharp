namespace Numerology
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. in hết các số trong list
            Console.WriteLine("Danh sach so trong list: ");
            NumberService.PrintNumber(x => Console.Write(x + " "));
            Console.WriteLine();

            //2. in ra số nguyên tố
            Console.WriteLine("Danh sach so nguyen to: ");
            NumberService.PrintNumber(x =>
            {
                if (x <= 1)
                {
                    Console.WriteLine("So nguyen to phai bat dau tu 2");
                    return;
                }
                for (int i = 2; i <= Math.Sqrt(x); i++)
                {
                    if (x % i == 0)
                    {
                        Console.WriteLine($"{x} khong phai la so nguyen to");
                        return;
                    }
                }
                Console.WriteLine($"{x} la so nguyen to");
            });
            Console.WriteLine();

            //3. in ra số âm trong list
            Console.WriteLine("Danh sach so am: ");
            NumberService.PrintNumber(x =>
            {
                if (x < 0)
                {
                    Console.Write($"{x} ");
                }
            });
            Console.WriteLine();
        }
    }
}
