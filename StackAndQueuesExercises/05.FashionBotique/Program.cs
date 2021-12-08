using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBotique
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> clothes = Console.ReadLine().Split().Select(int.Parse).ToList();
            int eachRackCapacity = int.Parse(Console.ReadLine());
            Stack<int> clothesOrder = new Stack<int>();

            foreach (var cloth in clothes)
            {
                clothesOrder.Push(cloth);
            }

            int clothesSum = 0;
            int racksCount = 1;

            while (clothesOrder.Count > 0)
            {
                if (clothesSum + clothesOrder.Peek() < eachRackCapacity)
                {
                    clothesSum += clothesOrder.Pop();
                                
                }
                else if (clothesSum + clothesOrder.Peek() == eachRackCapacity)
                {
                    clothesSum = 0;
                    clothesOrder.Pop();

                    if (clothesOrder.Count > 0)
                    {
                        racksCount++;
                    }
                    
                }
                else if (clothesSum + clothesOrder.Peek() > eachRackCapacity)
                {
                    clothesSum = clothesOrder.Pop();
                    racksCount++;
                }
            }

            Console.WriteLine(racksCount);
        }
    }
}
