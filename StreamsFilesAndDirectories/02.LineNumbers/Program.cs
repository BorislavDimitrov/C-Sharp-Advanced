using System;
using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader sr = new StreamReader(@"C:\TEMP\LineNumbersInput.txt");
            {
                using StreamWriter sw = new StreamWriter(@"C:\TEMP\LineNumbersOutput.txt");
                {
                    int rowCounter = 1;

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                         sw.WriteLine($"{rowCounter}. " + line);
                        rowCounter++;
                    }
                }
            }
        }
    }
}
