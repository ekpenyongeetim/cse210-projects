using System;

public class ChecklistGoal : Goal
{
    private int _completedCount = 0;
    private int _requiredCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, int points, int requiredCount, int bonusPoints)
        : base(name, points)
    {
        _requiredCount = requiredCount;
        _bonusPoints = bonusPoints;
    }

    // Increment the completion count and calculate points, including the bonus if done
    public override int GetPoints()
    {
        if (_completedCount < _requiredCount)
        {
            _completedCount++;
            if (_completedCount == _requiredCount)
            {
                return Points + _bonusPoints;
            }
            return Points;
        }
        return 0;
    }

    // Show progress of checklist goal
    public override void ShowGoal()
    {
        string status = _completedCount >= _requiredCount ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {GoalName} - {Points} points, Completed {_completedCount}/{_requiredCount} times");
    }
}
