public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine("Goal completed!");
        }
        else
        {
            Console.WriteLine("Goal is already complete.");
        }
    }

    public override bool IsComplete() => _isComplete;
}
