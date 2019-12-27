using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesTasks_Lab4
{
    public static class ArrayEditor
    {
        public static void FillArr(List<int> arr)
        {
            int N = arr.Capacity;
            Random rnd = new Random();

            for(int i=0; i < N; i++)
                arr.Add(rnd.Next(1, N));
        }

        public static List<List<T>> ConvertToTwoRank<T>(List<T> arr)
        {
            List<List<T>> newArr = new List<List<T>>(2);
            newArr.Add(new List<T>());
            newArr.Add(new List<T>());
            newArr[0] = arr.Where((x, n) => n % 2 == 0).ToList();
            newArr[1] = arr.Where((x, n) => n % 2 == 1).ToList();
            return newArr;
        }

    }
}
