using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using UserInterface;

namespace FilesTasks_Lab4
{
    public class ArrayIO
    {
        private static int currentRow = 0;
        public static void WriteArray<T>(List<T> arr , string path)
        {
            using (StreamWriter fs = new StreamWriter(path , true))
            {
                foreach (var x in arr)
                    fs.Write(x.ToString() + " ");
                fs.Write("\n");
            }
        }

        public static void WriteArray(MasivZ arr, string path)
        {
            List<char> tempSymb = arr.Symbols;
            List<int> tempCodes = arr.Codes;
            tempSymb.RemoveAll(x => (int)x < 32);
            tempCodes.RemoveAll(x => x < 32);
            WriteArray(tempSymb, path);
            WriteArray(tempCodes, path);
        }

        public static void WriteArray(List<List<int>> arr, string path)
        {
            foreach (var row in arr)
                WriteArray(row, path);
        }

        public static List<int> ReadArray(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException();

            List<int> arr = new List<int>();

            using (StreamReader fs = File.OpenText(path))
            {
                string mas = fs.ReadLine().Trim();
                string[] nums = mas.Split(' ');
                arr = nums.ToList().ConvertAll(new Converter<string, int>(StringToInt));
            }
            return arr;
        }

        public static List<List<int>> ReadArray(string path, int rows)
        {
            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < rows; i++)
                arr.Add(ReadArray(path));

            return arr;
        }

        public static MasivZ ReadMasivZ(string path)
        {
            MasivZ arr = new MasivZ();
            using (StreamReader reader = new StreamReader(path))
            {
                for(int i = 0; i < currentRow * 2; ++i)
                {
                    reader.ReadLine();
                }
                arr.Symbols = reader.ReadLine().ToList<char>().Where((x, i) => i % 2 == 0).ToList();
                arr.Codes = reader.ReadLine().Split().Where(x => x != "").Select(x => int.Parse(x.ToString())).ToList();
                ++currentRow;
            }
            return arr;
        }

        public static void PrintMasivZ(MasivZ arr, Iinterface ui)
        {
            foreach (var symb in arr.Symbols)
                ui.Write(symb + " ");

            ui.Write("\n");

            foreach (var code in arr.Codes)
                ui.Write(code + " ");
            ui.Write("\n");
        }

        public static char IntTochar(int x)
        {
            return (char)x;
        }
        public static int StringToInt(string x)
        {
            return int.Parse(x);
        }
    }
}
