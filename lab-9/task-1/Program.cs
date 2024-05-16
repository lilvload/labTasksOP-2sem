using System;

namespace task_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Output(64206);
            Output(51966);
            Output(3243);
            Output(64222);
            Output(2989);
            Output(3053);
            Output(3054);
            Output(57007);
            Output(65261);
            Output(48879);
        }
        
        static string ConvertToHexString(int number)
        {
            return number.ToString("X");
        }

        static void Output(int number)
        {
            Console.WriteLine($"Number {number} in hexadecimal notation: {ConvertToHexString(number)}");
        }
    }
}