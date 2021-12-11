using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodictTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());
            SortedSet<string> chemicals = new SortedSet<string>();

            for (int i = 0; i < inputLines; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                for (int j = 0; j < input.Count; j++)
                {
                    chemicals.Add(input[j]);
                }
            }

            Console.WriteLine(string.Join(" " , chemicals));
        }
    }
}
