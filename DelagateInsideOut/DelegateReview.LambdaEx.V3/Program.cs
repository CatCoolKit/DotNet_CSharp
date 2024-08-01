namespace DelegateReview.LambdaEx.V3
{
    delegate double TwoInputOneOutputDelegate(double h, double w);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compute Area Rectangle: h = 3, w = 4");
            TwoInputOneOutputDelegate f = ComputeAreaRectangle;
            double area = f(3, 4);
            Console.WriteLine(area);

            Console.WriteLine("Compute Power: a = 2, b = 10");
            //f = ComputePower;
            f = (a, b) => Math.Pow(a, b);
            double power = f(2, 10);
            Console.WriteLine(power);
        }

        //tính diện tính hình chữ nhật
        static double ComputeAreaRectangle(double h, double w)
        {
            return h * w;
        }

        //Hàm tính a^b
        static double ComputePower(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
