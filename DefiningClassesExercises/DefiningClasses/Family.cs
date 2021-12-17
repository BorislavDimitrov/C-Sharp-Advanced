using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people = new List<Person>();

        public List<Person> People { get => people; set => people = value; }
        public void AddMemeber (Person newPerson)
        {
            people.Add(newPerson);
        }

         public  Person GetOldestMember ()
        {
            Person oldestMember = new Person(int.MinValue);

            foreach (var member in people)
            {
                if (member.Age > oldestMember.Age)
                {
                    oldestMember = member;
                }
            }
            return oldestMember;
        }
    }
}
