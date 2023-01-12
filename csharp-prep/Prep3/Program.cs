using System;

class Program
{
    static void Main(string[] args)
    {

        // Start by asking the user for the magic number.
        // Console.Write("What is the magic number? ");
        // string userNumber = Console.ReadLine();
        // int userMagicNumber = int.Parse(userNumber);

        // Generate a random number from 1 to 10.
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);

        // Tell the user about what to do with this program.
        Console.WriteLine("Guess a number between 1 to 10.");

        // Create a variable for the guess number.
        int userGuessNumber;

        // Create a variable to track times when Do-While loop runs.
        int times = 0;

        // Add a loop that keeps looping as long as the guess does not match the magic number.
        do
        {
            // Ask the user for a guess.
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            userGuessNumber = int.Parse(userGuess);

            // Using an if statement, determine if the user needs to guess...
            // ...higher or lower next time, or tell them if they guessed it.
            if (userGuessNumber < magicNumber)
            {
                Console.WriteLine("Lower.");
            }
            else if (userGuessNumber > magicNumber)
            {
                Console.WriteLine("Higher.");
            }
            else
            {
                Console.WriteLine($"Yes! You are right. The magic number is {userGuessNumber}.");
            }
            
            // Each time Do-While loop runs, it will add 1 to 'times' variable.
            times++;
            
        } while (userGuessNumber != magicNumber);

        // A message to know how many guesses the user has made and inform them of it at the end of the game.
        Console.WriteLine($"You have tried {times} times to guess the magic number.");

    }
}