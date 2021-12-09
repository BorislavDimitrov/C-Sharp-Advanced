using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sizeInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            int matrixRows = sizeInput[0];
            int matrixCols = sizeInput[1];
            char[,] matrix = new char[matrixRows, matrixCols];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                List<char> numbers = Console.ReadLine().Split(' ' , StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToList();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = numbers[cols];
                }
            }

            int numberOfEqualMatrixes = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                if (rows + 1 > matrix.GetLength(0) - 1)
                {
                    break;
                }

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (cols + 1 > matrix.GetLength(1) - 1)
                    {
                        break;
                    }

                    if (matrix[rows , cols] == matrix[rows , cols + 1] && matrix[rows , cols + 1] == matrix[rows + 1 , cols]
                        && matrix[rows + 1, cols] == matrix[rows + 1 , cols + 1])
                    {
                        numberOfEqualMatrixes++;
                    }
                }
            }
            Console.WriteLine(numberOfEqualMatrixes);
        }
    }
}
