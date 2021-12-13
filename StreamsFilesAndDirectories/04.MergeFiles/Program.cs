using System;
using System.Collections.Generic;
using System.IO;

namespace _04.MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader sr1 = new StreamReader(@"C:\TEMP\MergeFilesFirstInput.txt");
            using StreamReader sr2 = new StreamReader(@"C:\TEMP\MergeFilesSecondInput.txt");
            using StreamWriter sw = new StreamWriter(@"C:\TEMP\MergeFilesOutput.txt");
            SortedSet<int> numbers = new SortedSet<int>();

            while (!sr1.EndOfStream)
            {
                int line = int.Parse(sr1.ReadLine());
                numbers.Add(line);
            }

            while (!sr2.EndOfStream)
            {
                int line = int.Parse(sr2.ReadLine());
                numbers.Add(line);
            }

            foreach (var number in numbers)
            {
                sw.WriteLine(number);
            }

        }
    }
}
