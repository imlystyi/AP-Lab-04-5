// Lab_04_5.cs
// Якубовський Владислав
// Лабораторна робота № 4.5
// «Попадання» у плоску фігуру.
// Варіант 24
using System;

namespace AP_Lab_04_5
{
    internal class Lab_04_5
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            bool result;

            double x, y;

            Random rand = new Random();

            Console.Write("Введіть значення змінної \"R\": ");

            int R = int.Parse(Console.ReadLine());            

            // Виведення "шапки" таблиці
            Console.WriteLine("+---------------+---------------+---------------+\n" +
                "|\tx\t|\ty\t|\tпопало?\t|\n" +
                "+---------------+---------------+---------------+");

            // Розрахунок значень та виведення основної частини таблиці
            for (int ii = 0; ii < 10; ii++)
            {
                x = rand.Next(-R, R) + rand.NextDouble();
                y = rand.Next(-R, R) + rand.NextDouble();

                if (x >= -R && x <= R && y >= 0 && y <= R && (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(R, 2)))
                    result = true;

                else if (x > y && y > -R && y < 0)
                    result = true;

                else result = false;

                Console.WriteLine($"|\t{String.Format("{0:0.##}", x)}\t|\t{String.Format("{0:0.##}", y)}\t|\t" + (result ? "так" : "ні") + "\t|\n" +
                    $"+---------------+---------------+---------------+");
            }

            Console.ReadLine();
        }
    }
}