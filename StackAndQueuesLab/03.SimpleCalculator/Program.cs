using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> expression = Console.ReadLine().Split().ToList();
            Stack<string> stack = new Stack<string>();

            foreach (var symbol in expression)
            {
                stack.Push(symbol);
            }

            int sum = 0;

            while (stack.Count > 0)
            {
                if (stack.Count > 1)
                {
                    StringBuilder textNum = new StringBuilder();
                    string number = (stack.Pop());
                    string symbol = (stack.Pop());
                    textNum.Append(symbol);
                    textNum.Append(number);
                    sum += int.Parse(textNum.ToString());
                }
                else
                {
                    sum += int.Parse(stack.Pop());
                }
            }
            Console.WriteLine(sum);
        }
    }
}
