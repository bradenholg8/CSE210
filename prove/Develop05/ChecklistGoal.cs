public class ChecklistGoal : Goal
{
    public int TargetCount { get; private set; }
    public int BonusPoints { get; private set; }
    public int CompletedCount { get; private set; }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CompletedCount = 0;
    }

    public override void RecordEvent()
    {
        CompletedCount++;
        if (CompletedCount >= TargetCount)
        {
            IsComplete = true;
            Points += BonusPoints;
        }
    }
}
