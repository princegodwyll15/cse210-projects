public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(int amountCompleted, int target, int bonus, string description, string name, int points) 
        : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"Progress: {_amountCompleted}/{_target}");

        if (IsComplete())
        {
            Console.WriteLine($"Checklist Goal completed! Bonus {_bonus} points awarded.");
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" - Completed {_amountCompleted}/{_target} (Bonus: {_bonus} points)";
    }
}
