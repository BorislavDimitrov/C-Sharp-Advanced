using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" " , StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] array = input.GetRange(1, input.Count - 1).ToArray() ;
            ListyIterator<string> listy = new ListyIterator<string>(array);

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                if (command == "Move")
                {
                    Console.WriteLine(listy.Move());
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(listy.HasNext());
                }
                else if (command == "Print")
                {
                    listy.Print();
                }
                else if (command == "PrintAll")
                {
                    foreach (var element in listy)
                    {
                        Console.Write($"{element} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
