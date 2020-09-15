using System;

namespace PokemonTextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey There! What is your name?");
            var username = Console.ReadLine();
            Console.WriteLine($"Nice to meet you {username}! I’m Trainer Alexander! I see you don’t have any Pokemon? Would you like to become a Pokemon trainer? Yes or no?");
            var choice = Console.ReadLine();
            while (true)
            {
                if (choice.ToLower() == "no")   
                {
                    Console.WriteLine($"I'm really sorry to hear that {username}, I hope you have a great day.");
                    break;
                }
                else if (choice.ToLower() == "yes")
                {
                    Console.WriteLine($"That's Fantastic {username}!! I am retiring as a trainer, and I would like to give my last 3 Pokemon away to new young trainers." +
                        $"I have a Bulbasaur, a Charmander and a Squirtle. Which one would you like to learn about?");

                    while (true)
                    {
                        var pokemon = Console.ReadLine();
                        if (pokemon.ToLower() == "bulbasaur")
                        {
                            while (true)
                            {
                                Console.WriteLine("Bulbasaur is a grass type Pokemon, its weakness is fire and can learn razor leaf, vine whip, and poison powder. is this the " +
                                    "Pokemon you would like to make your new partner?");
                                var accept1 = Console.ReadLine();
                                if (accept1.ToLower() == "yes")
                                {
                                    Console.WriteLine("That's awesome!! I am sure you are excited for your new journey! " +
                                        "Good Luck!");
                                    break;
                                }
                                else
                                { 
                                    break;
                                }
                            }
                        }
                        else if (pokemon.ToLower() == "charmander")
                            while (true)
                            {
                                Console.WriteLine("Charmander is a fire type Pokemon, its weakness is water and can learn ember, slash, and flamethrower. is this the " +
                              "Pokemon you would like to make your new partner?");
                                var accept1 = Console.ReadLine();
                                if (accept1.ToLower() == "yes")
                                {
                                    Console.WriteLine("That's awesome!! I am sure you are excited for your new journey! " +
                                        "Good Luck!");
                                    break;
                                }
                                else
                                {
                                    break;
                                }

                            }
                        else if (pokemon.ToLower() == "squirtle")
                            while (true)
                            {
                                Console.WriteLine("Squirtle is a Water type Pokemon, its weakness is Electricity and can learn water gun, surf, and slam. is this the " +
                              "Pokemon you would like to make your new partner?");
                                var accept1 = Console.ReadLine();
                                if (accept1.ToLower() == "yes")
                                {
                                    Console.WriteLine("That's awesome!! I am sure you are excited for your new journey! " +
                                        "Good Luck!");
                                    break;
                                }
                                else
                                {
                                    break;
                                }  //I need to figure out how to connect if the player wants to checkout the other pokemon before a decision.

                            }
                    }
                  

                }
                else
                {
                    Console.WriteLine("I'm sorry, not sure I understand, could you please type yes or no?");
                }
            }
            
        }
    }
}
