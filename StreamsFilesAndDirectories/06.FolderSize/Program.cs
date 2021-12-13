using System;
using System.IO;

namespace _06.FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = @"C:\TEMP\";
            double sum = 0;
            
            string[] files = Directory.GetFiles(directory);
       
            foreach (var file in files)
            {
                FileInfo currFile = new FileInfo(file);
                sum += currFile.Length;
            }

            Console.WriteLine(sum);
        }
    }
}
