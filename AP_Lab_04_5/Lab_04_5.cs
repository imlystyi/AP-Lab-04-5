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

            int R;

            double x, y;
            
            Random rand = new Random();

            // Спосіб 1.
            Console.WriteLine("Метод 1.");
            
            for (int ii = 0; ii < 10; ii++)
            {
                Console.Write("Метод 1.\n" +
                    "Введіть значення змінних \"x\", \"y\", \"R\" по черзі через крапку з комою: ");

                string[] varArray = Console.ReadLine().Split(';', ',');

                x = Double.Parse(varArray[0]);
                y = Double.Parse(varArray[1]);
                R = int.Parse(varArray[2]);

                if (x >= -R && x <= R && y >= 0 && y <= R && (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(R, 2)))
                    result = true;

                else if (x > y && y > -R && y < 0)
                    result = true;

                else result = false;

                Console.WriteLine(result ? "Попало!" : "Не попало!");
            }

            // Спосіб 2.
            Console.Write("Введіть значення змінної \"R\": ");

            R = int.Parse(Console.ReadLine());            

            // Виведення "шапки" таблиці
            Console.WriteLine("+---------------+---------------+---------------+\n" +
                "|\tx\t|\ty\t|\tпопало?\t|\n" +
                "+---------------+---------------+---------------+");

            // Розрахунок значень та виведення основної частини таблиці
            for (int jj = 0; jj < 10; jj++)
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