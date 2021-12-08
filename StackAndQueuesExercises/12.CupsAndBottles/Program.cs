using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cupsList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bottlesList = Console.ReadLine().Split().Select(int.Parse).ToList();
            Queue<int> cups = new Queue<int>(cupsList);
            Stack<int> bottles = new Stack<int>(bottlesList);
            int wasterLiters = 0;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                int currCup = cups.Peek();

                while (currCup > 0)
                {
                    int currBottle = bottles.Pop();

                    if (currCup - currBottle >= 0)
                    {
                        currCup -= currBottle;
                    }
                    else if (currCup - currBottle < 0)
                    {
                        int wastedWater = currBottle - currCup;
                        wasterLiters += wastedWater;
                        currCup -= currBottle;
                    }

                    if (currCup <= 0)
                    {
                        cups.Dequeue();
                    }
                }
            }

            if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" " , bottles)}");
            }
            else if (bottles.Count == 0)
            {
                Console.WriteLine($"Cups: {string.Join(" " , cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wasterLiters}");
        }
    }
}
