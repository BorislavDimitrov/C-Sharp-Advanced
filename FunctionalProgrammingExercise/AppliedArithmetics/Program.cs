using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Func<int, int> arithmeticOperation = new Func<int, int>(x => x / 2);
            Action< string,List<int>> printNums = PrintNumbers;
            while (true)
            {
                string input = Console.ReadLine();
                bool isArithmeticOperation = false;
                if (input == "end")
                {
                    break;
                }

                if (input == "add")
                {
                    arithmeticOperation = x => x + 1;
                    isArithmeticOperation = true;
                }
                else if (input == "multiply")
                {
                    arithmeticOperation = x => x * 2;
                    isArithmeticOperation = true;
                }
                else if (input == "subtract")
                {
                    arithmeticOperation = x => x - 1;
                    isArithmeticOperation = true;
                }
                else if (input == "print")
                {
                    printNums(" " , numbers);
                }

                if (isArithmeticOperation)
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i] = arithmeticOperation(numbers[i]);
                    }
                }
            }
        }

        static void PrintNumbers (string separator , List<int> numbers)
        {
            StringBuilder textToPrint = new StringBuilder();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == 0)
                {
                    textToPrint.Append(numbers[i]);
                }
                else
                {
                    textToPrint.Append(" " + numbers[i]);
                }
            }
            Console.WriteLine(textToPrint);
        }
    }
}
