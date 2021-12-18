using System;
using System.Collections.Generic;
using System.Linq;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<string, string> nameAddres = new Tuple<string, string>();
            List<string> personInfo = Console.ReadLine().Split().ToList();
            string name = personInfo[0] + " " + personInfo[1];
            nameAddres.firstItem = name;
            nameAddres.secondItem = personInfo[2];

            Tuple<string, int> nameBeer = new Tuple<string, int>();
            List<string> beerInfo = Console.ReadLine().Split().ToList();
            nameBeer.firstItem = beerInfo[0];
            nameBeer.secondItem = int.Parse(beerInfo[1]);

            Tuple<int, double> intDouble = new Tuple<int, double>();
            List<string> nums = Console.ReadLine().Split().ToList();
            intDouble.firstItem = int.Parse(nums[0]);
            intDouble.secondItem = double.Parse(nums[1]);

            Console.WriteLine(nameAddres.firstItem + " -> " + nameAddres.secondItem);
            Console.WriteLine(nameBeer.firstItem + " -> " + nameBeer.secondItem);
            Console.WriteLine(intDouble.firstItem + " -> " + intDouble.secondItem);
        }
    }
}
