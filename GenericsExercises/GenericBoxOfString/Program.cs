using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBoxOfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Box<double>> strings = new List<Box<double>>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                Box<double> newBox = new Box<double>(double.Parse(input));
                strings.Add(newBox);
            }
            string elementToComapre = Console.ReadLine();

            Console.WriteLine(GetBiggerElementsCount(strings , double.Parse(elementToComapre)));


        }

        static int GetBiggerElementsCount<T>(List<Box<T>> elements, T element) where T : IComparable
        {
            int counter = 0;
            foreach (var elementt in elements)
            {
                if (elementt.Compare<T>(element))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
