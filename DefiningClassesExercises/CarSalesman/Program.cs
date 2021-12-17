using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int enginesLines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < enginesLines; i++)
            {
                List<string> engineInfo = Console.ReadLine().Split(" " , StringSplitOptions.RemoveEmptyEntries).ToList();

                if (engineInfo.Count == 2)
                {
                    Engine newEngine = new Engine(engineInfo[0] , int.Parse(engineInfo[1]));
                    engines.Add(newEngine);
                }
                else if (engineInfo.Count == 3)
                {
                    int displacement = '1';
                    bool isInt = int.TryParse(engineInfo[2] , out displacement);

                    if (!isInt)
                    {
                        Engine newEngine = new Engine(engineInfo[0] , int.Parse(engineInfo[1]) , engineInfo[2]);
                        engines.Add(newEngine);
                    }
                    else
                    {
                        Engine newEngine = new Engine(engineInfo[0] , int.Parse(engineInfo[1]) , int.Parse(engineInfo[2]));
                        engines.Add(newEngine);
                    }
                }
                else
                {
                    Engine newEngine = new Engine(engineInfo[0] , int.Parse(engineInfo[1]) , int.Parse(engineInfo[2]) , engineInfo[3]);
                    engines.Add(newEngine);
                }
            }

            int carsLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsLines; i++)
            {
                List<string> carInfo = Console.ReadLine().Split(" " , StringSplitOptions.RemoveEmptyEntries).ToList();
                Engine currEngine = new Engine();

                foreach (var engine in engines)
                {
                    if (engine.Model == carInfo[1])
                    {
                        currEngine = engine;
                    }
                }

                if (carInfo.Count == 2)
                {
                    Car newCar = new Car(carInfo[0] , currEngine);
                    cars.Add(newCar);
                }
                else if (carInfo.Count == 3)
                {
                    int displacement = 0;
                    bool isInt = int.TryParse(carInfo[2] , out displacement);

                    if (isInt)
                    {
                        Car newCar = new Car(carInfo[0] , currEngine , displacement);
                        cars.Add(newCar);
                    }
                    else
                    {
                        Car newCar = new Car(carInfo[0] , currEngine , carInfo[2]);
                        cars.Add(newCar);
                    }
                }
                else
                {
                    Car newCar = new Car(carInfo[0] , currEngine ,  int.Parse(carInfo[2]) , carInfo[3]);
                    cars.Add(newCar);
                }
            }

            foreach (var car in cars)
            {
                car.PrintCar();
            }
        }
    }
}
