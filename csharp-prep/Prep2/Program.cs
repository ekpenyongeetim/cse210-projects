using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter grade number: ");
        string valueFromUser = Console.ReadLine();

        int x = int.Parse(valueFromUser);
        int a = 90;
        int b = 80;
        int c = 70;
        int d = 60;
        string letter = ""; // Initialize the variable to store the letter grade

        // Determine the letter grade
        if (x >= a)
        {
            letter = "A";
        }
        else if (x >= b)
        {
            letter = "B";
        }
        else if (x >= c)
        {
            letter = "C";
        }
        else if (x >= d)
        {
            letter = "D";
        }
        else
        {
            letter = "F"; 
        }

        // Determine if the user passed the course and print appropriate message
        if (letter != "F" && letter != "D")
        {
            Console.WriteLine("!!! Congratulation, You have passed this course !!!");
        }
        else
        {
            Console.WriteLine("Sorry You Failed this course. Better Luck next time.");
        }

        // Print the letter grade
        Console.WriteLine($"Your grade is: {letter}");
    }
}
