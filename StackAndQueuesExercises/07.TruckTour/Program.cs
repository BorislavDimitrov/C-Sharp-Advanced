using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPetrolPoints = int.Parse(Console.ReadLine());
            Queue<Point> originalQueuePoints = new Queue<Point>();

            for (int i = 0; i < numberOfPetrolPoints; i++)
            {
                List<int> pointInfo = Console.ReadLine().Split().Select(int.Parse).ToList();
                Point newPoint = new Point(i , pointInfo[0] , pointInfo[1]);
                originalQueuePoints.Enqueue(newPoint);
            }

            int startingPoint = 0;

            while (true)
            {
                bool isDone = false;
                startingPoint = originalQueuePoints.Peek().Position;
                 int fuelInTank = 0;
                List<Point> transferElements = originalQueuePoints.ToList();
                Queue<Point> queueForSimulation = new Queue<Point>(transferElements);

                while (true)
                {
                    Point currPoint = queueForSimulation.Dequeue();
                    fuelInTank += currPoint.Fuel;

                    if (queueForSimulation.Count == 0)
                    {
                        isDone = true;
                        break;
                    }

                    if (!(fuelInTank >= currPoint.DistanceToNextPoint))
                    {
                        break;
                    }
                    else
                    {
                        fuelInTank -= currPoint.DistanceToNextPoint;
                    }
                }

                if (isDone)
                {
                    break;
                }

                Point temp = originalQueuePoints.Dequeue();
                originalQueuePoints.Enqueue(temp);
            }

            Console.WriteLine(startingPoint);
        }
    }
  }


