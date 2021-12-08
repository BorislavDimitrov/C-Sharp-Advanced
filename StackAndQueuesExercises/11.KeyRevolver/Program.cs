using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int eachBulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            List<int> bulletsList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> locksList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int intelligence = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(bulletsList);
            Queue<int> locks = new Queue<int>(locksList);

            int currentBulletsInBarrel = gunBarrelSize;

            while (true)
            {
                int currentBullet = bullets.Pop();
                int currentLock = locks.Peek();
                intelligence -= eachBulletPrice;
                currentBulletsInBarrel -= 1;

                if (currentBullet <= currentLock)
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (currentBulletsInBarrel == 0)
                {
                    if (bullets.Count >= gunBarrelSize)
                    {
                        currentBulletsInBarrel = gunBarrelSize;
                        Console.WriteLine("Reloading!");
                    }
                    else if (bullets.Count > 0)
                    {
                        currentBulletsInBarrel += bullets.Count;
                        Console.WriteLine("Reloading!");
                    }
                }


                if (locks.Count == 0)
                {
                    Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligence}");
                    return;
                }

                if (bullets.Count == 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                    return;
                }
            }

        }
    }
}
