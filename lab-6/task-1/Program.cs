using System;

namespace task_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PrintResults([5,7,6,9,121,1,3,7]);
        }

        public static void BubbleSort(byte[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        byte temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public static void SelectionSort(byte[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int MinElement = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[MinElement])
                    {
                        MinElement = j;
                    }
                }
                byte temp = array[MinElement];
                array[MinElement] = array[i];
                array[i] = temp;
            }
        }

        public static void PrintResults(byte[] array)
        {
            Console.Write("Unsorted array: ");
            PrintArray(array);
            SelectionSort(array);
            Console.Write("Sorted array: ");
            PrintArray(array);
        }
        
        public static void PrintArray(byte[] array)
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
            Console.WriteLine();
        }
    }
}