using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
    

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        public Car()
        {

        }

        public Car(string make , string model , int year):this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make , string model , int year , double fuelQuantity , double fuelConsumption):this(make , model , year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make , string model , int year ,double fuelQuantity , double fuelConsumption , Engine engine , Tire [] tires)
            : this(make , model , year , fuelQuantity , fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        public void Drive(double distance)
        {
            double result = FuelQuantity - ((distance  / 100) * FuelConsumption);
            if (result > 0)
            {
                FuelQuantity = result;
            }
            else
            {
                FuelQuantity = 0;
            }
        }

        public string WhoAmI()
        {
            string result = string.Empty;
            result += $"Make: {Make}\n";
            result += $"Model: {Model}\n";
            result += $"Year: {Year}\n";
            result += $"HorsePowers: {Engine.HorsePower}\n";
            result += $"FuelQuantity: {FuelQuantity}";
            return result;
        }
    }
}
