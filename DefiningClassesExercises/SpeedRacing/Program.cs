using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsNum = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsNum; i++)
            {
                List<string> carInfo = Console.ReadLine().Split().ToList();
                Car newCar = new Car(carInfo[0] , decimal.Parse(carInfo[1]) , decimal.Parse(carInfo[2]));
                cars.Add(newCar);
            }

            
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                List<string> command = input.Split().ToList();

                foreach (var car in cars)
                {
                    if (car.Model == $"{command[1]}")
                    {
                        car.Drive(decimal.Parse(command[2]));
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.Model + $" {car.FuelAmount:F2}" + $" {car.TravelDistance}");
            }
        }
    }
}
