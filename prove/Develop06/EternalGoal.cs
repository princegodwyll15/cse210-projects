public class EternalGoal : Goal
{
    private int timesRecorded;

    public EternalGoal(string name, int points) : base(name, points)
    {
        timesRecorded = 0;
    }

    public int GetTimesRecorded()
    {
        return timesRecorded;
    }

    public void SetTimesRecorded(int value)
    {
        timesRecorded = value;
    }

    public override void RecordEvent(ref int score)
    {
        timesRecorded++;
        score += GetPoints();
        Console.WriteLine($"You recorded the eternal goal '{GetName()}' and earned {GetPoints()} points. You've recorded this goal {timesRecorded} times.");
    }

    public override string GetStatus()
    {
        return $"[∞] Times Recorded: {timesRecorded}";
    }

    public override string Serialize()
    {
        return $"EternalGoal|{GetName()}|{GetPoints()}|{timesRecorded}";
    }

    public static EternalGoal Deserialize(string[] parts)
    {
        var goal = new EternalGoal(parts[1], int.Parse(parts[2]));
        goal.SetTimesRecorded(int.Parse(parts[3]));
        return goal;
    }
}
