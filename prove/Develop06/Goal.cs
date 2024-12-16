public abstract class Goal
{
    private string name;
    private int points;

    protected Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
    }

    public string Name => name;
    public int Points => points;

    public abstract void RecordEvent();
}


