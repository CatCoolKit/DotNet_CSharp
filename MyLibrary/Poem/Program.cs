using Poem.XuanQuynh;

namespace Poem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Song.PrintSongCode();
        }
        static void PrintPoem()
        {
            int year = 2024;

            Console.WriteLine("Roses are red,");
            Console.WriteLine("Violets are blue,");
            Console.WriteLine("Sugar is sweet,");
            Console.WriteLine("And so are you.");

            //interpolation
            Console.WriteLine($"The year is {year}");

            Console.WriteLine(@"Roses are red
Violets are blue
Sugar is sweet"); // This is a verbatim string
            Console.WriteLine(
                "Roses are red\n" +
                "Violets are blue\n" +
                "Sugar is sweet"); // This is a string concatenation
            Console.WriteLine(
                "Roses are red" + Environment.NewLine +
                "Violets are blue" + Environment.NewLine +
                "Sugar is sweet"); // This is a string concatenation with Environment.NewLine

        }
    }
}
