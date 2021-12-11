using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sizeInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            int firsSetSize = sizeInput[0];
            int secondSetSize = sizeInput[1];
            HashSet<int> result = new HashSet<int>();
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            List<int> numbersInFirstSet = new List<int>();

            for (int i = 0; i < firsSetSize; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < secondSetSize; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var number in firstSet)
            {
                if (secondSet.Contains(number))
                {
                    result.Add(number);
                }
            }

            Console.WriteLine(string.Join(" " , result)) ;
        }
    }
}
