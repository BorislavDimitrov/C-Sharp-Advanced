using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> commandInfo = Console.ReadLine().Split().ToList();
                int commandNumber = int.Parse(commandInfo[0]);

                if ( commandNumber == 1)
                {
                    numbers.Push(int.Parse(commandInfo[1]));
                }
                else if (commandNumber == 2)
                {
                    numbers.Pop();
                }
                else if (commandNumber == 3)
                {
                    if (numbers.Count > 0)
                    {
                        Console.WriteLine(numbers.Max());
                    }
                }
                else if (commandNumber == 4)
                {
                    if (numbers.Count > 0)
                    {
                        Console.WriteLine(numbers.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", " , numbers));
        }
    }
}
