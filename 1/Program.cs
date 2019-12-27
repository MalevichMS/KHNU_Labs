using System;
using System.Collections.Generic;
using System.Linq;
using UserInterface;
using PrimitiveTasks_Lab1;
using ArraysTasks_Lab2;
using StringsTasks_Lab3;
using FilesTasks_Lab4;

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
            labs.Add(new FilesTasksRunner(ui));
            
            int labNumb;

            Console.WriteLine("input number of lab(1-4) ");
            try
            {
                labNumb = int.Parse(Console.ReadLine()) - 1;
                labs.ElementAt(labNumb).Run();
            }
            catch(Exception e)
            { Console.WriteLine(e.Message); }

            Console.Read();
        }
    }

}
