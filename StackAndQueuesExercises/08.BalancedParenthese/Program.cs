using System;
using System.Collections;
using System.Collections.Generic;

namespace _08.BalancedParenthese
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> parentheses = new Stack<char>();
            bool isClosed = false;

            for (int i = 0; i < input.Length; i++)
            {
                char currSymbol = input[i];

                if (currSymbol == '(' || currSymbol == '[' || currSymbol == '{')
                {
                    if (isClosed)
                    {
                        Console.WriteLine("No");
                        return;
                    }
                    parentheses.Push(input[i]);
                }
                else if (currSymbol == ')' || currSymbol == ']' || currSymbol == '}')
                {
                    if (parentheses.Count > 0)
                    {
                        if (currSymbol == ')' && parentheses.Peek() == '(')
                        {
                            parentheses.Pop();
                        }
                        else if (currSymbol == '}' && parentheses.Peek() == '{')
                        {
                            parentheses.Pop();
                        }
                        else if (currSymbol == ']' && parentheses.Peek() == '[')
                        {
                            parentheses.Pop();
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
               
            }

            if (parentheses.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            
        }
    }
}