public class SimpleGoal : Goal
{
    private bool isCompleted;

    public SimpleGoal(string name, int points) : base(name, points)
    {
        isCompleted = false;
    }

    public bool GetIsCompleted()
    {
        return isCompleted;
    }

    public void SetIsCompleted(bool value)
    {
        isCompleted = value;
    }

    public override void RecordEvent(ref int score)
    {
        if (!isCompleted)
        {
            isCompleted = true;
            score += GetPoints();
            Console.WriteLine($"You completed the goal '{GetName()}' and earned {GetPoints()} points!");
        }
        else
        {
            Console.WriteLine($"The goal '{GetName()}' is already completed.");
        }
    }

    public override string GetStatus()
    {
        return isCompleted ? "[X]" : "[ ]";
    }

    public override string Serialize()
    {
        return $"SimpleGoal|{GetName()}|{GetPoints()}|{isCompleted}";
    }

    public static SimpleGoal Deserialize(string[] parts)
    {
        var goal = new SimpleGoal(parts[1], int.Parse(parts[2]));
        goal.SetIsCompleted(bool.Parse(parts[3]));
        return goal;
    }
}
