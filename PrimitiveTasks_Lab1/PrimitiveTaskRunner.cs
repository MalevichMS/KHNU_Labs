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
                UserInterface.Write("Zavd 1 --------------");
                UserInterface.Write("input Radius");
                Radius = int.Parse(UserInterface.Read());
                UserInterface.Write($"Perimtr={Klumba.Perimtr(Radius)} square={Klumba.Square(Radius)}");

                UserInterface.Write("Zavd 2 --------------");

                UserInterface.Write("input a, b, c, d, x");
                a = int.Parse(UserInterface.Read());
                b = int.Parse(UserInterface.Read());
                c = int.Parse(UserInterface.Read());
                d = int.Parse(UserInterface.Read());
                x = int.Parse(UserInterface.Read());
                UserInterface.Write($"результат {Zavd2.igrik(a, b, c, d, x)}");

                UserInterface.Write("Zavd 3 --------------");

                UserInterface.Write("input number for find students surname");
                numb = int.Parse(UserInterface.Read());
                UserInterface.Write($"via if:  {StudentByNumberGetter.GetSurnameViaIf(numb)}");
                UserInterface.Write($"via switch:  {StudentByNumberGetter.GetSurnameViaSwitch(numb)}");

                UserInterface.Write("Zavd 4 --------------");

                UserInterface.Write("input x");
                _x = int.Parse(UserInterface.Read());
                UserInterface.Write($"result = {CyclesTask.CalculateZ(_x)}");
            }
            catch
            { throw new System.Exception("очепятка"); }
            
        }
    }
}
