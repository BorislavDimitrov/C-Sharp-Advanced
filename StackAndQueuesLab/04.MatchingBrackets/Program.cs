using System;
using System.Collections;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> openBracesIndexes = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    openBracesIndexes.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int startIndex = openBracesIndexes.Pop();
                    int endIndex = i;
                    Console.WriteLine(expression.Substring(startIndex , endIndex - startIndex + 1));
                }
            }
        }
    }
}
