using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SychevAD.Sprint2.Task0.V20.Lib;

namespace Tyuiu.SychevAD.Sprint2.Task0.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Сычев А. Д. | АСОиУб 24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Сычев Александр Дмитриевич | АСОиУб 24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических      *");
            Console.WriteLine("* выражений, которая вернет логическую последовательность(массив): (True, *");
            Console.WriteLine("* False,True,False,True,False), при x = 1075, y = 275.                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 1075;
            int y = 275;

            Console.WriteLine(" X = " + x);
            Console.WriteLine(" Y = " + y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] res = ds.GetCompareOperations(x, y);

            // Красивый вывод с нумерацией операций
            string[] operationNames =
            {
                "x == y + offset1:  ",
                "x != y + offset1:  ",
                "x < y + offset2:   ",
                "x > y + offset2:   ",
                "x <= y + offset1:  ",
                "x >= y + offset2:  "
            };

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"{operationNames[i]} {res[i]}");
            }

            // Дополнительная информация для проверки
            Console.WriteLine();
            Console.WriteLine("Проверка для x = 1075, y = 275:");
            Console.WriteLine($"y + offset1 = 275 + 800 = {y + 800}");
            Console.WriteLine($"y + offset2 = 275 + 1000 = {y + 1000}");

            Console.ReadKey();
        }
    }
}