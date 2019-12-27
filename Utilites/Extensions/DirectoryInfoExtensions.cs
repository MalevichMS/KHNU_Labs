using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserInterface.Extensions
{
    public static class DirectoryInfoExtensions
    {
        public static void PrintListOfFiles(this DirectoryInfo dir, Iinterface ui)
        {
            var files = dir.GetFiles();
            foreach (var file in files)
            {
                ui.Write("File name: " + file.Name + "\tCreation time: " + file.CreationTime.ToString() + "\n");
            }
        }
    }
}
