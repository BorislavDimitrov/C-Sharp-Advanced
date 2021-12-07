using System;
using System.Collections;
using System.Collections.Generic;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Queue<string> names = new Queue<string>();

            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    Console.WriteLine(string.Join("\n" , names));
                    names.Clear();
                }
                else
                {
                    names.Enqueue(input);
                }
            }

            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
