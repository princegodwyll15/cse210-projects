public class EternalGoal : Goal{
    public EternalGoal(string name, string descrpition, int points) : base(name,descrpition,points){}
    public override void RecordEvent()
    {
        base.RecordEvent();
    }
    public override void IsComplete()
    {
        base.IsComplete();
    }
    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }
}