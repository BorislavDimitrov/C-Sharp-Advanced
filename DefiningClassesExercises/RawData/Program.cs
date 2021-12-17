using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < inputLines; i++)
            {
                List<string> carInfo = Console.ReadLine().Split().ToList();
                Engine currEngine = new Engine(int.Parse(carInfo[1]) , int.Parse(carInfo[2]));
                Cargo currCargo = new Cargo(int.Parse(carInfo[3]) , carInfo[4]);
                Tire[] currTires = new Tire[]
                {
                     new Tire( double.Parse(carInfo[5]) , int.Parse(carInfo[6])),
                     new Tire( double.Parse(carInfo[7]) , int.Parse(carInfo[8])),
                     new Tire( double.Parse(carInfo[9]) , int.Parse(carInfo[10])),
                     new Tire( double.Parse(carInfo[11]) , int.Parse(carInfo[12]))
                };
                Car currCar = new Car(carInfo[0] , currEngine , currCargo , currTires);
                cars.Add(currCar);
            }

            string cargoType = Console.ReadLine();
            List<Car> filteredCars = new List<Car>();

            if (cargoType == "fragile")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.Type == "fragile")
                    {
                        foreach (var tire in car.Tires)
                        {
                            if (tire.Pressure < 1)
                            {
                                filteredCars.Add(car);
                                break;
                            }
                        }
                    }
                }
            }
            else if (cargoType == "flammable")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.Type == "flammable" && car.Engine.Power > 250)
                    {
                        filteredCars.Add(car);
                    }
                }
            }

            foreach (var car in filteredCars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
