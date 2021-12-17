using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    class Tire
    {
        public int Year { get; set; }
        public double Pressure { get; set; }

        public Tire( double pressure , int year)
        {
            Year = year;
            Pressure = pressure;
        }
    }
}
