using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Lab2
{
    class MethodNewton
    {
        const int N = 4;
        const double eps = 1e-6;

        // Вычисление нормы
        private double Normalisation(double[,] a, int n)
        {
            double res = 0;

            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                    res += a[i, j] * a[i, j];

            return Math.Sqrt(res);
        }

        // задание функции
        // x – столбец значений переменных
        // I номер функции в системе 
        private double System(double[] x, int i, double[] b)
        {
            switch (i)
            {
                case 0:
                    return Math.Pow(x[0], 2) + Math.Pow(x[1], 2) + Math.Pow(x[2], 2) + Math.Pow(x[3], 2) - b[0]; // вычисляем значение первой функции
                case 1:
                    return x[0] * x[1] + x[1] * x[2] + x[2] * x[3] - b[1]; // вычисляем значение второй функции
                case 2:
                    return x[0] * x[2] + x[1] * x[3] - b[2];
                case 3:
                    return x[0] * x[3] - b[3];
            }

            throw new ArgumentException();
        }

        // построение матрицы Якоби   
        // x – столбец значений неизвестных
        // i,j индексы элементов матрицы Якоби
        // i - номер строки
        // j – номер столбца
        private double MatrixJacobi(double[] x, int i, int j)
        {
            switch (i)
            {
                case 0:
                    switch (j)
                    {
                        // { вычисляем значение элемента матрицы Якоби индексами 1,1 }
                        case 0:
                            return 2 * x[0];
                        // { вычисляем значение элемента матрицы Якоби с индексами 1,2  }
                        case 1:
                            return 2 * x[1];
                        // { вычисляем значение элемента матрицы Якоби с индексами 1,3  }
                        case 2:
                            return 2 * x[2];
                        // { вычисляем значение элемента матрицы Якоби с индексами 1,4  }
                        case 3:
                            return 2 * x[3];
                    }
                    break;
                case 1:
                    switch (j)
                    {
                        // { вычисляем значение элемента матрицы Якоби с индексами 2,1  }
                        case 0:
                            return x[1];
                        // { вычисляем значение элемента матрицы Якоби с индексами 2,2  }
                        case 1:
                            return x[0] + x[2];
                        // { вычисляем значение элемента матрицы Якоби с индексами 2,3  }
                        case 2:
                            return x[1] + x[3];
                        // { вычисляем значение элемента матрицы Якоби с индексами 2,4  }
                        case 3:
                            return x[2];
                    }
                    break;
                case 2:
                    switch (j)
                    {
                        // { вычисляем значение элемента матрицы Якоби с индексами 3,1  }
                        case 0:
                            return x[2];
                        // { вычисляем значение элемента матрицы Якоби с индексами 3,2  }
                        case 1:
                            return x[3];
                        // { вычисляем значение элемента матрицы Якоби с индексами 3,3  }
                        case 2:
                            return x[0];
                        // { вычисляем значение элемента матрицы Якоби с индексами 3,4  }
                        case 3:
                            return x[1];
                    }
                    break;
                case 3:
                    switch (j)
                    {
                        // { вычисляем значение элемента матрицы Якоби с индексами 4,1  }
                        case 0:
                            return x[3];
                        // { вычисляем значение элемента матрицы Якоби с индексами 4,2  }
                        case 1:
                            return 0;
                        // { вычисляем значение элемента матрицы Якоби с индексами 4,3  }
                        case 2:
                            return 0;
                        // { вычисляем значение элемента матрицы Якоби с индексами 4,4  }
                        case 3:
                            return x[0];
                    }
                    break;
            }

            throw new ArgumentException();
        }

        // вывод матрицы
        private void printMatrix(double[,] mat, int N1, int N2)
        {
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    Console.WriteLine(mat[i, j]);
                }
                Console.WriteLine();
            }

        }

        //вывод вектора
        private void printVector(double[] vector, int N1, int N2)
        {
            for (int j = 0; j < N; ++j)
            {
                Console.WriteLine("x" + j + "=" + vector[j]);
            }
        }

        public double[] Solve(double[] B)
        {
            double[,] a = new double[N, N];
            double[] x = new double[N];
            double[] f = new double[N];
            double[] x0 = new double[N];
            int iter;
            double max;

            x0[0] = 0;
            x0[1] = 0;
            iter = 0;

            do
            {
                for (int i = 0; i < N; ++i)
                    for (int j = 0; j < N; ++j)
                        a[i, j] = MatrixJacobi(x0, i, j);

                //printVector(x0, 3, 4);
                // вычисление нормы матрицы A
                //Console.WriteLine("Norma = {0}", Normalisation(a, N));
                // подсчет количества итераций
                //Console.WriteLine("nomer iterazii - {0}", iter);
                //Console.WriteLine("=================");
                // нахождение нового приближения функции
                for (int i = 0; i < N; ++i)
                    x[i] = this.System(x0, i, B);

                max = Math.Abs(x[0] - x0[0]);

                for (int i = 1; i < N; ++i)
                    if (Math.Abs(x[i] - x0[i]) > max)
                        max = Math.Abs(x[i] - x0[i]);

                x0 = (double[])x.Clone();
                ++iter;
            }
            while ((max > eps) && (iter < 1000));

            return x;
        }
    }
}