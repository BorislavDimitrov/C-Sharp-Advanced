using System;
using System.Collections.Generic;
using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"C:\TEMP\StreamsFilesAndDirectoriesExercise\LineNumbersInput.txt");
            List<string> listOfStrings = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                int lettersCounter = 0;
                int symbolsCounter = 0;

                foreach (var character in lines[i])
                {
                    if (char.IsLetter(character))
                    {
                        lettersCounter++;
                    }
                    else if (char.IsWhiteSpace(character))
                    {
                        symbolsCounter++;
                    }
                }

                listOfStrings.Add($"Line {i + 1} {lines[i]} ({lettersCounter})({symbolsCounter})");
            }
            File.WriteAllLines(@"C:\TEMP\StreamsFilesAndDirectoriesExercise\LineNumbersOutput.txt", listOfStrings);
        }
    }
}
