namespace ActionDelegate
{
    delegate void NoInputNoOutputDelegate();
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Challenge #1 - Call method as normal");
        //    ShowNotification();

        //    Console.WriteLine();
        //    Console.WriteLine("Challenge #2 - Call method using anonymous");
        //    NoInputNoOutputDelegate f = () => Console.WriteLine("Notification: You have a new message with anonymous");
        //    f();

        //    Console.WriteLine();
        //    Console.WriteLine("Challenge #3 - Call method using lambda");
        //    NoInputNoOutputDelegate f2 = () => Console.WriteLine("Notification: You have a new message with lambda");
        //    f2();

        //    Console.WriteLine();
        //    Console.WriteLine("Challenge #4 - Call method using delegate & explicit");
        //    NoInputNoOutputDelegate f4 = ShowNotification;
        //    f4();
        //}

        static void Main(string[] args)
        {
            NoInputNoOutputDelegate f1 = delegate () { };
            NoInputNoOutputDelegate f2 = () => { };
            NoInputNoOutputDelegate f3 = ShowNotification;

            //Dùng Action delegate
            Action f4 = ShowNotification;
            f4();
            Console.WriteLine();

            Action f5 = () => { Console.WriteLine("8/3/2004: Chúng ta của tương lai | Sơn Tùng MTP"); };
            f5.Invoke();
            Console.WriteLine();
        }

        static void ShowNotification()
        {
            Console.WriteLine("Notification: You have a new message.");
        }
    }
}
