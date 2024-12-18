public class SimpleGoal:Goal{
    public SimpleGoal(string name, string descrition, int points) : base(name,descrition,points){}
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