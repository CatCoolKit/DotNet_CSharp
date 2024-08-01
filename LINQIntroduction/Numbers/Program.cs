namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintListDemand(i => i % 2 == 0);
            //PrintListDemand(i => i % 2 != 0);
            //PrintListDemand(i => i > 3);
            //PrintListDemand(i => i < 3);
            PlayWithBuiltInOnDemand();

        }

        static void PlayWithBuiltInOnDemandV2()
        {
            List<int> ints = new List<int> { 1, 2, 3, 4, 5 };
            var result = from x in ints where x % 2 == 0 select x;

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }

            static void PlayWithBuiltInOnDemand()
        {
            List<int> ints = new List<int> { 1, 2, 3, 4, 5 };
            //1. in toàn bộ
            Console.WriteLine("All==========================");
            ints.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();

            //2. in số chẵn
            Console.WriteLine("Even==========================");
            ints.ForEach(i =>
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            });
            Console.WriteLine();

            //3. in số lẻ
            Console.WriteLine("Odd==========================");
            //ints.Where(i => i % 2 != 0).ToList().ForEach(i => Console.Write(i + " "));
            List<int> ints1 = ints.Where(i => i % 2 != 0).ToList();
            ints1.ForEach(i => Console.Write(i + " "));
        }

        static void PrintListDemand(Predicate<int> f)
        {
            List<int> ints = new List<int> { 1, 2, 3, 4, 5 };
            foreach (int i in ints)
            {
                if (f(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
