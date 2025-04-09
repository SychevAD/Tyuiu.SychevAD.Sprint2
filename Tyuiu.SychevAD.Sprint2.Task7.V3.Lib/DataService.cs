using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SychevAD.Sprint2.Task7.V3.Lib
{
    public class DataService : ISprint2Task7V3
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res = false;

            if (y <= (1 - x * x) && (x * x + Math.Pow((y - 1), 2)) <= 1)
            {
                res = true;
            }

            return res;
        }
    }
}