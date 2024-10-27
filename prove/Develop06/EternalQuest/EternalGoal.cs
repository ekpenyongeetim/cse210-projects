using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points)
    {
    }

    // This goal always gives points
    public override int GetPoints()
    {
        return Points;
    }

    // Display this ongoing goal
    public override void ShowGoal()
    {
        Console.WriteLine($"[∞] {GoalName} - {Points} points per action");
    }
}
