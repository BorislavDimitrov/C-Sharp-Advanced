using System;
using System.Collections.Generic;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();
            Func<string, int, bool> predicate = (x, y) => x.ToCharArray().Select(x => (int)x).Sum() >= y;
            Console.WriteLine(GetName(names, number, predicate));

        }

        static string GetName (List<string> names , int num , Func<string , int , bool> delegatee)
        {
            string resultName = string.Empty;
            foreach (var name in names)
            {
                if (delegatee(name , num))
                {
                    resultName = name;
                    break;
                }
            }
            return resultName;
        }
    }
}
