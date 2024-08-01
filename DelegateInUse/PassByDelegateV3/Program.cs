namespace PassByDelegateV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("C#1: Call explicit method directly as normal");
            //PrintSongLyricsThe1();
            //PrintSongLyricsLover();

            //Console.WriteLine("C#2: Call explicit method via delegate");
            //Action action = PrintSongLyricsThe1;
            //action();
            //action = PrintSongLyricsLover;
            //action.Invoke();

            Console.WriteLine("C#3: Call explicit method as traditional");
            //PrintOnDemand(PrintSongLyricsThe1);
            PrintOnDemand(() =>
            {
                Console.WriteLine(
                    "We could leave the Christmas lights up 'til January\n" +
                    "And this is our place, we make the rules\n" +
                    "And there's a dazzling haze, a mysterious way about you, dear\n" +
                    "Have I known you 20 seconds or 20 years?\n" +
                    "Can I go where you go?\n" +
                    "Can we always be this close forever and ever?\n" +
                    "And ah, take me out, and take me home\n" +
                    "You're my, my, my, my lover\n");
            });

        }

        //Phục vụ in ra nội dung theo yêu cầu
        static void PrintOnDemand(Action f)
        {
            //PrintSongLyricsThe1();
            //PrintSongLyricsLover();
            f.Invoke();

            //-> loose coupling ràng buộc lỏng lẻo
        }

        static void PrintOnDemand()
        {
            PrintSongLyricsThe1();
            PrintSongLyricsLover();
        }

        static void PrintSongLyricsThe1()
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
        static void PrintSongLyricsLover()
        {
            Console.WriteLine("The song Lover - by Taylor Swift");
            Console.WriteLine();
            Console.WriteLine(
                    "We could leave the Christmas lights up 'til January\n" +
                    "And this is our place, we make the rules\n" +
                    "And there's a dazzling haze, a mysterious way about you, dear\n" +
                    "Have I known you 20 seconds or 20 years?\n" +
                    "Can I go where you go?\n" +
                    "Can we always be this close forever and ever?\n" +
                    "And ah, take me out, and take me home\n" +
                    "You're my, my, my, my lover\n");

        }
    }
}
