using System;
using System.Collections.Generic;
using System.Linq;

namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> prices = Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .Select(x => x += (x * 20) / 100)
                .ToList();

            foreach (var price in prices)
            {
                Console.WriteLine($"{price:F2}");
            }
        }
    }
}
