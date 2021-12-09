using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sizeInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            int rowsNum = sizeInput[0];
            int colsNum = sizeInput[1];
            char[,] matrix = new char[rowsNum, colsNum];
            string snake = Console.ReadLine();
            int indexOfSnakeChar = 0;

            for (int i = 0; i < rowsNum; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                    {
                        matrix[i, j] = snake[indexOfSnakeChar];
                        indexOfSnakeChar++;

                        if (indexOfSnakeChar > snake.Length - 1)
                        {
                            indexOfSnakeChar = 0;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = snake[indexOfSnakeChar];
                        indexOfSnakeChar++;

                        if (indexOfSnakeChar > snake.Length - 1)
                        {
                            indexOfSnakeChar = 0;
                        }
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }

                Console.WriteLine();
            }
        }
    }
}
