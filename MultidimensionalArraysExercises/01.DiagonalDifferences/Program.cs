using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.DiagonalDifferences
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size , size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }

            int firstDiagonalSum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                firstDiagonalSum += matrix[i, i];
            }

            int rowIndex = matrix.GetLength(0) - 1;
            int secondDiagonalSum = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                secondDiagonalSum += matrix[rowIndex, i];
                rowIndex--;
            }

            Console.WriteLine(Math.Abs(firstDiagonalSum - secondDiagonalSum));
        }
    }
}
