using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> colors = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < inputLines; i++)
            {
                List<string> clothesInput = Console.ReadLine().Split(" -> ").ToList();
                List<string> items = clothesInput[1].Split(",").ToList();
                string color = clothesInput[0];

                if (colors.ContainsKey(color))
                {
                    for (int j = 0; j < items.Count; j++)
                    {
                        if (colors[color].ContainsKey(items[j]))
                        {
                            colors[color][items[j]]++;
                        }
                        else
                        {
                            colors[color].Add(items[j], 1);
                        }
                    }
                }
                else
                {
                    colors.Add(color , new Dictionary<string, int>());

                    for (int j = 0; j < items.Count; j++)
                    {
                        if (colors[color].ContainsKey(items[j]))
                        {
                            colors[color][items[j]]++;
                        }
                        else
                        {
                            colors[color].Add(items[j] , 1);
                        }
                    }
                }
            }

            List<string> itemSearched = Console.ReadLine().Split().ToList();

            foreach (var color in colors)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var item in color.Value)
                {
                    if (color.Key == itemSearched[0] && item.Key == itemSearched[1])
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
