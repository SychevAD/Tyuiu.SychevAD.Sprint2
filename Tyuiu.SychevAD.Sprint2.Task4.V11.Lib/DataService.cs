using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SychevAD.Sprint2.Task4.V11.Lib
{
    public class DataService : ISprint2Task4V11
    {
        public double Calculate(double x, double y)
        {
            double z = (x - 20 * 2 < y / 4) ? Math.Pow(3 + (8 / Math.Pow(x, 2)), y) : y - Math.Pow((x + 1) / (y + 2), x);
            return Math.Round(z, 3);
        }
    }
}