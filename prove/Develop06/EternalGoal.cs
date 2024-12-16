public class EternalGoal : Goal
{
    private int timesRecorded;

    public EternalGoal(string name, int points) : base(name, points)
    {
        timesRecorded = 0;
    }

    public int TimesRecorded => timesRecorded;

    public override void RecordEvent()
    {
        timesRecorded++;
        Console.WriteLine($"You recorded the eternal goal '{Name}' and earned {Points} points. You've recorded this goal {timesRecorded} times.");
    }
}
