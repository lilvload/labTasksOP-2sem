using System;

namespace task_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PrintResults(0.1);
            PrintResults(0.01);
            PrintResults(0.001);
            PrintResults(0.0001);
            PrintResults(0.00001);
            PrintResults(-1);
        }
        
        public static double Function(double epsilon)
        {
            if (epsilon <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(epsilon), epsilon, "Invalid value");
            }
            
            int i = 1;
            double currentAdd = 1 / Math.Pow(i, 2);
            double sum = 0;
            while (epsilon < Math.Abs(currentAdd))
            {
                currentAdd = 1 / Math.Pow(i, 2);
                sum += 1 / Math.Pow(i, 2);
                i++;
            }
            return sum;
        }

        static void PrintResults(double epsilon)
        {
            Console.Write($"epsilon:{epsilon} result:");
            try
            {
                Console.WriteLine(Function(epsilon));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("EXCEPTION! {0}", e.Message);
            }
        }
    }
}