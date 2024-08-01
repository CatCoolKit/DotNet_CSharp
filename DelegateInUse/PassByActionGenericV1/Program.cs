namespace PassByActionGenericV1
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("C#1: Call explicit method directly as normal");
        //    KiemTraSoNguyenTo(7);

        //    Console.WriteLine("C#2: Call explicit method via delegate");
        //    Action<int> action = KiemTraSoNguyenTo;
        //    action(7);
        //    Console.WriteLine("C#3: Call explicit method via delegate with DoOnDemand method");
        //    //DoOndemand(() => KiemTraSoNguyenTo(7));
        //    DoOndemand(KiemTraSoNguyenTo);
        //}

        static void Main(string[] args)
        {
            Console.WriteLine("C#1: Kiem tra so nguyen to: ");
            DoOndemand(KiemTraSoNguyenTo);
            Console.WriteLine();

        }

        //static void DoOndemand(Action<int> f)
        //{
        //    Console.WriteLine("DoOnDemand: I'm doing something before calling the delegate");
        //    f(5);
        //    f(10);
        //}


        //Nếu có nhiều data đưa vào mảng cho linh hoạt
        static void DoOndemand(Action<int> f)
        {
            List<int> list = new List<int> { 5, 10, 15, 20, 25, 30 };
            Console.WriteLine("DoOnDemand: I'm doing something before calling the delegate");
            foreach (var item in list)
            {
                f(item);
            }
        }

        //static void DoOndemand(Action f)
        //{
        //    Console.WriteLine("DoOnDemand: I'm doing something before calling the delegate");
        //    f();
        //}

        static void KiemTraSoNguyenTo(int x)
        {
            Console.WriteLine("Kiem tra so nguyen to: ");
            if (x <= 1)
            {
                Console.WriteLine("So nguyen to phai bat dau tu 2");
                return;
            }
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    return;
                }
            }
            Console.WriteLine($"{x} la so nguyen to");
        }
    }
}
