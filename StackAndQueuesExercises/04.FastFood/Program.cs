using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalQuanity = double.Parse(Console.ReadLine());
            List<double> ordersQuanity = Console.ReadLine().Split().Select(double.Parse).ToList();
            Queue<double> orders = new Queue<double>();

            foreach (var order in ordersQuanity)
            {
                orders.Enqueue(order);
            }

            Console.WriteLine(orders.Max());

            while (totalQuanity > 0 && orders.Count > 0)
            {
                if (totalQuanity >= orders.Peek())
                {
                    totalQuanity -= orders.Dequeue();
                }
                else
                {
                    break;
                }    
            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write($"Orders left: ");
                Console.WriteLine(string.Join(" " , orders));
            }
        }
    }
}
