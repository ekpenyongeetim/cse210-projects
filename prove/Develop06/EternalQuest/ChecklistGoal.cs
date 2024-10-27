public class ChecklistGoal : Goal
{
    private int _completedCount = 0;
    private int _requiredCount;
    private int _bonusPoints;

    public ChecklistGoal(): base()
    {
        _requiredCount = requiredCount;
        _bonusPoints = bonusPoints;
    }

    // Increment the completion count and calculate points, including the bonus if done
    public override int GetPoints()
    {
        return 0;
    }

    // Show progress of checklist goal
    public override void ShowGoal()
    {
        Console.WriteLine("Hello World!");
    }
}
