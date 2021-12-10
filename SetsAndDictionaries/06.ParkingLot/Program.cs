using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carPlates = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                List<string> carInfo = input.Split(", ").ToList();

                if (carInfo[0] == "IN")
                {
                    carPlates.Add(carInfo[1]);
                }
                else
                {
                    carPlates.Remove(carInfo[1]);
                }
            }

            if (carPlates.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                Console.WriteLine(string.Join("\n" , carPlates));
            }
        }
    }
}
