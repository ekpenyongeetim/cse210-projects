using System;

public class SimpleGoal : Goal
{
    // Store if the goal is completed
    public bool IsCompleted { get; private set; } = false;

    public SimpleGoal(string name, int points) : base(name, points)
    {
    }

    // Mark the goal as completed and return points
    public override int GetPoints()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            return Points;
        }
        return 0;
    }

    // Show if the goal is completed
    public override void ShowGoal()
    {
        string status = IsCompleted ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {GoalName} - {Points} points");
    }
}
