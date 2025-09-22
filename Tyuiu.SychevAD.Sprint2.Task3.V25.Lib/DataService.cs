using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SychevAD.Sprint2.Task3.V25.Lib
{
    public class DataService : ISprint2Task3V25
    {
        public double Calculate(double x)
        {
            {
                double y = 0;
                if (x > 1)
                {
                    y = Math.Sin(Math.Pow(x, 3)) + Math.Pow((x + 1) / (x - 1), x);
                }
                else
                {
                    if (x == 0)
                    {
                        y = ((x * x) - (Math.Cos(x * x * x))) / (x - 3);

                    }
                    else
                    {
                        if ((-29 < x) && (x < 2))
                        {
                            y = Math.Pow((x + (1 / x * x)), x);
                        }
                        else
                        {
                            if (x < -29)
                            {
                                y = x + 15 + ((12 / x) * x);
                            }
                        }
                    }
                }
                return Math.Round(y, 3);
            }
        }
    }
}