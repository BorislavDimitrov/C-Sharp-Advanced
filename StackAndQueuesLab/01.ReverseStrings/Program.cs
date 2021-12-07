using System;
using System.Collections.Generic;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Stack<char> charsStack = new Stack<char>();

            foreach (var character in text)
            {
                charsStack.Push(character);
            }

            Console.WriteLine(string.Join("" , charsStack));

        }
    }
}
