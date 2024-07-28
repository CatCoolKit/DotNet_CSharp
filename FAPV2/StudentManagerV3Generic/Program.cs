namespace StudentManagerV3Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1;
            object o1 = n1;
            string s1 = (string)o1;
            Console.WriteLine(s1);
        }

        public static void PrintMenu()
        {
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. List Students");
            Console.WriteLine("3. Search Students");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter a number to select an option from the menu: ");
            Console.ReadLine();

        }
    }
}
