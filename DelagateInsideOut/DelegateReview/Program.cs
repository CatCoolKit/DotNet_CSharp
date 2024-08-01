namespace DelegateReview
{
    //Delegater là kỹ thuật thiết kế một class đặc biệt 
    //Class này không chứa dữ liệu của các object theo style truyền thống, mà nó đi lưu thông tin các hàm đã tồn tại ngoài kia
    //public class X[void X()] : Delegate 
    //{
    //    public void X(){...}

    //    public void Invoke() { } //Duyệt qua danh sách các hàm đã được lưu và gọi chúng
    //}
    public delegate void PlayNumberDelegate(int i);
    public delegate void TellHerDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            TellHerDelegate tellHerDelegate = TellHerMessage1;
            tellHerDelegate += TellHerMessage2;
            tellHerDelegate();
        }

        static void TellHerMessage1() => Console.WriteLine("1. I love you so much!");
        static void TellHerMessage2() => Console.WriteLine("2. I miss you so much!");
    }
}
