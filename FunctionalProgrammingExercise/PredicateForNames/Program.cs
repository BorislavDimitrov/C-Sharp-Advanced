using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();
            Predicate<int> isNumberEven = x => x % 2 == 0;

            foreach (var number in numbers)
            {
                if (isNumberEven(number))
                {
                    evenNumbers.Add(number);
                }
                else
                {
                    oddNumbers.Add(number);
                }
            }

            evenNumbers = SortNumbersInAscendingOrder(evenNumbers);
            oddNumbers = SortNumbersInAscendingOrder(oddNumbers);
            List<int> result = new List<int>();
            result.AddRange(evenNumbers);
            result.AddRange(oddNumbers);
            Console.WriteLine(string.Join(" " , result));

        }

        static List<int> SortNumbersInAscendingOrder (List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return numbers;
        }
    }
}
