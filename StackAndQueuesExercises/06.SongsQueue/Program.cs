using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> songsInput = Console.ReadLine().Split(", ").ToList();
            Queue<string> songs = new Queue<string>();

            foreach (var song in songsInput)
            {
                songs.Enqueue(song);
            }

            while (songs.Count > 0)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if (command[0] == "Play")
                {
                    songs.Dequeue();
                }
                else if (command[0] == "Add")
                {
                    string name = string.Empty;

                    for (int i = 1; i < command.Count; i++)
                    {
                        if (i == command.Count - 1)
                        {
                            name += command[i];
                        }
                        else
                        {
                            name += command[i] + " ";
                        }
                    }

                    if (!songs.Contains(name))
                    {
                        songs.Enqueue(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already contained!");
                    }
                }
                else if (command[0] == "Show")
                {
                    Console.WriteLine(string.Join(", " , songs));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
