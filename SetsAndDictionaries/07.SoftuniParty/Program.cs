using System;
using System.Collections.Generic;

namespace _07.SoftuniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> normalGuests = new HashSet<string>();
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> cameNormalGuests = new HashSet<string>();
            HashSet<string> cameVipGuests = new HashSet<string>();

            while (true)
            {
                string currentGuestInput = Console.ReadLine();
                bool isOver = false;
              
                if(currentGuestInput =="PARTY")
                {
                    while (true)
                    {
                        string cameGuest = Console.ReadLine();

                        if (cameGuest == "END")
                        {
                            isOver = true;
                            break;
                        }

                        if (char.IsDigit(cameGuest[0]))
                        {
                            if (vipGuests.Contains(cameGuest))
                            {
                                vipGuests.Remove(cameGuest);
                                cameVipGuests.Add(cameGuest);
                            }
                        }
                        else
                        {
                            if (normalGuests.Contains(cameGuest))
                            {
                                normalGuests.Remove(cameGuest);
                                cameNormalGuests.Add(cameGuest);
                            }
                        }
                    }

                }

                if (isOver)
                {
                    break;
                }
                if (char.IsDigit(currentGuestInput[0]) )
                {
                    vipGuests.Add(currentGuestInput);
                }
                else
                {
                    normalGuests.Add(currentGuestInput);
                }
            }

            Console.WriteLine(normalGuests.Count + vipGuests.Count);

            if (vipGuests.Count > 0)
            {
                Console.WriteLine(string.Join("\n", vipGuests));
            }

            if (normalGuests.Count > 0)
            {
                Console.WriteLine(string.Join("\n", normalGuests));
            }

        }
    }
}
