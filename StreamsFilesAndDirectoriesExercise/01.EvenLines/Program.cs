using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _01.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
           using StreamReader sr = new StreamReader(@"C:\TEMP\StreamsFilesAndDirectoriesExercise\EvenLinesInput.txt");
           using StreamWriter sw = new StreamWriter(@"C:\TEMP\StreamsFilesAndDirectoriesExercise\EvenLinesOutput.txt");
            char[] symbolsToReplace = new char[] { '-' , ',' , '.' , '?' , '!'};
            int counter = 0;

            while (!sr.EndOfStream)
            {
                string currentLine = sr.ReadLine();

                if (counter % 2 == 0)
                {
                    foreach (var symbol in symbolsToReplace)
                    {
                        currentLine = currentLine.Replace(symbol, '@');                      
                    }

                    currentLine = string.Join(" " , currentLine.Split().Reverse());
                    sw.WriteLine(currentLine);
                }
                
                counter++;
            }


        }
    }
}
