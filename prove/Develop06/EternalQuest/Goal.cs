using System;

public abstract class Goal
{
    // Store the name and points of the goal
    public string GoalName { get; set; }
    public int Points { get; set; }

    // Constructor to set the name and points
    protected Goal(string name, int points)
    {
        GoalName = name;
        Points = points;
    }

    // Abstract method to calculate and return the points earned
    public abstract int GetPoints();

    // Display the goal with its name
    public abstract void ShowGoal();
}
