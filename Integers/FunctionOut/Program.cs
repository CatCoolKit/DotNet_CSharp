namespace FunctionOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int n = 5;
            DoSomeThing(n);
            Console.WriteLine($"n = {n}");
            int m = 5;
            DoSomeThingV2(ref m);
            Console.WriteLine($"m = {m}");
            int o;
            DoSomeThingV3(out o);
            Console.WriteLine($"o = {o}");
        }
        static void DoSomeThing(in int n)
        {
            //n = 10; // Error: Cannot assign to variable 'in int' because it is a readonly variable
            Console.WriteLine($"n = {n}");
        }

        /// <summary>
        /// <see langword="int"/> is a value type, so it is passed by value by default.
        /// It have to default value, so it is not necessary to assign value to it.
        /// </summary>
        /// <param name="n"></param>
        static void DoSomeThingV2(ref int n)
        {
            n = 10;
            Console.WriteLine($"n = {n}");
        }

        /// <summary>
        /// <see langword="void"/> is a value type, so it is passed by value by default.
        /// </summary>
        /// <param name="n"></param>
        static void DoSomeThingV3(out int n)
        {
            n = 10;
            Console.WriteLine($"n = {n}");
        }
    }
}
