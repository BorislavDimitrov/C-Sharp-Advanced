using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            Dictionary<string, Predicate<string>> predicates = new Dictionary<string, Predicate<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Print")
                {
                    break;
                }
                List<string> command = input.Split(";").ToList();
                Predicate<string> predicate = x => x.Length == 1;
                string predicateKey = command[1] + "" + command[2];

                if (command[1] == "Starts with")
                {
                    predicate = x => x.StartsWith(command[2]);
                }
                else if (command[1] == "Ends with")
                {
                    predicate = x => x.EndsWith(command[2]);
                }
                else if (command[1] == "Length")
                {
                    predicate = x => x.Length == int.Parse(command[2]);
                }
                else if (command[1] == "Contains")
                {
                    predicate = x => x.Contains(command[2]);
                }

                if (command[0] == "Add filter")
                {
                    predicates.Add(predicateKey , predicate);
                }
                else if (command[0] == "Remove filter")
                {
                    predicates.Remove(predicateKey);
                }
            }
            List<string> filteredNames = new List<string>();

            for (int i = 0; i < names.Count; i++)
            {
                bool isFiltered = true;
                foreach (var predicate in predicates)
                {
                    if (predicate.Value(names[i]))
                    {
                        isFiltered = false;
                    }
                }

                if (isFiltered)
                {
                    filteredNames.Add(names[i]);
                }
            }
            Console.WriteLine(string.Join(" " , filteredNames));
        }
    }
}
