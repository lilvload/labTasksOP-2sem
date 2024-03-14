using System;

namespace task_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PrintResults([1,2,3,-4,-9,1231545641]);
            PrintResults([Int32.MaxValue, 2,4,-4,-9,Int32.MinValue]);
            PrintResults([5,7,-3,-45,-9,123]);
            PrintResults([0,2,7,-4,-9,-1231545641]);
        }

        public static int CountPositiveNumbers(int[] array)
        {
            int count = 0;
            foreach (int number in array)
            {
                if (number > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static void PrintResults(int[] array)
        {
            Console.Write("array: ");
            PrintArray(array);
            Console.WriteLine("result: " + CountPositiveNumbers(array));
        }

        public static void PrintArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i != array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("] ");
        }
    }
}