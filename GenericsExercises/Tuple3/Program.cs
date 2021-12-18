using System;
using System.Collections.Generic;
using System.Linq;

namespace Tuple3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Threeuple<string, string, string> personTown = new Threeuple<string, string, string>();
            List<string> adresInfo = Console.ReadLine().Split().ToList();
            string name = adresInfo[0] + " " + adresInfo[1];
            string town = adresInfo[3];

            if (adresInfo.Count == 5)
            {
                 town = adresInfo[3] + " " + adresInfo[4];
            }
            
            personTown.FrstItem = name;
            personTown.SecondItem = adresInfo[2];
            personTown.ThirdItem = town;

            Threeuple<string, int, string> drunk = new Threeuple<string, int, string>();
            List<string> drink = Console.ReadLine().Split().ToList();
            bool isDrunk = drink[2] == "drunk";
            drunk.FrstItem = drink[0];
            drunk.SecondItem = int.Parse(drink[1]);
            drunk.ThirdItem = $"{isDrunk}";
            

            Threeuple<string, double, string> bank = new Threeuple<string, double, string>();
            List<string> account = Console.ReadLine().Split().ToList();
            bank.FrstItem = account[0];
            bank.SecondItem = double.Parse(account[1]);
            bank.ThirdItem = account[2];

            Console.WriteLine(personTown.FrstItem + " -> " + personTown.SecondItem + " -> " + personTown.ThirdItem);
            Console.WriteLine(drunk.FrstItem + " -> " + drunk.SecondItem + " -> " + drunk.ThirdItem);
            Console.WriteLine(bank.FrstItem + " -> " + bank.SecondItem + " -> " + bank.ThirdItem);
        }
    }
}
