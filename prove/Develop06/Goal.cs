public abstract class Goal
{
    private string name;
    private int points;

    protected Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string value)
    {
        name = value;
    }

    public int GetPoints()
    {
        return points;
    }

    public void SetPoints(int value)
    {
        points = value;
    }

    public abstract void RecordEvent(ref int score);
    public abstract string GetStatus();
    public abstract string Serialize();
}
