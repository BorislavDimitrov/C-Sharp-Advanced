using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> stack = new Stack<int>();

            foreach (var number in numbers)
            {
                stack.Push(number);
            }

            while (true)
            {
                List<string> commantInfo = Console.ReadLine().Split().Select(x => x.ToLower()).ToList();

                if (commantInfo[0] == "end")
                {
                    break;
                }
                else if (commantInfo[0] == "add")
                {
                    stack.Push(int.Parse(commantInfo[1]));
                    stack.Push(int.Parse(commantInfo[2]));
                }
                else if (commantInfo[0] == "remove")
                {
                    if (stack.Count > int.Parse(commantInfo[1]))
                    {
                        for (int i = 0; i < int.Parse(commantInfo[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                    
                }
            }

            Console.WriteLine("Sum: " + stack.Sum());
        }
    }
}
