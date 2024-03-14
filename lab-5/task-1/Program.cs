using System;

namespace task_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[,] matrix = { { 1, 5, 1, 1 }, { 4, 3, 1, 2 }, { 4, -3, 1, 2 } };
            Console.WriteLine(MinElementInLargestColumn(matrix));

        }

        public static int MinElementInLargestColumn(int[,] matrix)
        {
            int maxSum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += Math.Abs(matrix[i, j]);
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
            
            int minElememt = Int32.MaxValue;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += Math.Abs(matrix[i, j]);
                }
                
                if (sum != maxSum) continue;
                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < minElememt)
                    {
                        minElememt = matrix[i, j];
                    }
                }
            }
            return minElememt;
        }
    }
}