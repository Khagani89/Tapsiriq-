using System;

namespace Task_1._23._05._2022__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1 , 2, 3, 4 , 5 , 6 };
            var n = 3;
         

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == n)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}

