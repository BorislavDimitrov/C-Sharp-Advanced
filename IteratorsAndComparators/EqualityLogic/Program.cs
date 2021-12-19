using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualityLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Person> people = new HashSet<Person>();
            SortedSet<Person> sortedPeople = new SortedSet<Person>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                List<string> personInfo = Console.ReadLine().Split().ToList();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                Person newPerson = new Person(name , age);
                people.Add(newPerson);
                sortedPeople.Add(newPerson);

            }
            Console.WriteLine(people.Count);
            Console.WriteLine(sortedPeople.Count);

        }
    }
}
