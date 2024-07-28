namespace MainUIV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Hello");
            list.Add("World");
            list.Add("!");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
