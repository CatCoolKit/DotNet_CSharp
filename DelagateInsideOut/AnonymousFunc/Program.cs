namespace AnonymousFunc
{
    delegate void PlayNumberDelegate(int i);
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Play methods with an input and return nothing-void");
        //    PlayNumberDelegate playNumberDelegate = CloneNumbers;
        //    playNumberDelegate += PowerBy2Numbers;
        //    playNumberDelegate(5);
        //}

        //static void Main(string[] args)
        //{
        //    //Cách 1
        //    //PlayNumberDelegate playNumberDelegate = CloneNumbersLikeGoldFormat;
        //    //playNumberDelegate(9);

        //    //Cách 2 Anonymous method
        //    PlayNumberDelegate playNumberDelegate = delegate (int i)
        //    {
        //        Console.WriteLine($"{i}{i}{i}{i}");
        //    };
        //    playNumberDelegate(9);
        //}

        static void Main(string[] args)
        {
            //PlayNumberDelegate playNumberDelegate = delegate (int i)
            //{
            //    Console.WriteLine($"The {i}^5 = {i * i * i * i * i}");
            //};  
            PlayNumberDelegate playNumberDelegate = delegate (int i)
            {
                Console.WriteLine($"The {i}^5 = {Math.Pow(i, 5)}");
            };
            playNumberDelegate(5);
        }

        static void CloneNumbers(int i) => Console.WriteLine($"{i}{i}{i}");

        static void PowerBy2Numbers(int i) => Console.WriteLine($"The {i}^2 = {i * i}");

        static void CloneNumbersLikeGoldFormat(int i) => Console.WriteLine($"{i}{i}{i}{i}");
    }
}
