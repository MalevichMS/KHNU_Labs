using UserInterface;

namespace PrimitiveTasks_Lab1
{
    public class PrimitiveTaskRunner : IRunner
    {
        public Iinterface UserInterface { get; set; }

        public PrimitiveTaskRunner(Iinterface ui)
        {
            UserInterface = ui;
        }

        public void Run()
        {
            int Radius = 0;
            int a = 0, b = 0, c = 0, d = 0, x = 0;
            int numb = 0;
            int _x = 0;
            try
            {
                UserInterface.Write("Zavd 1 --------------\n");
                UserInterface.Write("input Radius\n");
                Radius = int.Parse(UserInterface.Read());
                UserInterface.Write($"Perimtr={Klumba.Perimtr(Radius)} square={Klumba.Square(Radius)}\n");

                UserInterface.Write("Zavd 2 --------------\n");

                UserInterface.Write("input a, b, c, d, x\n");
                a = int.Parse(UserInterface.Read());
                b = int.Parse(UserInterface.Read());
                c = int.Parse(UserInterface.Read());
                d = int.Parse(UserInterface.Read());
                x = int.Parse(UserInterface.Read());
                UserInterface.Write($"результат {Zavd2.igrik(a, b, c, d, x)}\n");

                UserInterface.Write("Zavd 3 --------------\n");

                UserInterface.Write("input number for find students surname\n");
                numb = int.Parse(UserInterface.Read());
                UserInterface.Write($"via if:  {StudentByNumberGetter.GetSurnameViaIf(numb)}\n");
                UserInterface.Write($"via switch:  {StudentByNumberGetter.GetSurnameViaSwitch(numb)}\n");

                UserInterface.Write("Zavd 4 --------------\n");

                UserInterface.Write("input x\n");
                _x = int.Parse(UserInterface.Read());
                UserInterface.Write($"result = {CyclesTask.CalculateZ(_x)}\n");
            }
            catch
            { throw new System.Exception("очепятка"); }
            
        }
    }
}
