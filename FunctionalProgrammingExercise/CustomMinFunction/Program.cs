using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Func<List<int>, int> minNum = GetMinNum;
            Console.WriteLine(minNum(numbers)); 
           
        }

        static int GetMinNum (List<int> numbers)
        {
            int minNum = int.MaxValue;

            foreach (var number in numbers)
            {
                if (number < minNum)
                {
                    minNum = number;
                }
            }
            return minNum;
        }
    }
}
