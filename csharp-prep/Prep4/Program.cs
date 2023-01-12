using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        // Ask the user for a series of numbers.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Create a local variable to store user answer as an integer.
        int userNumber;

        // Create a List called numbers.
        List<int> numbers = new List<int>();

        // Ask the user to enter the numbers. Stop when they enter 0.
        do
        {
            Console.Write("Enter number: ");
            string userAnswer = Console.ReadLine();
            userNumber = int.Parse(userAnswer);
        
            // Add each user number to 'numbers' List.
            numbers.Add(userNumber);
        } while (userNumber != 0);

        // Create a local variable to store sum of numbers in list.
        float sum = 0;

        // Create a local variable to store numbers of number in list.
        float times = -1;

        // Create a local variable to store the largest number.
        float biggest = 0;

        // Compute the sum, or total, of the numbers in the list.
        // Compute the average of the numbers in the list.
        // Find the maximum, or largest, number in the list.
        foreach (float n in numbers)
        {
            // To compute the sum, sum each number to 'sum' variable.
            sum = sum + n;
            // To compute the average; according to number of numbers in list, sum 1 to 'time' variable.
            times = times + 1;

            // If the value of 'biggest' variable is less than the number in list, that value converts itself in that number.
            if (biggest < n)
            {
                biggest = n;
            }
        }

        // Print sum.
        Console.WriteLine($"The sum is: {sum}.");

        // Create a local variable to store the average. Get the average dividing sum by times.
        float average = sum / times;
        // Print average.
        Console.WriteLine($"The average is: {average}.");

        // Print the biggest number in list.
        Console.Write($"The largest number is: {biggest}.");

    }
}