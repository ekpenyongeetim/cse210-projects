using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override int GetPoints()
    {
        return Points;
    }

    public override void ShowGoal()
    {
        Console.WriteLine($"[∞] {GoalName} - {Points} points per action");
    }

    public override string ToString()
    {
        return $"EternalGoal|{GoalName}|{Points}";
    }
}
