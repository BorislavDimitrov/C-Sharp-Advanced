using System;
using System.Collections.Generic;
using System.Text;

namespace _07.TruckTour
{
    class Point
    {
        private int position;
        private int fuel;
        private int distanceToNextPoint;

        public Point()
        {

        }

        public Point(int position , int fuel , int distanceToNextPoint)
        {
            this.position = position;
            this.fuel = fuel;
            this.distanceToNextPoint = distanceToNextPoint;
        }

        public int Position
        {
            get => position;
        }

        public int Fuel
        {
            get => fuel;
        }

        public int DistanceToNextPoint
        {
            get => distanceToNextPoint;
        }
    }
}
