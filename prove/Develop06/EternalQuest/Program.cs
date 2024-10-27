using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int totalScore = 0;

        while (true)
        {
            Console.WriteLine("\n--- Eternal Quest ---");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Show Total Score");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(goals);
                    break;
                case "2":
                    ShowAllGoals(goals);
                    break;
                case "3":
                    SaveGoals(goals);
                    break;
                case "4":
                    LoadGoals(goals);
                    break;
                case "5":
                    totalScore += RecordAchievement(goals);
                    break;
                case "6":
                    Console.WriteLine($"Total Score: {totalScore}");
                    break;
                case "7":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }

    static void CreateNewGoal(List<Goal> goals)
    {
        Console.WriteLine("Choose Goal Type: 1. Simple 2. Eternal 3. Checklist");
        string? typeChoice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string? name = Console.ReadLine();
        name = name ?? "Unnamed Goal"; // Default if null

        Console.Write("What is the description of your goal? ");
        string? description = Console.ReadLine();

        Console.Write("How many points do I want associated with this goal? ");
        string? pointsInput = Console.ReadLine();
        int points = int.TryParse(pointsInput, out int parsedPoints) ? parsedPoints : 0;

        switch (typeChoice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, points));
                break;
            case "3":
                Console.Write("Enter Required Times to Complete: ");
                string? requiredCountInput = Console.ReadLine();
                int requiredCount = int.TryParse(requiredCountInput, out int parsedRequiredCount) ? parsedRequiredCount : 0;

                Console.Write("Enter Bonus Points: ");
                string? bonusPointsInput = Console.ReadLine();
                int bonusPoints = int.TryParse(bonusPointsInput, out int parsedBonusPoints) ? parsedBonusPoints : 0;

                goals.Add(new ChecklistGoal(name, points, requiredCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid type choice.");
                break;
        }
    }

    // Updated ShowAllGoals Method
    static void ShowAllGoals(List<Goal> goals)
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("There are no goals to display.");
        }
        else
        {
            foreach (Goal goal in goals)
            {
                goal.ShowGoal();
            }
        }
    }

    static void SaveGoals(List<Goal> goals)
    {
        Console.Write("Enter a file name to save goals: ");
        string? fileName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(fileName))
        {
            Console.WriteLine("Invalid file name.");
            return;
        }

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.ToString());
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }

    static void LoadGoals(List<Goal> goals)
    {
        Console.Write("Enter a file name to load goals: ");
        string? fileName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(fileName))
        {
            Console.WriteLine("Invalid file name.");
            return;
        }

        if (File.Exists(fileName))
        {
            goals.Clear();

            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                string goalType = parts[0];
                string name = parts[1];
                int points = int.Parse(parts[2]);

                if (goalType == "SimpleGoal")
                {
                    bool isCompleted = bool.Parse(parts[3]);
                    var simpleGoal = new SimpleGoal(name, points) { IsCompleted = isCompleted };
                    goals.Add(simpleGoal);
                }
                else if (goalType == "EternalGoal")
                {
                    goals.Add(new EternalGoal(name, points));
                }
                else if (goalType == "ChecklistGoal")
                {
                    int requiredCount = int.Parse(parts[3]);
                    int bonusPoints = int.Parse(parts[4]);
                    int completedCount = int.Parse(parts[5]);
                    var checklistGoal = new ChecklistGoal(name, points, requiredCount, bonusPoints)
                    {
                        CompletedCount = completedCount
                    };
                    goals.Add(checklistGoal);
                }
            }

            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    static int RecordAchievement(List<Goal> goals)
    {
        Console.WriteLine("Select a Goal to Record:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            goals[i].ShowGoal();
        }

        string? goalIndexInput = Console.ReadLine();
        int goalIndex = int.TryParse(goalIndexInput, out int parsedGoalIndex) ? parsedGoalIndex - 1 : -1;

        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            int points = goals[goalIndex].GetPoints();
            Console.WriteLine($"You earned {points} points!");
            return points;
        }
        else
        {
            Console.WriteLine("Invalid selection.");
            return 0;
        }
    }
}
