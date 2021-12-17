using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    class Car
    {
        public string Model { get; set; }
        public decimal FuelAmount { get; set; }
        public decimal FuelConsumptionPerKilometer { get; set; }
        public decimal TravelDistance { get; set; }

        public Car()
        {
            TravelDistance = 0;
        }

        public Car(string model, decimal fuelAmount, decimal fuelConsumptioPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptioPerKilometer;
        }

        public void Drive(decimal distance)
        {
            decimal result = distance * FuelConsumptionPerKilometer;
            if (FuelAmount >= result)
            {
                FuelAmount -= result;
                TravelDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
