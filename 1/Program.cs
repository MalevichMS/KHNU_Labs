using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface;
using PrimitiveTasks_Lab1;

namespace LabsKHNU
{
        
    class Program
    {
        static void Main(string[] args)
        {
            Iinterface ui = new ConsoleUI();
            IRunner PrimitiveRunner = new PrimitiveTaskRunner(ui);
            PrimitiveRunner.Run();

            Console.Read();
        }
    }

}
