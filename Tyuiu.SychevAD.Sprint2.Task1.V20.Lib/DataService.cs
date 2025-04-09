using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ЗАДАНИЕ
//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать,
//но использовать один раз в выражении) и логических операций (|, &, ||, &&, !, ^,
//последовательность операций не должна нарушаться), а также арифметических выражений,
//которая вернет логическую последовательность(массив): (False, False, False, True, True, True),
//при a = 242, b = 155, c = 456, d = 17

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SychevAD.A.Sprint2.Task1.V20.Lib
{
    public class DataService : ISprint2Task1V20
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a < b) | (c < d);
            res[1] = (a + 2 > b) & (c < d);
            res[2] = (a < b) || (c < d);
            res[3] = (a + 2 > d) && (c > d);
            res[4] = !(!res[3]);
            res[5] = (a > b) ^ (c < d);

            return res;
        }
    }
}