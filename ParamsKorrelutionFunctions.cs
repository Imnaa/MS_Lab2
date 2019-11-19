using Accord.Statistics.Distributions.Univariate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Lab2
{
    // Подбор параметров корреляционной функции
    class ParamsKorrelutionFunctions
    {
        // Возмущающее воздействие для бракованных деталей.
        // Стационарный случайный процесс с нормальным законом распределения

        // В учебных целях берем такое значение для m
        //const int m = 3;

        private double[] C;
        private double[] Ky_ = new double[4];

        // Находим коеф. а
        double a = 0;
        public double FindA(double Ymax, double Ymin)
        {
            a = Math.Pow((Ymax - Ymin) / 6.0f, 2.0f);
            return a;
        }
        // Находим коеф. b
        private double b = 0;
        public double FindB(double dt)
        {
            b = Math.Log(20) / (3 * dt);
            return b;
        }
        // Общий вид корреляционной функции
        public void Ky_x4dt(double _1dt, double _2dt, double _3dt, double _4dt)
        {
            Ky_[0] = a * Math.Exp(-b * _1dt);
            Ky_[1] = a * Math.Exp(-b * _2dt);
            Ky_[2] = a * Math.Exp(-b * _3dt);
            Ky_[3] = a * Math.Exp(-b * _4dt);
        }
        // Нахождение констант
        public void findConstants()
        {
            MethodNewton methodNewton = new MethodNewton();
            C = methodNewton.Solve(Ky_);
        }
        // Закон Пуассона
        
        // Использование метода скользящего суммирования
        public double[] MethodMovingSumm()
        {
            double[] res = new double[2];

            var dist1 = new PoissonDistribution(lambda: 1);
            var dist2 = new PoissonDistribution(lambda: 2);
            var dist3 = new PoissonDistribution(lambda: 3);
            var dist4 = new PoissonDistribution(lambda: 4);

            return res;
        }
    }
}
