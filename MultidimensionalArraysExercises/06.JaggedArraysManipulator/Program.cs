using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.JaggedArraysManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsNumber = int.Parse(Console.ReadLine());
            double[][] matrix = new double[rowsNumber][];

            for (int i = 0; i < rowsNumber; i++)
            {
                List<int> numbers = Console.ReadLine().Split(' ' , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                matrix[i] = new double[numbers.Count];

                for (int j = 0; j < numbers.Count; j++)
                {
                    matrix[i][j] = numbers[j];
                }
            }

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                if (matrix[i].Length == matrix[i + 1].Length)
                {
                    for (int j = i; j < i + 2; j++)
                    {
                        for (int k = 0; k < matrix[j].Length; k++)
                        {
                            matrix[j][k] *= 2;
                        }
                    }
                }
                else
                {
                    for (int j = i; j < i + 2; j++)
                    {
                        for (int k = 0; k < matrix[j].Length; k++)
                        {
                            matrix[j][k] /= 2;
                        }
                    }
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                List<string> commandInfo = input.Split(' ' , StringSplitOptions.RemoveEmptyEntries).ToList();
                string command = commandInfo[0];
                int currRow = int.Parse(commandInfo[1]);
                int currCol = int.Parse(commandInfo[2]);
                double value = double.Parse(commandInfo[3]);

                if (currRow >= 0 && currRow <= matrix.GetLength(0) - 1)
                {
                    if (!(currCol >= 0 && currCol <= matrix[currRow].Length - 1))
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }

                if (command == "Add")
                {
                    matrix[currRow][currCol] += value;
                }
                else if (command == "Subtract")
                {
                    matrix[currRow][currCol] -= value;
                }
            }

            foreach (var subArray in matrix)
            {
                Console.WriteLine(string.Join(" " , subArray));
            }
        }
    }
}
