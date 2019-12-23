using System;
using System.Linq;
using UserInterface.Extensions;

namespace ArraysTasks_Lab2
{
    public class SystemArrayUsing_Task2
    {
        private double[,] arr;
        public readonly int rows;
        public readonly int colls;

        public SystemArrayUsing_Task2(int k, int n)
        {
            rows = k;
            colls = n;
            arr = new double[k, n];
        }

        public void FillArr()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colls; j++)
                {
                    arr[i, j] = j * func(i) + Math.Sin(i) * func(j);
                }
            }
        }

        public double[,] GetArray()
        {
            return arr;
        }

        public void IndexesOfMin(out int i, out int j)
        {
            double min = arr.Cast<double>().Min();

            int resultI = 0;
            int resultJ = 0;

            for (int _i = 0; _i < rows; _i++)
            {
                for (int _j = 0; _j < colls; _j++)
                {
                    if (arr[_i, _j] == min)
                    {
                        resultI = _i;
                        resultJ = _j;
                    }
                }
            }

            i = resultI;
            j = resultJ;
        }

        public double ProdOFNegative()
        {
            return arr.Cast<double>().Where(n => n < 0).Prod();
        }

        public double func(int x)
        {
            return Math.Sin(x) - Math.Cos(x ^ 3) * Math.Sin((x ^ 2) - 4.2) + 4.27;
        }
    }
}
