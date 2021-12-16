using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Party!")
                {
                    break;
                }

                List<string> command = input.Split().ToList();
                Predicate<string> predicate = new Predicate<string>(x => x.Length == 1);

                if (command[1] == "StartsWith")
                {
                    predicate = x => x.StartsWith(command[2]);
                }
                else if (command[1] == "EndsWith")
                {
                    predicate = x => x.EndsWith(command[2]);
                }
                else if (command[1] == "Length")
                {
                    predicate = x => x.Length == int.Parse(command[2]);
                }

                if (command[0] == "Double")
                {
                    int namesAdded = 0;
                    List<string> temp = names.ToList();
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (predicate(names[i]))
                        {
                            temp.Insert(i + namesAdded , names[i]);
                            namesAdded++;
                        }
                    }
                    names = temp.ToList();
                }
                else if (command[0] == "Remove")
                {
                    List<string> temp = new List<string>();
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (!predicate(names[i]))
                        {
                            temp.Add(names[i]);
                        }
                    }
                    names = temp.ToList();
                }
            }

            if (names.Count > 0)
            {
                Console.Write(string.Join(", " , names));
                Console.WriteLine(" are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }   
    }
}
