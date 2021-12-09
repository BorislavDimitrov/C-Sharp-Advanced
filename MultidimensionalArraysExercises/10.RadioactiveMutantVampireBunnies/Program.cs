using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sizeInput = Console.ReadLine().Split(" " , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            char[,] matrix = new char[sizeInput[0], sizeInput[1]];
            int[] start = new int[2];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string chars = Console.ReadLine();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (chars[j] == 'P')
                    {
                        start[0] = i;
                        start[1] = j;
                    }
                    matrix[i, j] = chars[j];
                }
            }

            string commands = Console.ReadLine();

            int[] currPosition = start.ToArray();
            bool isWin = true;
            bool isOut = false;

            for (int i = 0; i < commands.Length; i++)
            {
                int currRow = currPosition[0];
                int currCol = currPosition[1];
                
                if (commands[i] == 'L')
                {
                    matrix[currRow, currCol] = '.';
                    if (currCol - 1 < 0 || currCol - 1 > matrix.GetLength(1) - 1)
                    {
                        isOut = true;
                    }

                    if (!isOut)
                    {
                        if (matrix[currRow, currCol - 1] == 'B')
                        {
                            currPosition[0] = currRow;
                            currPosition[1] = currCol - 1;
                            isWin = false;
                        }
                        else
                        {
                            matrix[currRow, currCol - 1] = 'P';
                            currPosition[0] = currRow;
                            currPosition[1] = currCol - 1;
                        }
                    }
                }
                else if (commands[i] == 'R')
                {
                    matrix[currRow, currCol] = '.';
                    if (currCol + 1 < 0 || currCol + 1 > matrix.GetLength(1) - 1)
                    {
                        isOut = true;
                    }

                    if (!isOut)
                    { 
                        if (matrix[currRow, currCol + 1] == 'B')
                        {
                            currPosition[0] = currRow;
                            currPosition[1] = currCol + 1;
                            isWin = false;
                        }
                        else
                        {
                            matrix[currRow, currCol + 1] = 'P';
                            currPosition[0] = currRow;
                            currPosition[1] = currCol + 1;
                        }
                    }                 
                }
                else if (commands[i] == 'U')
                {
                    matrix[currRow, currCol] = '.';
                    if (currRow - 1 < 0 || currRow - 1 > matrix.GetLength(0) - 1)
                    {
                        isOut = true;
                    }

                    if (!isOut)
                    {
                        if (matrix[currRow - 1, currCol] == 'B')
                        {
                            currPosition[0] = currRow - 1;
                            currPosition[1] = currCol;
                            isWin = false;
                        }
                        else
                        {
                            matrix[currRow - 1, currCol] = 'P';
                            currPosition[0] = currRow - 1;
                            currPosition[1] = currCol;
                        }
                    }                
                }
                else if (commands[i] == 'D')
                {
                    matrix[currRow, currCol] = '.';
                    if (currRow + 1 < 0 || currRow + 1 > matrix.GetLength(0) - 1)
                    {
                        isOut = true;
                    }

                    if (!isOut)
                    {
                        if (matrix[currRow + 1, currCol] == 'B')
                        {
                            currPosition[0] = currRow + 1;
                            currPosition[1] = currCol;
                            isWin = false;
                        }
                        else
                        {
                            matrix[currRow + 1, currCol] = 'P';
                            currPosition[0] = currRow + 1;
                            currPosition[1] = currCol;
                        }
                    }                 
                }

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row , col] == 'B')
                        {
                            if (row - 1 >= 0 && row - 1 <= matrix.GetLength(0) - 1)
                            {
                                if (matrix[row - 1,col] == '.' || matrix[row - 1 , col] == 'P')
                                {
                                    if (matrix[row - 1 , col] == 'P')
                                    {
                                        isWin = false;
                                    }
                                    matrix[row - 1, col] = 'c';
                                }
                            }

                            if (row + 1 >= 0 && row + 1 <= matrix.GetLength(0) - 1)
                            {
                                if (matrix[row + 1, col] == '.' || matrix[row + 1 , col] == 'P')
                                {
                                    if (matrix[row + 1 , col ] == 'P')
                                    {
                                        isWin = false;
                                    }

                                    matrix[row + 1, col] = 'c';
                                }
                            }

                            if (col - 1 >= 0 && col - 1 <= matrix.GetLength(1) - 1)
                            {
                                if (matrix[row , col - 1] == '.' || matrix[row , col - 1] == 'P')
                                {
                                    if (matrix[row , col - 1] == 'P')
                                    {
                                        isWin = false;
                                    }
                                    matrix[row, col - 1] = 'c';
                                }
                            }

                            if (col + 1 >= 0 && col + 1 <= matrix.GetLength(1) - 1)
                            {
                                if (matrix[row , col + 1] == '.' || matrix[row , col + 1] == 'P')
                                {
                                    if (matrix[row , col + 1] == 'P')
                                    {
                                        isWin = false;
                                    }
                                    matrix[row, col + 1] = 'c';
                                }
                            }
                        }                      
                    }
                }

                for (int n = 0; n < matrix.GetLength(0); n++)
                {
                    for (int m = 0; m < matrix.GetLength(1); m++)
                    {
                        if (matrix[n, m] == 'c')
                        {
                            matrix[n, m] = 'B';
                        }
                    }
                }

                if (isOut)
                {
                    break;
                }
                else if(!isWin)
                {
                    break;
                }

            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                        Console.Write(matrix[row , col]);                                     
                }
                Console.WriteLine();
            }

            if (isWin)
            {
                Console.WriteLine($"won: {string.Join(" " , currPosition)}");
            }
            else
            {
                Console.WriteLine($"dead: {string.Join(" ", currPosition)}");
            }
        }
    }
}
