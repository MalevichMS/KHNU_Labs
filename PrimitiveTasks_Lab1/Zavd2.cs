using System;

namespace PrimitiveTasks_Lab1
{
    public class Zavd2
    {
        private static int i = 10;
        public static double func(int a, int b, int x)
        {
            return Math.Tan(x / i + a) - Math.Log(Math.Abs(b * i + 7));
        }

        public static double omega(int c, int d, int x)
        {
            return c * Math.Pow((x * x + d * Math.Pow(i, 1.2)), 1 / i);
        }

        public static double igrik(int a, int b, int c, int d, int x)
        {
            if (Math.Abs(x) < 10)
            {
                return func(a, b, x);

            }
            else
            {
                return omega(c, d, x);
            }
        }
    }
}
