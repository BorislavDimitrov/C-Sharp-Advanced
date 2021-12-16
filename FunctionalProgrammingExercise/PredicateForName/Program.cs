using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateForName
{
    class Program
    {
        static void Main(string[] args)
        {
            int stringLenght = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();
            Predicate<string> filterByLenght = x => x.Length <= stringLenght;

            foreach (var name in names)
            {
                if (filterByLenght(name))
                {
                    Console.WriteLine(name);
                }
            }

        }
    }
}
