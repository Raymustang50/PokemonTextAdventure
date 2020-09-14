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
                if (choice.ToLower() == "no")   //maybe I need to change this to if while?? //how to git?
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
                                Console.WriteLine(/*info about pokeomon, then is this the one you want?*/);
                                var accept1 = Console.ReadLine();
                                if (accept1.ToLower() == "yes")
                                {
                                    Console.WriteLine("COngratulations");
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
