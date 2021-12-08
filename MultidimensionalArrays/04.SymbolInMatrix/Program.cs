using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInputs = int.Parse(Console.ReadLine());
            char[,] matrix = new char[numberInputs, numberInputs];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string input = Console.ReadLine();
                List<char> chars = new List<char>();

                foreach (var character in input)
                {
                    chars.Add(character);
                }

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = chars[j];
                }
            }

            char symbolToFind = char.Parse(Console.ReadLine());
            bool charExist = false;
            int rowIndex = 0;
            int colIndex = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == symbolToFind)
                    {
                        charExist = true;
                        rowIndex = i;
                        colIndex = j;
                        break;
                    }
                }

                if (charExist)
                {
                    break;
                }
            }

            if (charExist)
            {
                Console.WriteLine($"({rowIndex}, {colIndex})");
            }
            else
            {
                Console.WriteLine($"{symbolToFind} does not occur in the matrix");
            }

        }
    }
}
