using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesTasks_Lab4
{
    public class MasivZ
    {
        public List<char> Symbols { get; set; }
        public List<int> Codes { get; set; }

        public MasivZ()
        {
            Symbols = new List<char>();
            Codes = new List<int>();
        }

        public void CreateFromIntArray(List<List<int>> arr)
        {
            foreach (var row in arr)
                foreach (var code in row)
                {
                    Symbols.Add((char)code);
                    Codes.Add(code);
                }   
        }

        public MasivZ UpperToLower()
        {
            MasivZ newArr = new MasivZ();
            char temp = ' ';

            foreach (var symb in Symbols)
            {
                if (char.IsLower(symb))
                {
                    temp = char.ToUpper(symb);
                    newArr.Symbols.Add(temp);
                    newArr.Codes.Add((int)temp);
                }
                else
                {
                    if (char.IsUpper(symb))
                    {
                        temp = char.ToLower(symb);
                        newArr.Symbols.Add(temp);
                        newArr.Codes.Add((int)temp);
                    }
                        
                    else
                    {
                        newArr.Symbols.Add(symb);
                        newArr.Codes.Add((int)symb);
                    }     
                }
            }
            return newArr;
        }
    }
}
