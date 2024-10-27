using System;

public class SimpleGoal : Goal
{
    public bool IsCompleted { get; private set; } = false;

    public SimpleGoal(string name, int points) : base(name, points) { }

    public override int GetPoints()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            return Points;
        }
        return 0;
    }

    public override void ShowGoal()
    {
        string status = IsCompleted ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {GoalName} - {Points} points");
    }

    public override string ToString()
    {
        return $"SimpleGoal|{GoalName}|{Points}|{IsCompleted}";
    }
}
