using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Queue<int> nums = new Queue<int>();

            foreach (var number in numbers)
            {
                nums.Enqueue(number);
            }

            while (nums.Count > 0)
            {
                if (nums.Peek() % 2 != 0)
                {
                    nums.Dequeue();
                }
                else
                {
                    if (nums.Count == 1)
                    {
                        Console.Write(nums.Dequeue());
                    }
                    else
                    {
                        Console.Write(nums.Dequeue() + ", ");
                    }
                }
            }
        }
    }
}
