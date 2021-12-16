using System;
using System.Collections.Generic;
using System.Linq;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> knights = Console.ReadLine().Split().ToList();
            Action<string> printKnightWithSir = x => Console.WriteLine("Sir " + x);
            foreach (var knight in knights)
            {
                printKnightWithSir(knight);
            }


        }
    }
}