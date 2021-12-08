using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sizeInput = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            int rows = sizeInput[0];
            int cols = sizeInput[1];
            int[ , ] matrix = new int[rows , cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                List<int> numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }

            List<int> topRowNums = new List<int>();
            List<int> bottomRownumbs = new List<int>();
            int biggestSum = 0;

            for (int i = 0; i < matrix.GetLength(0); i ++)
            {

                if (matrix.GetLength(0) - 1 < i + 1)
                {
                    break;
                }

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix.GetLength(1) - 1  < j + 1)
                    {
                        break;
                    }

                    List<int> currTopRowsNums = new List<int>();
                    List<int> currBottomRowNumbs = new List<int>();
                    int currSum = 0;

                    currTopRowsNums.Add(matrix[i , j]);
                    currTopRowsNums.Add(matrix[i,j + 1]);

                    currBottomRowNumbs.Add(matrix[i + 1 , j]);
                    currBottomRowNumbs.Add(matrix[i + 1 , j + 1]);

                    currSum += matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                    if (biggestSum < currSum)
                    {
                        biggestSum = currSum;
                        topRowNums = currTopRowsNums;
                        bottomRownumbs = currBottomRowNumbs;
                    }

                }
            }

            Console.WriteLine(string.Join(" " , topRowNums));
            Console.WriteLine(string.Join(" " , bottomRownumbs));
            Console.WriteLine(biggestSum);
        }
    }
}
