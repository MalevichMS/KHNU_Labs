using System;
using UserInterface;

namespace ArraysTasks_Lab2
{
    public class ArraysTasksRunner : IRunner
    {
        public Iinterface UserInterface { get; set; }

        public ArraysTasksRunner(Iinterface ui)
        {
            UserInterface = ui;
        }

        public void Run()
        {
            int k = 0, n = 0;
            int indexK, indexN;

            ArrayPrinter printer = new ArrayPrinter(UserInterface);

            ArrayManipulator_Task1 tsk1 = new ArrayManipulator_Task1(10);

            try
            {
                UserInterface.Write("\nZavd 1 --------------\n");

                tsk1.FillArr();

                UserInterface.Write("Array Z\n");
                printer.DoubleArrayPrint(tsk1.GetArray());

                var newArr = tsk1.GetPositiveElements();

                UserInterface.Write("\nPositive elements of Z\n");
                printer.DoubleArrayPrint(newArr);

                UserInterface.Write("\nZavd 2 --------------\n");
                UserInterface.Write("input k , n\n");

                k = int.Parse(UserInterface.Read());
                n = int.Parse(UserInterface.Read());

                SystemArrayUsing_Task2 tsk2 = new SystemArrayUsing_Task2(k, n);

                tsk2.FillArr();

                UserInterface.Write("Масив Z(k,n)\n");
                printer.DoubleArrayPrint(tsk2.GetArray(), tsk2.rows, tsk2.colls);

                tsk2.IndexesOfMin(out indexK, out indexN);
                UserInterface.Write($"indexes of min element = [{indexK}][{indexN}]\n");
                UserInterface.Write($"product of negative elements = {tsk2.ProdOFNegative()}\n");
            }
            catch
            { throw new Exception("очепятка"); }
        }
    }
}
