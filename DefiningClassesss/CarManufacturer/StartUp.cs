using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "No more tires")
                {
                    break;
                }

                List<string> tireInfo = input.Split().ToList();
                Tire[] currTires = new Tire[]
                {
                    new Tire(int.Parse(tireInfo[0]) , double.Parse(tireInfo[1])) ,
                    new Tire(int.Parse(tireInfo[2]) , double.Parse(tireInfo[3])) ,
                    new Tire(int.Parse(tireInfo[4]) , double.Parse(tireInfo[5])) ,
                    new Tire(int.Parse(tireInfo[6]) , double.Parse(tireInfo[7]))
                };
                tires.Add(currTires);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Engines done")
                {
                    break;
                }
                List<string> engineInfo = input.Split().ToList();
                Engine newEngine = new Engine(int.Parse(engineInfo[0]) , double.Parse(engineInfo[1]));
                engines.Add(newEngine);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Show special")
                {
                    break;
                }
                List<string> carInfo = input.Split().ToList();

                Car newCar = new Car(carInfo[0] , carInfo[1] , int.Parse(carInfo[2])
                    ,double.Parse(carInfo[3]) , double.Parse(carInfo[4]) , engines[int.Parse(carInfo[5])] , tires[int.Parse(carInfo[6])] );
                cars.Add(newCar);
            }

            List<Car> filteredCars = new List<Car>();

            foreach (var car in cars)
            {
                double tiresSum = 0;

                foreach (var tire in car.Tires)
                {
                    tiresSum += tire.Pressure;
                }

                
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && tiresSum >= 9 && tiresSum <= 10)
                {
                    filteredCars.Add(car);
                }
            }

            foreach (var car in filteredCars)
            {
                car.Drive(20);
                Console.WriteLine(car.WhoAmI());
            }

            
        }
    }
}
