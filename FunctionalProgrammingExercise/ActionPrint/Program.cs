using System;
using System.Collections.Generic;
using System.Linq;

namespace ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            Action<List<string>> printWords = PrintWords;
            printWords(words);
        }

        static void PrintWords(List<string> words)
        {
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
