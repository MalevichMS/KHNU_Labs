using System;


namespace UserInterface
{
    public class ConsoleUI : Iinterface
    {
        public void Write(string msg)
        {
            Console.WriteLine(msg);
        }

        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
