using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SychevAD.Sprint2.Task2.V14.Lib;

namespace Tyuiu.SychevAD.Sprint2.Task2.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Сычев А. Д. | АСОиУб 24-1";
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Спринт #2                                                               -");
            Console.WriteLine("- Тема: Оператор if – полная и короткая форма записи                      -");
            Console.WriteLine("- Задание #2                                                              -");
            Console.WriteLine("- Вариант #14                                                             -");
            Console.WriteLine("- Выполнил: Бахтияров Динар Русланович | АСОиУб-23-3                      -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Условие: Написать программу на, которая запрашивает целые значения с    -");
            Console.WriteLine("- клавиатуры и вычисляет находится ли точка с координатами X,Y в          -");
            Console.WriteLine("- заштрихованной области.                                                 -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Введите значение Х:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат: " + ds.CheckDotInShadedArea(x, y));
            Console.ReadKey();
        }
    }
}