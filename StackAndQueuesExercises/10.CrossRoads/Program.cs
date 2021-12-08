using System;
using System.Collections.Generic;

namespace _10.CrossRoads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDurationSeconds = int.Parse(Console.ReadLine());
            int freeWindowDurationSeconds = int.Parse(Console.ReadLine());
            Queue<string> carsWaiting = new Queue<string>();
            int passedCars = 0;

            while (true)
            {
                string input = Console.ReadLine();
                int currentGreenLightDurationSeconds = greenLightDurationSeconds;
                int currentWindowDuration = freeWindowDurationSeconds;

                if (input == "END")
                {
                    break;
                }

                else if (input == "green")
                {
                    if (carsWaiting.Count > 0)
                    {
                        while (currentGreenLightDurationSeconds > 0)
                        {
                            string currentCar = carsWaiting.Dequeue();
                            string currCarToPrint = currentCar;
                            int currCarLenght = currentCar.Length;

                            for (int i = 0; i < currCarLenght; i++)
                            {
                                if (currentGreenLightDurationSeconds > 0)
                                {
                                    currentGreenLightDurationSeconds -= 1;
                                    currentCar =  currentCar.Remove(0, 1);
                                }
                                else if (currentWindowDuration > 0)
                                {
                                    currentWindowDuration -= 1;
                                    currentCar =  currentCar.Remove(0,1);

                                    if (currentWindowDuration == 0 && currentCar.Length > 0)
                                    {
                                        Console.WriteLine("A crash happened!");
                                        Console.WriteLine($"{currCarToPrint} was hit at {currentCar[0]}.");
                                        return;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("A crash happened!");
                                    Console.WriteLine($"{currCarToPrint} was hit at {currentCar[0]}.");
                                    return;
                                }
                            }

                            passedCars++;

                            if (carsWaiting.Count == 0)
                            {
                                break;
                            }
                        }
                    }
                }
                else
                {
                    carsWaiting.Enqueue(input);
                }
            }
            Console.WriteLine($"Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }
    }
}
