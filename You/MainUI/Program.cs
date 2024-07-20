namespace MainUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void GetBmi() 
        {
            double weight = 0;
            double height = 0;
            double bmi = weight / (height * height);
            Console.WriteLine($"BMI (w: {weight} | h: {height}): {bmi} ");
        }
    }
}
