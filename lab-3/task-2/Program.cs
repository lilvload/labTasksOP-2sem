using System;

namespace task_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PrintResults(1, 9);
            PrintResults(2, 4);
            PrintResults(1, 10.75);
            PrintResults(1, 61);
            PrintResults(2, 57);
            PrintResults(10, 5.5);
            PrintResults(5, 3);
            PrintResults(50, 3.75);
            PrintResults(-1, 58);
        }
        
        public static double Function(int i, double t)
        {
            if (i <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(i), i, "Invalid value");
            }

            if (i == 1)
            {
                return Math.Sqrt(t);
            }
            else if (i == 2)
            {
                return 1 / Math.Sqrt(t);
            }
            else if (i != 1 && i != 2)
            {
                double sum = 0;
                for (int k = 1; k <= i; k++)
                {
                    sum += k * i;
                }
                return sum;
            }

            return 0;
        }

        static void PrintResults(int i, double t)
        {
            Console.Write($"i:{i} t:{t} result:");
            try
            {
                Console.WriteLine(Function(i, t));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("EXCEPTION! {0}", e.Message);
            }
        }
    }
}