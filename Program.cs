using System;

namespace Lesson_02_s
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

            int[,] a = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Введите значение для a[" + i + ", " + j + "]: ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int temp;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    for (int k = 0; k < a.GetLength(0); k++)
                    {
                        for (int l = 0; l < a.GetLength(1); l++)
                        {
                            if (a[i, j] < a[k, l])
                            {
                                temp = a[i, j];
                                a[i, j] = a[k, l];
                                a[k, l] = temp;
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Отсортированный массив по возрастанию:");

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
