using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Main function.
        static void Main()
        {
            DisplayWelcome();
            string name = PromptUserName();
            int favoriteNumber = PromptUserNumber();
            int squared = SquareNumber(favoriteNumber);
            Console.Write($"{name}, the square of your number is {squared}.");
        }

        // DisplayWelcome - Displays the message, "Welcome to the Program!"
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        // PromptUserName - Asks for and returns the user's name (as a string).
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }

        // PromptUserNumber - Asks for and returns the user's favorite number (as an integer).
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string userAnswerFavoriteNumber = Console.ReadLine();
            int userFavoriteNumber = int.Parse(userAnswerFavoriteNumber);
            return userFavoriteNumber;
        }

        // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer).
        static int SquareNumber(int number)
        {
            int numberSquared = number * number;
            return numberSquared;
        }

        // Call the main function.
        Main();
        
    }
}