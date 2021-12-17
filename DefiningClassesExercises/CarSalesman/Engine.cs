using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    class Engine
    {
        private int displacement = -1;
        private string efficiency = "0";

        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get => displacement; set => displacement = value; }
        public string Efficiency { get => efficiency; set => efficiency = value; }


        public Engine()
        {

        }
        public Engine(string model , int power)
        {
            Model = model;
            Power = power;
        }

        public Engine(string model , int power , int displacement):this(model , power)
        {
            Displacement = displacement;
        }

        public Engine(string model , int power , string efficiency):this(model , power)
        {
            Efficiency = efficiency;
        }

        public Engine(string model , int power , int displacement , string efficiency) :this(model , power)
        {
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public void PrintEngine ()
        {
            Console.WriteLine($"\t{Model}:");
            Console.WriteLine($"\t\tPower: {Power}");
            if (Displacement == -1)
            {
                Console.WriteLine($"\t\tDisplacement: n/a");
            }
            else
            {
                Console.WriteLine($"\t\tDisplacement: {Displacement}");
            }

            if (Efficiency == "0")
            {
                Console.WriteLine($"\t\tEfficiency: n/a");
            }
            else
            {
                Console.WriteLine($"\t\tEfficiency: {efficiency}");
            }
        }
    }
}
