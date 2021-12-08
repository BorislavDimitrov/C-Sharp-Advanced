using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sizeInput = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            int rows = sizeInput[0];
            int cols = sizeInput[1];
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i ,j ] = numbers[j];
                }
            }

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int currColSum = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    currColSum += matrix[i, j];
                }
                Console.WriteLine(currColSum);
            }
        }
    }
}
