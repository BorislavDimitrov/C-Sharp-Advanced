using System;
using System.Collections.Generic;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesNum = int.Parse(Console.ReadLine());
            HashSet<int> resultNumber = new HashSet<int>();
            HashSet<int> allNums = new HashSet<int>();

            for (int i = 0; i < linesNum; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (resultNumber.Contains(number))
                {
                    resultNumber.Remove(number);
                }
                else
                {
                    resultNumber.Add(number);
                }
                allNums.Add(number);
            }


            foreach (var number in allNums)
            {
                if (!resultNumber.Contains(number))
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
