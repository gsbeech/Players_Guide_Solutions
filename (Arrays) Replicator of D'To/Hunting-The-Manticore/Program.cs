using System;

namespace Hunting_The_Manticore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup
            Console.Title = "Hunting the Manticore";
            Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
            int cityHealth = 15;
            int manticoreHealth = 10;
            int round = 1;
            string result = "";
            int roundDamage = 0;
            int manticoreDistance = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Player 2, it is your turn.");

            // Game Loop
            while (cityHealth >= 0 && manticoreHealth >= 0)
            {
                Console.WriteLine("---------------------------------");
                WriteStatus(round, cityHealth, manticoreHealth);

                if ((IsMultipleOfNumber(round, 3)) && IsMultipleOfNumber(round, 5))
                {
                    roundDamage = 10;
                }
                else if ((IsMultipleOfNumber(round, 3)) ^ IsMultipleOfNumber(round, 5))
                {
                    roundDamage = 3;
                }
                else
                {
                    roundDamage = 1;
                }

                Console.WriteLine($"This round, the cannon is expected to do {roundDamage} damage.");

                Console.Write("Enter desired cannon range: ");
                int roundGuess = Convert.ToInt32(Console.ReadLine());

                if (IsDirectHit(manticoreDistance, roundGuess))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That round was a DIRECT HIT!");
                    Console.ForegroundColor = ConsoleColor.White;
                    manticoreHealth -= roundDamage;
                }
                else if (IsOvershot(manticoreDistance, roundGuess))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("That round OVERSHOT the target!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (IsUndershot(manticoreDistance, roundGuess))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("That round UNDERSHOT the target!");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                //End of round prepare for next round
                cityHealth--;
                round++;
            }
            if (cityHealth <= 0)
            {
                Console.WriteLine("The city has been destroyed!");
            }
            else
            {
                Console.WriteLine("The Manticore has been destroyed!");
            }
            /* user 1 defines the distance of the manticore from the city (0-100)
             player 2 has a series of attempts to guess the distance, if distance is too far, say "That round OVERSHOT the target"
            if distance is too short, say "That round FELL SHORT of the target"
            if it's correct, say "That round was a DIRECT HIT!"
            the manticore starts with 10hp and the city starts with 15 hp
            if the direct hit is on a turn that is a multiple of 3, the shot does 3 damage
            if the direct hit is on a turn that is a multiple of 5, the shot deals 3 damage
            if the direct hit is on a turn that is a multiple or 3 and 5, the shot deals 10 damage
            each turn, the manticore deals 1 damage to the city
            each round, the user should see the current status, the current round number, the hp of the city and hp of the manticore */
            static bool IsMultipleOfNumber(int input, int denominator) => input % denominator == 0;
            static bool IsDirectHit(int manticoreDistance, int userGuess) => manticoreDistance == userGuess;
            static bool IsOvershot(int manticoreDistance, int userGuess) => manticoreDistance < userGuess;
            static bool IsUndershot(int manticoreDistance, int userGuess) => manticoreDistance > userGuess;
            static void WriteStatus(int roundNumber, int cityHealth, int manticoreHealth)
            {
                Console.WriteLine($"STATUS: Round {roundNumber}  City: {cityHealth}/15  Manticore: {manticoreHealth}/10");
            }
        }
    }
}
