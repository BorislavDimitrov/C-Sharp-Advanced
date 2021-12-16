using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersRange = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbers = new List<int>();

            for (int i = numbersRange[0]; i <= numbersRange[1]; i++)
            {
                numbers.Add(i);
            }
            string condition = Console.ReadLine();
            Predicate<int> getNumberByCondition = new Predicate<int>(x => x % 2 == 0);

            if (condition == "odd")
            {
                getNumberByCondition = x => x % 2 != 0;
            }
            else if (condition == "even")
            {
                getNumberByCondition = x => x % 2 == 0;
            }

            List<int> numsResult = new List<int>();

            foreach (var number in numbers)
            {
                if (getNumberByCondition(number))
                {
                    numsResult.Add(number);
                }
            }
            Console.WriteLine(string.Join(" " , numsResult));
        }
    }
}
