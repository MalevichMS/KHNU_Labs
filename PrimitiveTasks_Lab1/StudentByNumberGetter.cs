using System;

namespace PrimitiveTasks_Lab1
{
    class StudentByNumberGetter
    {
        public static string GetSurnameViaIf(int numb)
        {
            string result = null;
            if (numb <= 0)
                throw new Exception();
            if (numb == 1)
                result = "Malevich";
            if (numb == 2)
                result = "Ivaniv";
            if (numb == 3)
                result = "Sheva";
            if (numb == 4)
                result = "Tishko";
            if (numb == 5)
                result = "Savina";
            if (numb == 6)
                result = "Vegera";
            if (result != null)
                return result;
            else
                return "invalid number";
        }

        public static string GetSurnameViaSwitch(int numb)
        {
            if (numb <= 0)
                throw new Exception();

            switch (numb)
            {
                case 1: return "Malevich";
                case 2: return "Ivaniv";
                case 3: return "Sheva";
                case 4: return "Tishko";
                case 5: return "Savina";
                case 6: return "Vegera";
                default: return "invalid number";
            }
        }
    }
}
