using System;

namespace task_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[,] matrix = {{1,1,1,1,1},{1,1,1,1,1},{1,1,1,1,1},{1,1,1,1,1},{1,1,1,1,1}};
            
            PrintMatrix(matrix);
        }

        public static void ClearNE(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i <= j)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
        }

        public static void PrintMatrix(int[,] matrix)
        {
            ClearNE(matrix);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}