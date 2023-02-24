namespace PokemonTrainer
{
    class StartUp
    {
        static void Main()
        {
            List<Trainer> trainers = new List<Trainer>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Tournament")
                {
                    break;
                }

                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                double pokemonHealth = double.Parse(tokens[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                var neededTrainer = trainers.FirstOrDefault(t => t.Name == trainerName);
                if (neededTrainer != null)
                {
                    neededTrainer.Pokemons.Add(pokemon);
                }
                else
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                if (input == "Fire" || input == "Water" || input == "Electricity")
                {
                    foreach (var trainer in trainers)
                    {
                        if (trainer.Pokemons.Any(p => p.Element == input))
                        {
                            trainer.NumberOfBadges++;
                        }
                        else
                        {
                            foreach(var pokemon in trainer.Pokemons)
                            {
                                pokemon.Health -= 10;
                            }
                        }
                        trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                    }
                }
            }

            foreach(var trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
