using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a list of numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int sum = 0;
        int count = 0;
        int maxNumber = int.MinValue;

        // Input loop
        while (true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            // Check if the input is 0 to terminate the loop
            if (number == 0)
                break;

            // Add the number to the sum
            sum += number;
            count++;

            // Update the maximum number if needed
            if (number > maxNumber)
                maxNumber = number;
        }

        // Compute and print the sum
        Console.WriteLine($"The sum is: {sum}");

        // Compute and print the average
        int average = sum / count;
        Console.WriteLine($"The average is: {average}");

        // Print the maximum number
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}
