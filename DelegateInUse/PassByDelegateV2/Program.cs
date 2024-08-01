namespace PassByDelegateV2
{
    class Songs()
    {
        public static void PrintSongLyricsThe1()
        {
            Console.WriteLine("The song The 1 - by Taylor Swift");
            Console.WriteLine();
            Console.WriteLine(
              "I'm doing good, I'm on some new shit\n" +
                "Been saying 'yes' instead of 'no'\n" +
                "I thought I saw you at the bus stop, I didn't though\n" +
                "I hit the ground running each night\n" +
                "I hit the Sunday matinée\n" +
                "You know the greatest films of all time were never made\n" +
                "I guess you never know, never know\n" +
                "And if you wanted me, you really should've showed\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C#1: Call explicit method directly as normal");
            Songs.PrintSongLyricsThe1();

            Console.WriteLine("C#2: Call explicit method via delegate");
            Action action = Songs.PrintSongLyricsThe1;
            action.Invoke();

            Console.WriteLine("C#3: Call explicit method using Lambda or Anonymous");
            Console.WriteLine("The song The 1 - by Taylor Swift");
            Action f1 = () =>
            {
                Console.WriteLine("[Verse 1]\r\nI'm doing good, I'm on some new shit");
            };
            f1.Invoke();
        }
    }
}
