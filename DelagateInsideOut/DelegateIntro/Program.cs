namespace DelegateIntro
{
    //delegate khai báo ở ngoài class Program
    public delegate void MyDelegate();
    public class Person()
    {
    }

    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    MyDelegate myDelegate = new MyDelegate(TellHer);

        //    //Cách gọi 1
        //    Console.WriteLine("Cách gọi 1");
        //    myDelegate();
        //    //Cách gọi 2
        //    Console.WriteLine("Cách gọi 2");
        //    myDelegate.Invoke();
        //}

        //Chơi delegate style nhiều hàm
        //Một con trỏ đa hàm có thể trỏ đến nhiều hàm, nhưng vẫn 1 vùng new ()
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(TellHer);
            myDelegate += NhanEm;
            myDelegate += SayHelloToSweetHeart;

            myDelegate();
        }

        static void TellHer()
        {
            Console.WriteLine("I love you!");
        }
        static void NhanEm()
        {
            Console.WriteLine("Chuc em hanh phuc ben nguoi!");
        }
        static void SayHelloToSweetHeart()
        {
            Console.WriteLine("Hello, my sweet heart!");
        }
    }
}
