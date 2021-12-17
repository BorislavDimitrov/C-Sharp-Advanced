using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonTrainer
{
    class Trainer
    {
        private int numberOfBadges = 0;
        private List<Pokemon> pokemons = new List<Pokemon>();
        public string Name { get; set; }
        public int NumberOfBadges { get => numberOfBadges; set => numberOfBadges = value; }
        public List<Pokemon> Pokemons { get => pokemons; set => pokemons = value; }

        public Trainer(string name , string pokemonName , string pokemonElement , int pokemonHealth)
        {
            Name = name;
            Pokemon newPokemon = new Pokemon(pokemonName , pokemonElement , pokemonHealth);
            Pokemons.Add(newPokemon);
        }

        public void PokemonsTakeDamage ()
        {
            foreach (var pokemon in Pokemons)
            {
                pokemon.PokemonLosesHealth();
            }

            Pokemons = Pokemons.Where(x => x.Health > 0).ToList();
        }
    }
}
