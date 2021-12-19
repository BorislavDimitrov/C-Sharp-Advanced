using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EqualityLogic
{
    class Person : IComparable<Person> 
    {
        public string Name { get;}
        public int Age { get;}

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override bool Equals(object obj)
        {
            Person y = obj as Person;
            if (y == null)
            {
                return false;
            }
            return this.Name == y.Name && this.Age == y.Age;
        }

        public override int GetHashCode()
        {
            var code = 1;
            var up = 1;
            foreach (var charr in Name)
            {
                code += (int)charr * up;
                up++;
            }
            code += Age;
            return code;
        }

        public int CompareTo([AllowNull] Person other)
        {
            int result = Name.CompareTo(other.Name);
            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age);             
            }
            return result;
        }

        
    }
}
