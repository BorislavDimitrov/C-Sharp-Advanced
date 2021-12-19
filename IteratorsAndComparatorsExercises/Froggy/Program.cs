using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> stones = Console.ReadLine().Split(", " , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Lake lake = new Lake(stones);
            List<int> result = new List<int>();

            foreach (var stone in lake)
            {
                result.Add(stone);
            }

            Console.WriteLine(string.Join(", " , result)); ;
        }
    }
}
