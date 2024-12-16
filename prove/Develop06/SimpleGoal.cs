public class SimpleGoal : Goal
{
    private bool isCompleted;

    public SimpleGoal(string name, int points) : base(name, points)
    {
        isCompleted = false;
    }

    public bool IsCompleted => isCompleted;

    public override void RecordEvent()
    {
        if (!isCompleted)
        {
            isCompleted = true;
            Console.WriteLine($"Congratulations! You completed the goal '{Name}' and earned {Points} points.");
        }
        else
        {
            Console.WriteLine($"You've already completed the goal '{Name}'.");
        }
    }
}
