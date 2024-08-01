namespace LambdaExpression
{
    delegate void PlayNumberDelegate(int i);

    internal class Program
    {
        static void Main(string[] args)
        {
            //Cách 1
            PlayNumberDelegate playNumberDelegate = CloneNumbers;
            playNumberDelegate(9);
            //Cách 2 Lambda expression
            PlayNumberDelegate playNumberDelegate2 = (int i) => Console.WriteLine($"{i}{i}{i}{i}");
            playNumberDelegate2(9);
            //Cách 3 Anonymous method
            PlayNumberDelegate playNumberDelegate3 = delegate (int i)
            {
                Console.WriteLine($"{i}{i}{i}{i}");
            };
            playNumberDelegate3(9);
        }

        //Cách 1
        static void CloneNumbers(int i) => Console.WriteLine($"{i}{i}{i}"); //Expression body


    }
}
