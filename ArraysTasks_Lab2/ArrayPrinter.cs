using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface;

namespace ArraysTasks_Lab2
{
    class ArrayPrinter
    {
        public Iinterface UserInterface { get; set; }

        public ArrayPrinter(Iinterface ui)
        {
            UserInterface = ui;
        }

        public void DoubleArrayPrint(double[] arr)
        {
            for(int i = 0; i< arr.Length; i++)
            {
                UserInterface.Write($"{arr[i]}");
            }
        }
    }
}
