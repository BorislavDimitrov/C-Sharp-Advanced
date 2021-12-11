using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheVlogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<List<string>>> vloggers = new Dictionary<string, List<List<string>>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Statistics")
                {
                    break;
                }

                List<string> commandInput = input.Split().ToList();
                string command = commandInput[1];

                if (command == "joined")
                {
                    string vloggerName = commandInput[0];
                    if (!vloggers.ContainsKey(vloggerName))
                    {
                        vloggers.Add(vloggerName , new List<List<string>>());
                        vloggers[vloggerName].Add(new List<string>());
                        vloggers[vloggerName].Add(new List<string>());
                    }
                }
                else if (command == "followed")
                {
                    string firstVloggerName = commandInput[0];
                    string secondVloggerName = commandInput[2];

                    if (vloggers.ContainsKey(firstVloggerName) && vloggers.ContainsKey(secondVloggerName))
                    {
                        if (firstVloggerName != secondVloggerName)
                        {
                            if (!vloggers[secondVloggerName][0].Contains(firstVloggerName))
                            {
                                vloggers[firstVloggerName][1].Add(secondVloggerName);
                                vloggers[secondVloggerName][0].Add(firstVloggerName);
                            }
                        }
                    }
                }            
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            vloggers = vloggers.OrderByDescending(x => x.Value[0].Count).ThenBy(x => x.Value[1].Count).ToDictionary(x => x.Key, y => y.Value);
            int vloggersNum = 1;

            foreach (var vlogger in vloggers)
            {
                if (vloggersNum == 1)
                {
                    Console.WriteLine($"{vloggersNum}. {vlogger.Key} : {vlogger.Value[0].Count} followers, {vlogger.Value[1].Count} following");
                    vlogger.Value[0] = vlogger.Value[0].OrderBy(x => x).ToList();

                    foreach (var follower in vlogger.Value[0])
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                else
                {
                    Console.WriteLine($"{vloggersNum}. {vlogger.Key} : {vlogger.Value[0].Count} followers, {vlogger.Value[1].Count} following");
                }
                vloggersNum++;
            }
        }
    }
}
