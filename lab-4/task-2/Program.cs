using System;

namespace task_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PrintResults([5.5, 6.7, -9.5, 11.5, -8.7, 1.5]);
            PrintResults([9.7, 10.7, -50.5, -1.5, -8.9, 17.5]);
            PrintResults([-4560, 7891, -4564, 11215, 7892, -782454]);
        }

        public static double FindSumMinPositiveElementAndIndex(double[] arr)
        {
            double minElement = double.MaxValue;
            double minIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    if (arr[i] < minElement)
                    {
                        minElement = arr[i];
                        minIndex = i;
                    }
                }
            }
            return minElement + minIndex;
        }
        
        public static void PrintResults(double[] array)
        {
            Console.Write("array: ");
            PrintArray(array);
            Console.WriteLine("result: " + FindSumMinPositiveElementAndIndex(array));
        }

        public static void PrintArray(double[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i != array.Length - 1)
                {
                    Console.Write("; ");
                }
            }
            Console.Write("] ");
        }
    }
}