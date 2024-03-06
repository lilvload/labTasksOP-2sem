using System;

namespace task_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PrintResults(5, 10);
            PrintResults(10, -10);
            PrintResults(4, 100);
            PrintResults(9, 5.5);
            PrintResults(30, 1.25);
            PrintResults(25, 44);
            PrintResults(15, Double.MaxValue);
            PrintResults(15, Double.NaN);
            PrintResults(-1, 1.5);
            PrintResults(31, 7);
        }

        public static double Function(int k, double m)
        {
            if (k <= 0 || k > 30)
            {
                throw new ArgumentOutOfRangeException(nameof(k), k, "Invalid value");
            }

            double sum = 0;
            for (double i = 1; i <= k; i++)
            {
                sum += Math.Sqrt(m * (1 / i)) * Math.Sin(i * m);
            }
            return sum;
        }

        static void PrintResults(int k, double m)
        {
            Console.Write($"k:{k} m:{m} result:");
            try
            {
                Console.WriteLine(Function(k, m));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("EXCEPTION! {0}", e.Message);
            }
        }
    }
}