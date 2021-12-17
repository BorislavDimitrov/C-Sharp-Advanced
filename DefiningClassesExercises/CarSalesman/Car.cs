using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public Car(string model , Engine engine)
        {
            Model = model;
            Engine = engine;
            Weight = 0;
            Color = "no have";
        }

        public Car(string model , Engine engine , int weight)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = "no have";
        }

        public Car(string model , Engine engine , string color)
        {
            Model = model;
            Engine = engine;
            Color = color;
            Weight = 0;
        }

        public Car(string model , Engine engine , int weight , string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public void PrintCar ()
        {
            Console.WriteLine($"{Model}:");
            Engine.PrintEngine();
            if (Weight == 0)
            {
                Console.WriteLine($"\tWeight: n/a");
            }
            else
            {
                Console.WriteLine($"\tWeight: {Weight}");
            }

            if (Color == "no have")
            {
                Console.WriteLine($"\tColor: n/a");
            }
            else
            {
                Console.WriteLine($"\tColor: {Color}");
            }
        }
    }
}
