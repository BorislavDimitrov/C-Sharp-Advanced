using System;

namespace _07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsNum = int.Parse(Console.ReadLine());
            int[][] array = new int[rowsNum][];
            array[0] = new int[1];
            array[0][0] = 1;

            for (int i = 1; i < array.GetLength(0); i++)
            {
                array[i] = new int[i + 1];

                for (int j = 0; j < array[i].Length; j++)
                {
                    if (j == 0 || j == array[i].Length - 1)
                    {
                        array[i][j] = 1;
                    }
                    else
                    {
                        array[i][j] = array[i - 1][j] + array[i - 1][j - 1];
                    }
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine(string.Join(" " , array[i]));
            }
        }
    }
}
