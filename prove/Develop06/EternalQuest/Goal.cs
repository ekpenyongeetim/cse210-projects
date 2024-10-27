using System;

public abstract class Goal
{
    public string GoalName { get; set; }
    public int Points { get; set; }

    protected Goal(string name, int points)
    {
        GoalName = name;
        Points = points;
    }

    public abstract int GetPoints();
    public abstract void ShowGoal();
    public abstract override string ToString(); // Override ToString for saving goals
}
