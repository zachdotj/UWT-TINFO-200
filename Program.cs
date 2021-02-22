//////////////////////////////////////////////////////////////////////
// Date             Developer           Description
// 2021-02-04       zachj              --creation of the guess the number main class
// 2021-02-04       zachj              --final edits to ensure program is in completed state

using System;

namespace GuessTheNumber
{
    class Program
    {
        // this program plays the game "Guess The Number"
        // user must correctly guess the number to win
        // after winning, user can choose to play again if desired
        static void Main(string[] args)
        {
            // Welcome message and explanation of program
            Console.WriteLine($"**************************" +
                              $"\nWelcome to Guess The Number!" +
                              $"\nThe program has randomly generated a number between 1 and 1000." +
                              $"\nGuess the number to win!\n");

            // condition to start game
            bool contPlay = true;

            // main loop of the game
            while (contPlay == true)
            {
                // create secret number
                Console.WriteLine("Secret number has been selected.");
                Random rand = new Random();
                int secretNum = rand.Next(1, 999);

                // input section -- input guesses from user
                Console.WriteLine("Enter a number between 1 and 999: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                // feedback loop for incorrect guesses from user
                while (guess != secretNum)
                {
                    if (guess < secretNum)
                    {
                        Console.WriteLine("Too low. Try again.");
                    }
                    else if (guess > secretNum)
                    {
                        Console.WriteLine("Too high. Try again.");
                    }
                    Console.WriteLine("Guess another number: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                // correct guess has been made
                Console.WriteLine("\nCongratulations. You have guessed the number!\n");

                // prompt user to play again
                Console.WriteLine("\nWould you like to play again? (y/n): ");
                string playAgain = Console.ReadLine();
                if (playAgain == "y")
                {
                    contPlay = true;
                }
                else
                {
                    contPlay = false;
                }
            }
        }
    }
}
