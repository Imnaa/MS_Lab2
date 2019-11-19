using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MS_Lab2
{
    class Zakoni
    {
        Random random = new Random();
        // Нормальный закон распределения
        public double GetNormal(double m, double sigma)
        {
            double x1 = random.NextDouble();
            //Thread.Sleep(3);
            double x2 = random.NextDouble();
            return sigma * Math.Cos(2 * Math.PI * x1) * Math.Sqrt(-2 * Math.Log(x2)) + m;
        }
        // Показательный закон
        public double GetExp(double lyambda)
        {
            Random random = new Random();
            double x = random.NextDouble();
            return -1.0f / lyambda * Math.Log(x);
        }
    }
}
