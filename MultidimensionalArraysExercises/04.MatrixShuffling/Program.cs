using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sizeInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            int rowsNum = sizeInput[0];
            int colsNum = sizeInput[1];
            string[,] matrix = new string[rowsNum, colsNum];

            for (int i = 0; i < rowsNum; i++)
            {
                List<string> numbers = Console.ReadLine().Split(' ' , StringSplitOptions.RemoveEmptyEntries).ToList();
                 
                for (int j = 0; j < numbers.Count; j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                List<string> commandInfo = input.Split().ToList();

                if (commandInfo[0] == "swap" && commandInfo.Count == 5)
                {
                    int firstRow = int.Parse(commandInfo[1]);
                    int firstCol = int.Parse(commandInfo[2]);
                    int secondRow = int.Parse(commandInfo[3]);
                    int secondCol = int.Parse(commandInfo[4]);

                    if ((firstRow >= 0 && firstRow <= matrix.GetLength(0) - 1) && (firstCol >= 0 && firstCol <= matrix.GetLength(1) - 1) 
                      && (secondRow >= 0 && secondRow <= matrix.GetLength(0) - 1) && (secondCol >= 0 && secondCol <= matrix.GetLength(1) - 1))
                    {
                        string temp = matrix[firstRow , firstCol];
                        matrix[firstRow, firstCol] = matrix[secondRow , secondCol];
                        matrix[secondRow, secondCol] = temp;

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write(matrix[i,j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
