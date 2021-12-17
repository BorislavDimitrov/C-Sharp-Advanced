using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int personInputs = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();


            for (int i = 0; i < personInputs; i++)
            {
                List<string> personInfo = Console.ReadLine().Split().ToList();
                Person newPerson = new Person(personInfo[0] , int.Parse(personInfo[1]) );
                people.Add(newPerson);
            }

            List<Person> sortedPeople = people.Where(x => x.Age > 30).OrderBy( x => x.Name).ToList();

            foreach (var person in sortedPeople)
            {
                Console.WriteLine(person.Name + " - " + person.Age);
            }
        }
    }
}
