using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CitiesByContinentAndCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < inputLines; i++)
            {
                List<string> cityInfo = Console.ReadLine().Split().ToList();
                string continent = cityInfo[0];
                string country = cityInfo[1];
                string city = cityInfo[2];

                if (continents.ContainsKey(continent))
                {
                    if (continents[continent].ContainsKey(country))
                    {
                        continents[continent][country].Add(city);
                    }
                    else
                    {
                        continents[continent].Add(country, new List<string>());
                        continents[continent][country].Add(city);
                    }
                    
                }
                else
                {
                    continents.Add(continent ,  new Dictionary<string , List<string>>());
                    continents[continent].Add(country , new List<string>());
                    continents[continent][country].Add(city);
                }
            }

            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", " , country.Value)}");
                }
            }
        }
    }
}
