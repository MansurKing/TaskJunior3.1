using System;

namespace TaskJunior3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumSecondLine = 0;
            int sumFirstColumm = 0;
            int sum;

            int[,] array = new int[2, 3] {
                {9, 8, 7},
                {6, 5, 4},
            };

            Console.WriteLine(array.Length + "- кол-во элементов в самом массиве.\n\nМассив: \n");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            sumSecondLine += array[1, 0] + array[1, 1] + array[1, 2];
            sumFirstColumm += array[0, 0] + array[0, 1];
            sum = sumSecondLine + sumFirstColumm;

            Console.Write("\n" + array[1, 0] + " + " + array[1, 1] + " + " + +array[1, 2]);
            Console.Write($" = {sumSecondLine} - сумма второй строки.\n");

            Console.Write(array[0, 0] + " + " + array[0, 1]);
            Console.Write($" = {sumFirstColumm} - сумма первого столбца.\n");

            Console.WriteLine($"\nСумма второй строки и произведение первого столбца: {sum}.");
        }
    }
}
