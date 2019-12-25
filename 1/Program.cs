using System;
using System.Collections.Generic;
using System.Linq;
using UserInterface;
using PrimitiveTasks_Lab1;
using ArraysTasks_Lab2;
using StringsTasks_Lab3;

namespace LabsKHNU
{
        
    class Program
    {
        static void Main(string[] args)
        {
            Iinterface ui = new ConsoleUI();
            List<IRunner> labs = new List<IRunner>();
            labs.Add(new PrimitiveTaskRunner(ui));
            labs.Add(new ArraysTasksRunner(ui));
            labs.Add(new StringsTasksRunner(ui));
            
            int labNumb;

            Console.WriteLine("input number of lab(1-3) ");
            try
            {
                labNumb = int.Parse(Console.ReadLine())-1;
                labs.ElementAt(labNumb).Run();
            }
            catch(Exception e)
            { Console.WriteLine(e.Message); }

            Console.Read();
        }
    }

}
