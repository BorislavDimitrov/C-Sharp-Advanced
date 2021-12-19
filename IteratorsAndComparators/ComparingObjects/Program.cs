using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                List<string> personInfo = input.Split().ToList();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                string town = personInfo[2];

                Person newPerson = new Person(name , age , town);
                people.Add(newPerson);
            }

            int personToCompareNumber = int.Parse(Console.ReadLine()) - 1;
            Person comparePerson = people[personToCompareNumber];
            people.Remove(comparePerson);
            int matches = 0;
            int others = 0;

            foreach (var person in people)
            {
                if (comparePerson.CompareTo(person) == 0)
                {
                    matches++;
                }
                else
                {
                    others++;
                }
            }

            if (matches > 0)
            {
                Console.WriteLine($"{matches + 1} {others} {people.Count + 1}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
