using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysTasks_Lab2
{
    public class ArrayManipulator_Task1
    {
       
        private double[] arr;

        public ArrayManipulator_Task1(int variant)
        {
            arr = new double[variant + 10];
        }
        
        public void FillArr()
        {
            for(int i = 0; i < arr.Count(); i++)
            {
                arr[i] = GetParametrA(i) + GetParametrB(i);
            }
        }

        public double[] GetArray()
        {
            return arr;
        }

        public double[] GetPositiveElements()
        {
            double[] result;
            result = (from n in arr
                     where n >= 0
                     select n) as double[];
            return result;
        }

        public static double GetParametrA(int x)
        {
            double result = 0;
            for (int _i = x; _i <= x + 5; _i++)
            {
                result += Math.Sin(x) - Math.Cos(x ^ 3) * Math.Sin((x ^ 2) - 4.2) + 4.27;
            }
            return result;
        }

        public static double GetParametrB(int x)
        {
            double result = 1;
            for (int _i = x; _i <= x + 3; _i++)
            {
                result *= Math.Sin(x) - Math.Cos(x ^ 3) * Math.Sin((x ^ 2) - 4.2) + 4.27;
            }
            return result;
        }
    }
}
