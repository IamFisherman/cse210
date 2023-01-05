using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int userGrade = int.Parse(userInput);

        string letter = "";

        int percentageTotal = (userGrade % 10);

        if (userGrade >= 90)
        {
            if (percentageTotal < 3)
            {
                letter = "A-";
            }
            else
            {
                letter = "A";
            }
        }
        else if (userGrade >= 80)
        {
            if (percentageTotal < 3)
            {
                letter = "B-";
            }
            else if (percentageTotal >= 7)
            {
                letter = "B+";
            }
            else
            {
                letter = "B";
            }
        }
        else if (userGrade >= 70)
        {
            if (percentageTotal < 3)
            {
                letter = "C-";
            }
            else if (percentageTotal >= 7)
            {
                letter = "C+";
            }
            else
            {
                letter = "C";
            }
        }
        else if (userGrade >= 60)
        {
            if (percentageTotal < 3)
            {
                letter = "D-";
            }
            else if (percentageTotal >= 7)
            {
                letter = "D+";
            }
            else
            {
                letter = "D";
            }
        }
        else if (userGrade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (userGrade >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the class.");
        }
        else
        {
            Console.WriteLine("You have not passed the class, but you will do better next time.");
        }
    }
}