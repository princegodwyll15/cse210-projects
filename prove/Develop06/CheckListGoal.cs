public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;

    public ChecklistGoal(string name, int points, int targetCount) : base(name, points)
    {
        this.targetCount = targetCount;
        currentCount = 0;
    }

    public int TargetCount => targetCount;
    public int CurrentCount => currentCount;

    public override void RecordEvent()
    {
        currentCount++;
        Console.WriteLine($"You recorded the checklist goal '{Name}' and earned {Points} points. You've completed this goal {currentCount}/{targetCount} times.");
        if (currentCount >= targetCount)
        {
            Console.WriteLine($"Congratulations! You completed the checklist goal '{Name}' and earned a bonus!");
        }
    }
}
