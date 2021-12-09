using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sizeInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            int rowsNum = sizeInput[0];
            int colsNum = sizeInput[1];
            int[,] matrix = new int[rowsNum, colsNum];

            for (int i = 0; i < rowsNum; i++)
            {
                List<int> numbers = Console.ReadLine().Split(' ' , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                for (int j = 0; j < numbers.Count; j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }

            int biggestSum = int.MinValue;
            int start = 0;
            int end = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row + 2 > matrix.GetLength(0) - 1)
                {
                    break;
                }

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col + 2 > matrix.GetLength(1) - 1)
                    {
                        break;
                    }

                    int currSum = 0;

                    for (int i = row; i < row + 3; i++)
                    {
                        for (int j = col; j < col + 3; j++)
                        {
                            currSum += matrix[i, j];
                        }
                    }

                    if (currSum > biggestSum)
                    {
                        biggestSum = currSum;
                        start = row;
                        end = col;
                    }
                }
            }
            Console.WriteLine("Sum = " + biggestSum);

            for (int i = start; i < start + 3; i++)
            {
                for (int j = end; j < end +3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
