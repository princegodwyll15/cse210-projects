public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;

    public ChecklistGoal(string name, int points, int targetCount) : base(name, points)
    {
        this.targetCount = targetCount;
        currentCount = 0;
    }

    public int GetTargetCount()
    {
        return targetCount;
    }

    public void SetTargetCount(int value)
    {
        targetCount = value;
    }

    public int GetCurrentCount()
    {
        return currentCount;
    }

    public void SetCurrentCount(int value)
    {
        currentCount = value;
    }

    public override void RecordEvent(ref int score)
    {
        if (currentCount < targetCount)
        {
            currentCount++;
            score += GetPoints();
            Console.WriteLine($"You recorded the checklist goal '{GetName()}' and earned {GetPoints()} points. Progress: {currentCount}/{targetCount}.");

            if (currentCount == targetCount)
            {
                Console.WriteLine($"Congratulations! You completed the checklist goal '{GetName()}'!");
            }
        }
        else
        {
            Console.WriteLine($"The checklist goal '{GetName()}' is already completed.");
        }
    }

    public override string GetStatus()
    {
        return currentCount >= targetCount ? "[X]" : $"[ ] Progress: {currentCount}/{targetCount}";
    }

    public override string Serialize()
    {
        return $"ChecklistGoal|{GetName()}|{GetPoints()}|{targetCount}|{currentCount}";
    }

    public static ChecklistGoal Deserialize(string[] parts)
    {
        var goal = new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]));
        goal.SetCurrentCount(int.Parse(parts[4]));
        return goal;
    }
}

