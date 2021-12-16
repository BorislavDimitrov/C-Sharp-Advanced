using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            double divideNum = double.Parse(Console.ReadLine());
            numbers = ReverseNumbers(numbers , x => x % divideNum == 0);
            Console.WriteLine(string.Join(" " , numbers));

        }

        static List<double> ReverseNumbers (List<double> numbers , Predicate<double> predicate)
        {
            List<double> newList = new List<double>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                double temp = numbers[i];
                numbers[i] = numbers[numbers.Count - 1 - i];
                numbers[numbers.Count - 1 - i] = temp;
            }

            foreach (var number in numbers)
            {
                if (!predicate(number))
                {
                    newList.Add(number);
                }
            }

            return newList;
        }
    }
}
