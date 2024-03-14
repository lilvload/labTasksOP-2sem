using System;

namespace task_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PrintResults([1,2,3,-5,-10,15], [5,7,8,-9,5,-11]);
            PrintResults([5,7,-20,-85, -10,5], [5,7,-90,-9,1012,-11]);
            PrintResults([-10,-59,3,-5,-10,15], [1,7,-98,-9,5,-11]);
        }

        public static double[] NewArray(double[] arrayA, double[] arrayB)
        {
            double[] arrayC = new double[arrayA.Length];
            for (int i = 0; i < arrayC.Length; i++)
            {
                if (arrayA[i] > 0 && arrayB[i] > 0)
                {
                    arrayC[i] = arrayA[i] + arrayB[i];
                } 
                else if (arrayA[i] < 0 && arrayB[i] < 0)
                {
                    arrayC[i] = arrayA[i] * arrayB[i];
                }
                else
                {
                    arrayC[i] = 0;
                }
            }
            return arrayC;
        }

        public static void PrintResults(double[] arrayA, double[] arrayB)
        {
            Console.Write("arrayA: ");
            PrintArray(arrayA);
            Console.Write("arrayB: ");
            PrintArray(arrayB);
            Console.Write("result: ");
            PrintArray(NewArray(arrayA, arrayB));
            Console.WriteLine("");
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