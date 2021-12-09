using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                string input = Console.ReadLine();
                List<char> chars = new List<char>();

                foreach (var character in input)
                {
                    if (character != ' ')
                    {
                        chars.Add(character);
                    }
                    
                }

                for (int j = 0; j < chars.Count; j++)
                {
                    matrix[i, j] = chars[j];
                }
            }

            int deletedKnights = 0;

            while (true)
            {
                Dictionary<List<int>, int> indexMatch = new Dictionary<List<int>, int>();

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            int matches = 0;

                            if (row - 2 >= 0 && row - 2 <= matrix.GetLength(0) - 1
                                && col - 1 >= 0 && col - 1 <= matrix.GetLength(1) - 1)
                            {
                                if (matrix[row - 2, col - 1] == 'K')
                                {
                                    matches++;
                                }
                            }

                            if (row - 2 >= 0 && row - 2 <= matrix.GetLength(0) - 1
                                && col + 1 >= 0 && col + 1 <= matrix.GetLength(1) - 1)
                            {
                                if (matrix[row - 2, col + 1] == 'K')
                                {
                                    matches++;
                                }
                            }

                            if (row + 2 >= 0 && row + 2 <= matrix.GetLength(0) - 1
                                && col - 1 >= 0 && col - 1 <= matrix.GetLength(1) - 1)
                            {
                                if (matrix[row + 2, col - 1] == 'K')
                                {
                                    matches++;
                                }
                            }

                            if (row + 2 >= 0 && row + 2 <= matrix.GetLength(0) - 1
                                && col + 1 >= 0 && col + 1 <= matrix.GetLength(1) - 1)
                            {
                                if (matrix[row + 2, col + 1] == 'K')
                                {
                                    matches++;
                                }
                            }

                            if (col - 2 >= 0 && col - 2 <= matrix.GetLength(1) - 1
                                && row - 1 >= 0 && row - 1 <= matrix.GetLength(0) - 1)
                            {
                                if (matrix[row - 1, col - 2] == 'K')
                                {
                                    matches++;
                                }
                            }

                            if (col - 2 >= 0 && col - 2 <= matrix.GetLength(1) - 1
                                && row + 1 >= 0 && row + 1 <= matrix.GetLength(0) - 1)
                            {
                                if (matrix[row + 1, col - 2] == 'K')
                                {
                                    matches++;
                                }
                            }

                            if (col + 2 >= 0 && col + 2 <= matrix.GetLength(1) - 1
                                && row - 1 >= 0 && row - 1 <= matrix.GetLength(0) - 1)
                            {
                                if (matrix[row - 1, col + 2] == 'K')
                                {
                                    matches++;
                                }
                            }

                            if (col + 2 >= 0 && col + 2 <= matrix.GetLength(1) - 1 
                                && row + 1 >= 0 && row +1 <= matrix.GetLength(0) - 1)
                            {
                                if (matrix[row + 1 , col + 2] == 'K')
                                {
                                    matches++;
                                }
                            }

                            if (matches > 0)
                            {
                                List<int> index = new List<int>();
                                index.Add(row);
                                index.Add(col);
                                indexMatch.Add(index , matches);
                            }
                        }
                    }
                }

                indexMatch = indexMatch.OrderByDescending(x => x.Value).ToDictionary(x => x.Key , y => y.Value);

                if (indexMatch.Count > 0)
                {
                    foreach (var index in indexMatch)
                    {
                        int rowIndex = index.Key[0];
                        int colIndex = index.Key[1];
                        matrix[rowIndex, colIndex] = '0';
                        deletedKnights++;
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(deletedKnights);
        }
    }
}
