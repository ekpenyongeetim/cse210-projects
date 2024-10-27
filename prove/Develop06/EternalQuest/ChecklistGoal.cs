using System;

public class ChecklistGoal : Goal
{
    private int _requiredCount;
    private int _bonusPoints;

    // Public property to track completion count
    public int CompletedCount { get; set; } = 0;

    public ChecklistGoal(string name, int points, int requiredCount, int bonusPoints)
        : base(name, points)
    {
        _requiredCount = requiredCount;
        _bonusPoints = bonusPoints;
    }

    public override int GetPoints()
    {
        if (CompletedCount < _requiredCount)
        {
            CompletedCount++;
            if (CompletedCount == _requiredCount)
            {
                return Points + _bonusPoints;
            }
            return Points;
        }
        return 0;
    }

    public override void ShowGoal()
    {
        string status = CompletedCount >= _requiredCount ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {GoalName} - {Points} points, Completed {CompletedCount}/{_requiredCount} times");
    }

    public override string ToString()
    {
        return $"ChecklistGoal|{GoalName}|{Points}|{_requiredCount}|{_bonusPoints}|{CompletedCount}";
    }
}
