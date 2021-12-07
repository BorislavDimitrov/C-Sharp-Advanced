using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kidsNames = Console.ReadLine().Split().ToList();
            int n = int.Parse(Console.ReadLine());
            Queue<string> names = new Queue<string>();

            int timesCounter = 0;
            int kidNumber = 0;

            while (kidsNames.Count > 1)
            {
                if (kidNumber == kidsNames.Count)
                {
                    kidNumber = 0;
                }
 
                timesCounter++;

                if (timesCounter == n)
                {
                    Console.WriteLine("Removed " + kidsNames[kidNumber]);
                    kidsNames.RemoveAt(kidNumber);
                    kidNumber--;
                    timesCounter = 0;
                }

                kidNumber++;
            }
            Console.WriteLine("Last is " + kidsNames[0]);
        }
    }
}
