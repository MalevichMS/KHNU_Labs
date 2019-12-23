using System;
using System.Collections.Generic;
using System.Linq;
using UserInterface;

namespace ArraysTasks_Lab2
{
    public class ArrayPrinter
    {
        public Iinterface UserInterface { get; set; }

        public ArrayPrinter(Iinterface ui)
        {
            UserInterface = ui;
        }

        public void DoubleArrayPrint(IEnumerable<double> arr)
        {
            for(int i = 0; i< arr.Count(); i++)
            {
                UserInterface.Write($"{Math.Round(arr.ElementAt(i),2)}   ");
            }
            UserInterface.Write("\n");
        }
        public void DoubleArrayPrint(double[,] arr , int rows, int colls)
        {
            for(int i = 0; i<rows; i++)
            {
                for (int j = 0; j < colls; j++)
                {
                    UserInterface.Write($"{Math.Round(arr[i,j], 2)}\t");
                }
                UserInterface.Write("\n");
            }
        }
    }
}
