using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                List<string> command = input.Split(new char[] { ',' , ' '} , StringSplitOptions.RemoveEmptyEntries).ToList();

                if (command[0] == "Push")
                {
                    List<string> toPush = new List<string>();
                    for (int i = 1; i <= command.Count - 1; i++)
                    {
                        toPush.Add(command[i]);
                    }

                    stack.Push(toPush.ToArray());
                }
                else if (command[0] == "Pop")
                {
                    stack.Pop();
                }
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var element in stack)
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}
