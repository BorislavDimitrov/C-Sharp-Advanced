using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastNum = int.Parse(Console.ReadLine());
            List<int> numbersToDivide = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbers = new List<int>();

            for (int i = 1; i <= lastNum; i++)
            {
                numbers.Add(i);
            }

            List<Predicate<int>> predicates = GetAllPredicates(numbersToDivide);
            List<int> resultNumbers = new List<int>();

            foreach (var number in numbers)
            {
                bool isDividible = true;
                foreach (var predicate in predicates)
                {
                    if (!predicate(number))
                    {
                        isDividible = false;
                        break;
                    }
                }

                if (isDividible)
                {
                    resultNumbers.Add(number);
                }
            }

            Console.WriteLine(string.Join(" " , resultNumbers));
        }

        static List<Predicate<int>> GetAllPredicates (List<int> numbersToDivide)
        {
            List<Predicate<int>> newList = new List<Predicate<int>>();
            Predicate<int> isItDividible = new Predicate<int>(x => x % 1 == 0);
            foreach (var number in numbersToDivide)
            {
                isItDividible = x => x % number == 0;
                newList.Add(isItDividible);
            }
            return newList;
        }
    }
}
