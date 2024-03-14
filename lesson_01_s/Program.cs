using System;

namespace Lesson_01_s
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num1 = int.Parse(args[0]);
            double num2 = int.Parse(args[2]);
            string operation = args[1];

            double result = 0;

            if (operation == "+")
            {
                result = num1 + num2;
            }
            else if (operation == "-")
            {
                result = num1 - num2;
            }
            else if (operation == "/")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Деление на ноль");
                    return;
                }
            }
            else if (operation == "*")
            {
                result = num1 * num2;
            }
            else
            {
                Console.WriteLine("Неизвестная операция");
                return;
            }

            Console.WriteLine($"Результат арифметической операции: {result}");
        }

    }
}
