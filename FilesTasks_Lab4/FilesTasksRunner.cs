using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface;
using UserInterface.Extensions;
using System.IO;

namespace FilesTasks_Lab4
{
    public class FilesTasksRunner : IRunner
    {
        public Iinterface UserInterface { get; set; }

        public FilesTasksRunner(Iinterface ui)
        {
            UserInterface = ui;
        }

        public void Run()
        {
            int N = 0;
            List<int> arr = new List<int>();
            MasivZ arrZ = new MasivZ();
            string path1 = "";
            string path2 = "";
            string path3 = "";

            UserInterface.Write("Input N \n");
            try
            {
                N = int.Parse(UserInterface.Read());
                arr.Capacity = N;

                ArrayEditor.FillArr(arr);


                UserInterface.Write("input name of file (without extension) \n");
                path1 = @"..\..\..\Mas\" + UserInterface.Read() + ".txt";

                ArrayIO.WriteArray(arr, path1);

                List<List<int>> arrB = ArrayEditor.ConvertToTwoRank(ArrayIO.ReadArray(path1));

                UserInterface.Write("input name of file (without extension) \n");
                path2 = @"..\..\..\Mas\" + UserInterface.Read() + ".txt";

                ArrayIO.WriteArray(arrB, path2);

                arrZ.CreateFromIntArray(arrB);

                MasivZ arrC = arrZ.UpperToLower();

                UserInterface.Write("input name of file (without extension) \n");
                path3 = @"..\..\..\Mas\" + UserInterface.Read() + ".txt";

                ArrayIO.WriteArray(arrZ, path3);
                ArrayIO.WriteArray(arrC, path3);

                MasivZ tempZ = ArrayIO.ReadMasivZ(path3);
                MasivZ tempC = ArrayIO.ReadMasivZ(path3);
                UserInterface.Write("Arrays Z and C without escape sequences(start ascii code is 32)\n");
                UserInterface.Write("\nArray C\n");

                ArrayIO.PrintMasivZ(tempC, UserInterface);
                UserInterface.Write("\nArray Z\n");
                ArrayIO.PrintMasivZ(tempZ, UserInterface);

                DirectoryInfo dir = new DirectoryInfo(@"..\..\..\Mas");

                dir.PrintListOfFiles(UserInterface);

                var files = dir.GetFiles();

                var lastTime = files.Select(x => x.CreationTime).Max();
                files.First(x => x.CreationTime == lastTime).MoveTo(@"..\..\..\Mas\newName.txt");

                UserInterface.Write("\nLast creation file was renamed to newName.txt\nNew list of files: \n");
                dir.PrintListOfFiles(UserInterface);
            }
           catch
            { throw new Exception("очепятка"); }
            
        }
    }
}
