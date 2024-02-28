using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
        
        while (playAgain)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);
            int guess = -1;
            int numberOfGuesses = 0;

            while (guess != number)
            {
                Console.Write("What is your guess? ");
                string guessStr = Console.ReadLine();

                if (!int.TryParse(guessStr, out guess))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    continue;
                }

                numberOfGuesses++;

                if (number > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (number < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it in " + numberOfGuesses + " guesses!");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            string playAgainStr = Console.ReadLine();
            playAgain = (playAgainStr.ToLower() == "yes");
        }
    }
}
