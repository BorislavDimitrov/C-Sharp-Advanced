using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsNum = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rowsNum][];

            for (int i = 0; i < rowsNum; i++)
            {
                List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
                matrix[i] = new int[numbers.Count];

                for (int j = 0; j < numbers.Count; j++)
                {
                    matrix[i][j] = numbers[j];
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                List<string> commandInfo = input.Split().ToList();
                int row = int.Parse(commandInfo[1]);
                int col = int.Parse(commandInfo[2]);
                int value = int.Parse(commandInfo[3]);

                if (commandInfo[0] == "Add" )
                {
                    if (row >= 0 && row <= matrix.GetLength(0) - 1)
                    {
                        if (col >= 0 && matrix[row].Length - 1 >= col )
                        {
                            matrix[row][col] += value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (commandInfo[0] == "Subtract")
                {
                    if (row >= 0 && row <= matrix.GetLength(0) - 1)
                    {
                        if (col >= 0 && matrix[row].Length - 1 >= col)
                        {
                            matrix[row][col] -= value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
            }

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                Console.WriteLine(string.Join(" " , matrix[rows]));
            }
        }
    }
}
