using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeInput = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeInput, sizeInput];
            List<string> commands = Console.ReadLine().Split().ToList();
            string start = string.Empty;
            int coals = 0;

            for (int i = 0; i < sizeInput; i++)
            {
                List<char> chars = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToList();

                for (int j = 0; j < sizeInput; j++)
                {
                    if (chars[j] == 's')
                    {
                        start = i + ", " + j;
                    }
                    else if (chars[j] == 'c')
                    {
                        coals++;
                    }

                    matrix[i, j] = chars[j];
                }
            }

            
            string currIndex = start;
            int coalsCount = 0;

            for (int i = 0; i < commands.Count; i++)
            {
                int currRow = int.Parse(currIndex[0].ToString());
                int currCol = int.Parse(currIndex[3].ToString());

                if (commands[i] == "left")
                {
                    if (currCol - 1 >= 0 && currCol - 1 <= matrix.GetLength(1) - 1)
                    {
                        currIndex = currRow.ToString() + ", " + (currCol - 1).ToString();

                        if (matrix[currRow , currCol - 1] == 'c')
                        {
                            coalsCount++;
                            matrix[currRow, currCol - 1] = '*';

                            if (coalsCount == coals)
                            {
                                Console.WriteLine($"You collected all coals! ({currIndex})");
                                return;
                            }
                        }
                        else if (matrix[currRow, currCol - 1] == 'e')
                        {
                            Console.WriteLine($"Game over! ({currIndex})");
                            return;
                        }
                    }
                }
                else if (commands[i] == "right")
                {
                    if (currCol + 1 >= 0 && currCol + 1 <= matrix.GetLength(1) - 1)
                    {
                        currIndex = currRow.ToString() + ", " + (currCol + 1).ToString();

                        if (matrix[currRow, currCol + 1] == 'c')
                        {
                            coalsCount++;
                            matrix[currRow, currCol + 1] = '*';

                            if (coalsCount == coals)
                            {
                                Console.WriteLine($"You collected all coals! ({currIndex})");
                                return;
                            }
                        }
                        else if (matrix[currRow, currCol + 1] == 'e')
                        {
                            Console.WriteLine($"Game over! ({currIndex})");
                            return;
                        }
                    }
                }
                else if (commands[i] == "down")
                {
                    if (currRow + 1 >= 0 && currRow + 1 <= matrix.GetLength(0) - 1)
                    {
                        currIndex = (currRow + 1).ToString() + ", " + currCol.ToString();

                        if (matrix[currRow + 1, currCol] == 'c')
                        {
                            coalsCount++;
                            matrix[currRow + 1 , currCol] = '*';

                            if (coalsCount == coals)
                            {
                                Console.WriteLine($"You collected all coals! ({currIndex})");
                                return;
                            }
                        }
                        else if (matrix[currRow + 1, currCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({currIndex})");
                            return;
                        }
                    }
                }
                else if (commands[i] == "up")
                {
                    if (currRow - 1 >= 0 && currRow - 1 <= matrix.GetLength(0) - 1)
                    {
                        currIndex = (currRow - 1).ToString() + ", " + currCol.ToString();

                        if (matrix[currRow - 1, currCol] == 'c')
                        {
                            coalsCount++;
                            matrix[currRow - 1, currCol] = '*';

                            if (coalsCount == coals)
                            {
                                Console.WriteLine($"You collected all coals! ({currIndex})");
                                return;
                            }
                        }
                        else if (matrix[currRow - 1, currCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({currIndex})");
                            return;
                        }
                    }
                }
            }

            Console.WriteLine($"{coals - coalsCount} coals left. ({currIndex})");
        }
    }
}
