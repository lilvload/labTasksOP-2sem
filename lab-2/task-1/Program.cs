using System;

namespace task_1
{
    class Program
    {
        static double FirstFunction(double a, double b, double c, double d)
        {
            double y = Math.Sqrt(Math.Abs(Math.Sin(a) - ((4 * Math.Log(b) / (Math.Pow(c, d))))));
            return y;
        }
        
        static double SecondFunction(double a, double b, double c, double d)
        {
            double y = ((Math.Pow(Math.E, a) + 3 * Math.Log10(c)) / Math.Sqrt(Math.Pow(b, c))) * Math.Abs(Math.Atan(d));
            return y;
        }
        
        static double ThirdFunction(double a, double b, double c, double d)
        {
            double y = Math.Pow((2 * Math.Sin(a) + Math.Cos(Math.Abs(b * Math.Sqrt(c)))), d);
            return y;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(FirstFunction(-1.49, 23.4, 1.23, 2.542));
            Console.WriteLine(SecondFunction(2.34, 0.756, 2.34, -1.653));
            Console.WriteLine(ThirdFunction(1.234, -3.12, 5.45, 2.0));
        }
    }
}