using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SychevAD.Sprint2.Task7.V3.Lib;

namespace Tyuiu.SychevAD.Sprint2.Task7.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Введите значение точки Х на плоскости: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Введите значение точки Y на плоскости: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool res = ds.CheckDotInShadedArea(x, y);

            switch (res)
            {
                case true:
                    Console.WriteLine("Точка находится в заштрихованной области");
                    break;
                case false:
                    Console.WriteLine("Точка не находится в заштрихованной области");
                    break;
                default:
                    Console.WriteLine("Заданы недопустимые координаты точки на плоскости");
                    break;
            }
            Console.ReadKey();
        }
    }
}