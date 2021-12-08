using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> infoNums = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> nums = new Stack<int>();
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < infoNums[0]; i++)
            {
                nums.Push(input[i]);
            }

            for (int j = 0; j < infoNums[1]; j++)
            {
                nums.Pop();
            }

            if (nums.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (nums.Contains(infoNums[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(nums.Min());
                }
            }
        }
    }
}
