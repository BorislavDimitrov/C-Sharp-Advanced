using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());
            Dictionary<string, int> nameAge = new Dictionary<string, int>();

            for (int i = 0; i < inputLines; i++)
            {
                List<string> perosnInfo = Console.ReadLine().Split(", ").ToList();
                nameAge.Add(perosnInfo[0] , int.Parse(perosnInfo[1]));
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Dictionary<string, int> peopleFiltered = new Dictionary<string, int>();

            if (condition == "younger")
            {
                peopleFiltered = nameAge.Where(x => age > x.Value).ToDictionary(x => x.Key , y => y.Value);
            }
            else
            {
                peopleFiltered = nameAge.Where(x => age <= x.Value).ToDictionary(x => x.Key, y => y.Value);
            }

            if (format == "name")
            {
                foreach (var person in peopleFiltered)
                {
                    Console.WriteLine(person.Key);
                }
            }
            else if (format == "age")
            {
                foreach (var person in peopleFiltered)
                {
                    Console.WriteLine(person.Value);
                }
            }
            else
            {
                foreach (var person in peopleFiltered)
                {
                    Console.WriteLine($"{person.Key} - {person.Value}");
                }
            }
        }
    }
}
