using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _08.TraficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCarsWhoCanPass = int.Parse(Console.ReadLine());
            Queue<string> linearCars = new Queue<string>();

            string input = string.Empty;
            int passedCarsCounter = 0;

            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < numberOfCarsWhoCanPass; i++)
                    {
                        if (linearCars.Count > 0)
                        {
                            Console.WriteLine(linearCars.Dequeue() + " passed!");
                            passedCarsCounter++;
                        }

                    }
                }
                else
                {
                    linearCars.Enqueue(input);
                }
            }

            Console.WriteLine($"{passedCarsCounter} cars passed the crossroads.");
        }
    }
}
