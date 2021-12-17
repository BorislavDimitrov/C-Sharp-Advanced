using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Tournament")
                {
                    break;
                }

                List<string> info = input.Split(" " , StringSplitOptions.RemoveEmptyEntries).ToList();
                bool trainerExist = false;

                foreach (var trainer in trainers)
                {
                    if (info[0] == trainer.Name)
                    {
                        Pokemon newPokemon = new Pokemon(info[1] , info[2] , int.Parse(info[3]));
                        trainer.Pokemons.Add(newPokemon);
                        trainerExist = true;
                    }
                }

                if (!trainerExist)
                {
                    Trainer newTrainer = new Trainer(info[0] , info[1], info[2] , int.Parse(info[3]));
                    trainers.Add(newTrainer);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                if (input == "Fire")
                {
                    foreach (var trainer in trainers)
                    {
                        bool elementExist = false;
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            if (pokemon.Element == "Fire")
                            {
                                elementExist = true;
                                trainer.NumberOfBadges++;
                                break;
                            }
                        }

                        if (!elementExist)
                        {
                            trainer.PokemonsTakeDamage();
                        }
                    }
                }
                else if (input == "Water")
                {
                    foreach (var trainer in trainers)
                    {
                        bool elementExist = false;
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            if (pokemon.Element == "Water")
                            {
                                elementExist = true;
                                trainer.NumberOfBadges++;
                                break;
                            }
                        }

                        if (!elementExist)
                        {
                            trainer.PokemonsTakeDamage();
                        }
                    }
                }
                else if (input == "Electricity")
                {
                    foreach (var trainer in trainers)
                    {
                        bool elementExist = false;
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            if (pokemon.Element == "Electricity")
                            {
                                elementExist = true;
                                trainer.NumberOfBadges++;
                                break;
                            }
                        }

                        if (!elementExist)
                        {
                            trainer.PokemonsTakeDamage();
                        }
                    }
                }
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
