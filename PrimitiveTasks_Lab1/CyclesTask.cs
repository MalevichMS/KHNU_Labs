using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTasks_Lab1
{
    public class CyclesTask
    {
        private static int i = 10;

        public static double CalculateZ(int x)
        {
            return GetParametrA(x) + GetParametrB(x);
        }

        public static double GetParametrA(int x)
        {
            double result = 0;
            for(int _i = i; _i <= i+9; _i++)
            {
                result += Math.Sin(x) - Math.Cos(x ^ 3) * Math.Sin((x ^ 2) - 4.2) + 4.27;
            }
            return result;
        }

        public static double GetParametrB(int x)
        {
            double result = 1;
            for (int _i = i; _i <= i + 5; _i++)
            {
                result *= Math.Sin(x) - Math.Cos(x ^ 3) * Math.Sin((x ^ 2) - 4.2) + 4.27;
            }
            return result;
        }
    }
}
