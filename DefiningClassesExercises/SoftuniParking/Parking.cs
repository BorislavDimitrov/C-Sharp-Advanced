using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        private int count;
        private List<Car> cars = new List<Car>();
        public int Capacity { get; set; }
        public List<Car> Cars { get => cars; set => cars = value; }
        public int Count { get => count = Cars.Count; }

        public Parking(int capacity)
        {
            List<Car> cars = new List<Car>();
            Capacity = capacity;
        }

        public string AddCar(Car car)
        {
            foreach (var carr in Cars)
            {
                if (carr.RegistrationNumber == car.RegistrationNumber )
                {
                    return "Car with that registration number, already exists!";
                }
            }

            if (Cars.Count == Capacity)
            {
                return "Parking is full!";
            }

            Cars.Add(car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            
        }

        public string RemoveCar(string registrationNumber)
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                if (Cars[i].RegistrationNumber == registrationNumber)
                {
                    Cars.RemoveAt(i);
                    return  $"Successfully removed {registrationNumber}";
                }
            }

            return  "Car with that registration number, doesn't exist!";

        }

        public Car GetCar (string registrationNumber)
        {
            Car carGet = new Car();
            foreach (var car in Cars)
            {
                if (car.RegistrationNumber == registrationNumber)
                {
                    carGet = car;
                    break;
                }
            }
            return carGet;
        }

        public void RemoveSetOfRegistrationNumber (List<string> registrationNumbers)
        {
            foreach (var number in registrationNumbers)
            {
                for (int i = 0; i < Cars.Count; i++)
                {
                    if (Cars[i].RegistrationNumber == number)
                    {
                        Cars.RemoveAt(i);
                        break;
                    }
                }
            }
        }
    }
}
