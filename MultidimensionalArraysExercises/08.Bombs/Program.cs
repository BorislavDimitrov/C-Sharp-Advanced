using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeInput = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeInput, sizeInput];


            for (int i = 0; i < sizeInput; i++)
            {
                List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

                for (int j = 0; j < numbers.Count; j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }

            List<string> bombsIndexes = Console.ReadLine().Split().ToList();

            for (int i = 0; i < bombsIndexes.Count; i++)
            {
                int rowIndex = int.Parse(bombsIndexes[i][0].ToString());
                int colIndex = int.Parse(bombsIndexes[i][2].ToString());
                int value = matrix[rowIndex , colIndex];

                if (value > 0 )
                {
                    bombsIndexes[i] += "YES";

                    for (int row = rowIndex + - 1; row < rowIndex + 2; row++)
                    {
                        for (int col = colIndex - 1; col < colIndex + 2; col++)
                        {
                            if (row >= 0 && row <= matrix.GetLength(0) - 1 && col >=0 && col <= matrix.GetLength(1) - 1 && matrix[row , col] > 0)
                            {
                                matrix[row, col] -= value;
                            }
                        }
                    }
                } 
            }

            foreach (var index in bombsIndexes)
            {
                if (index.Contains("YES"))
                {
                    matrix[int.Parse(index[0].ToString()), int.Parse(index[2].ToString())] = 0;
                }
            }

            int activeCells = 0;
            int sum = 0;

            foreach (var number in matrix)
            {
                if (number > 0)
                {
                    sum += number;
                    activeCells++;
                }
            }

            Console.WriteLine($"Alive cells: {activeCells}");
            Console.WriteLine($"Sum: {sum}");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j < matrix.GetLength(1) - 1)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(matrix[i, j]);
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
