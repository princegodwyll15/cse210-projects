// Eternal Goal Class
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine("Event recorded for Eternal Goal.");
    }

    public override bool IsComplete() => false;
}
